﻿using System;
using System.Threading;

using DarkTech.Engine.FileSystem;
using DarkTech.Engine.Graphics;
using DarkTech.Engine.Graphics.Render;
using DarkTech.Engine.Graphics.Render.BackEnd;
using DarkTech.Engine.Graphics.Render.FrontEnd;
using DarkTech.Engine.Resources;
using DarkTech.Engine.Scripting;
using DarkTech.Engine.Sound;
using DarkTech.Engine.Utils;

namespace DarkTech.Engine
{
    public static partial class Engine
    {
        private static volatile bool shutdownRequested;
        private static bool hasShutdown;
        private static IClient client;
        private static IServer server;
        private static Thread gameThread;
        private static CvarBool sv_cheats;
        private static ManualResetEventSlim shutdownEvent;
        private static RenderQueue renderQueue;
        private static IRenderBackEnd renderBackEnd;

        public static IFileSystem FileSystem { get; private set; }
        public static ResourceManager ResourceManager { get; private set; }
        public static ScriptingInterface ScriptingInterface { get; private set; }
        public static ISoundSystem SoundSystem { get; private set; }
        public static IWindow Window { get; private set; }
        public static IRenderFrontEnd Renderer { get; private set; }
        public static bool ShutdownRequested { get { return shutdownRequested; } }
        public static bool CheatsEnabled { get { return sv_cheats; } }

        public static EventDispatcher EventDispatcher { get; private set; }
        public static SceneGraph Scene { get; private set; }

        public static bool Start(EngineConfiguration configuration)
        {
            Engine.shutdownRequested = false;
            Engine.hasShutdown = false;
            Engine.shutdownEvent = new ManualResetEventSlim(false);
            Engine.gameThread = new Thread(GameLoop);
            Engine.gameThread.Name = "Game";
            Thread.CurrentThread.Name = "Startup/Render";

            // Attach the stdout to the printing system.
            AttachPrintStream(Console.Out);

            // Ensure the current platform is supported.
            if (!Platform.IsSupported())
            {
                Engine.Error("Unsupported platform");

                return false;
            }

            if (!Initialize(configuration)) return false;

            Run();
            Shutdown();

            return true;
        }

        public static void RequestShutdown()
        {
            if (shutdownRequested)
                return;

            shutdownEvent.Set();
            shutdownRequested = true;
        }

        #region Initialize
        private static bool Initialize(EngineConfiguration configuration)
        {
            // Create scripting interface.
            ScriptingInterface = SystemFactory.CreateScriptingInterface();

            // Register cvars and commands.
            RegisterCvars(configuration);
            RegisterCommands();

            // Create remaining systems.
            FileSystem = SystemFactory.CreateFileSystem();
            ResourceManager = SystemFactory.CreateResourceManager();
            SoundSystem = SystemFactory.CreateSoundSystem();
            Window = SystemFactory.CreateWindow();
            renderQueue = SystemFactory.CreateRenderQueue();
            renderBackEnd = SystemFactory.CreateRenderBackEnd(renderQueue);
            Renderer = SystemFactory.CreateRenderFrontEnd(renderQueue);

            // Create window and graphics context.
            if (!Window.CreateWindow()) return false;
            if (!renderBackEnd.CreateContext()) return false;

            // Load server and client.
            if (!LoadServer()) return false;
            if (!LoadClient()) return false;

            // Initialize sound system.
            if (!SoundSystem.Initialize()) return false;

            return true;
        }

        private static void RegisterCvars(EngineConfiguration configuration)
        {
            RegisterSystemCvars(configuration);
            RegisterServerCvars();
            RegisterClientCvars();
        }

        private static void RegisterSystemCvars(EngineConfiguration configuration)
        {
            // sys - System.            
            ScriptingInterface.RegisterCvarEnum<NetModel>("sys_netModel", "Network model of the engine", CvarFlag.WriteProtected, configuration.NetModel);

            ScriptingInterface.RegisterCvarCallback<NetModel>("sys_netModel", sys_netModelCallback);

            // fs - File system.
            ScriptingInterface.RegisterCvarString("fs_root", "Root of the file system", CvarFlag.ReadOnly, configuration.RootDirectory);
            ScriptingInterface.RegisterCvarString("fs_client", "Client DLL location", CvarFlag.ReadOnly, configuration.ClientDLL);
            ScriptingInterface.RegisterCvarString("fs_server", "Server DLL location", CvarFlag.ReadOnly, configuration.ServerDLL);

            // snd - Sound system.
            ScriptingInterface.RegisterCvarString("snd_device", "Name of the sound device to use", CvarFlag.None, "default");
            ScriptingInterface.RegisterCvarInt("snd_freq", "Sound frequency", CvarFlag.ReadOnly, 44100);
            ScriptingInterface.RegisterCvarInt("snd_bufferSize", "Sound buffer size in samples", CvarFlag.None, 147, 1, 44100);
            ScriptingInterface.RegisterCvarInt("snd_bufferCount", "Amount of preprocessed buffers", CvarFlag.None, 2, 1, 100);
            ScriptingInterface.RegisterCvarBool("snd_shutdownRequested", "Determines if a sound system shutdown is requested", CvarFlag.WriteProtected, false);
            ScriptingInterface.RegisterCvarBool("snd_noSound", "Disable sound", CvarFlag.None, false);

            // w - Window, client should set the appropriate values during initialization.
            ScriptingInterface.RegisterCvarString("w_title", "Window title", CvarFlag.None, "DarkTech Engine");
            ScriptingInterface.RegisterCvarInt("w_x", "Window x location", CvarFlag.None, 0, 0, 65536);
            ScriptingInterface.RegisterCvarInt("w_y", "Window y location", CvarFlag.None, 0, 0, 65536);
            ScriptingInterface.RegisterCvarInt("w_width", "Window width", CvarFlag.None, 1280, 1, 65536);
            ScriptingInterface.RegisterCvarInt("w_height", "Window height", CvarFlag.None, 720, 1, 65536);

            // r - Renderer.
            ScriptingInterface.RegisterCvarEnum<Vsync>("r_vsync", "Vsync mode", CvarFlag.None, Vsync.On);
            ScriptingInterface.RegisterCvarBool("r_restartRequested", "Used by r_restart to request a render backend restart", CvarFlag.WriteProtected, false);
        }

        private static void RegisterClientCvars()
        {
            ScriptingInterface.RegisterCvarInt("cl_fps", "Amount of client frames per second", CvarFlag.None, 1000, 1, 1000);

            ScriptingInterface.RegisterCvarCallback<int>("cl_fps", cl_fpsCallback);
        }

        private static void RegisterServerCvars()
        {
            sv_cheats = ScriptingInterface.RegisterCvarBool("sv_cheats", "Enable cheats", CvarFlag.WriteProtected, false);
            ScriptingInterface.RegisterCvarInt("sv_fps", "Amount of server frames per second", CvarFlag.WriteProtected, 20, 1, 1000);

            ScriptingInterface.RegisterCvarCallback<int>("sv_fps", sv_fpsCallback);
        }

        private static void RegisterCommands()
        {
            ScriptingInterface.RegisterCommand("quit", "Closes the engine and returns to the desktop", false, quit);

            // r - Renderer.
            ScriptingInterface.RegisterCommand("r_restart", "Restart the render backend", false, r_restart);

            // snd - Sound system.
            ScriptingInterface.RegisterCommand("snd_restart", "Restart the sound system", false, snd_restart);
        }

        private static bool LoadServer()
        {
            server = new DummyServer();

            if (ScriptingInterface.GetCvarValue<NetModel>("sys_netModel") == NetModel.ClientOnly)
                return true;

            string serverPath = ScriptingInterface.GetCvarValue<string>("fs_server");

            if (!AssemblyUtils.LoadType<IServer>(serverPath, out server))
                return false;

            if (server.Initialize())
            {
                Engine.Printf("Server DLL {0} - {1} version {2} initialized successfully", server.Name, server.Author, server.Version);

                return true;
            }
            else
            {
                Engine.Error("Server DLL failed to initialize");

                return false;
            }
        }

        private static bool LoadClient()
        {
            client = new DummyClient();

            if (ScriptingInterface.GetCvarValue<NetModel>("sys_netModel") == NetModel.ServerOnly)
                return true;

            string clientPath = ScriptingInterface.GetCvarValue<string>("fs_client");

            if (!AssemblyUtils.LoadType<IClient>(clientPath, out client))
                return false;

            if (client.Initialize())
            {
                Engine.Printf("Client DLL {0} - {1} version {2} initialized successfully", client.Name, client.Author, client.Version);

                return true;
            }
            else
            {
                Engine.Error("Client DLL failed to initialize");

                return false;
            }
        }
        #endregion

        #region Run
        private static void Run()
        {
            // Start the sound system thread.
            SoundSystem.Start();

            // Start the game thread.
            gameThread.Start();

            // Show the window and enter the render back-end loop on the current thread.
            Window.ShowWindow();
            renderBackEnd.Start();

            // Block the current thread until a shutdown is requested (in case of a server only net model).
            shutdownEvent.Wait();

            // Shut down systems and perform cleanup.
            Shutdown();
        }
        #endregion

        #region Shutdown
        private static void Shutdown()
        {
            // Only run this cleanup method once.
            if (hasShutdown)
                return;

            // Engine.FatalError will call this method directly regardless of the value of shutdownRequested.
            // Make sure the value is true so all threads exit successfully.
            if (!shutdownRequested)
                shutdownRequested = true;

            // Dispose server and client.
            server.Dispose();
            client.Dispose();

            // Dispose resources.
            ResourceManager.Dispose();

            // Dispose render queue so that the render back-end will exit properly in SMP mode.
            renderQueue.Dispose();

            // Dispose the window which should also force it to close.
            Window.Dispose();

            hasShutdown = true;
        }
        #endregion

        #region Command handlers
        private static void quit(ArgList args)
        {
            RequestShutdown();
        }

        private static void snd_restart(ArgList args)
        {
            SoundSystem.Restart();
        }

        private static void r_restart(ArgList args)
        {
            CvarBool r_restartRequested = ScriptingInterface.GetCvar<CvarBool>("r_restartRequested");

            r_restartRequested.Value = true;
        }
        #endregion
    }
}
