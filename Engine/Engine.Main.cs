using System;
using System.Threading;

using DarkTech.Engine.FileSystem;
using DarkTech.Engine.Graphics;
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
        private static CvarBool sv_cheats;

        internal static IRenderBackend RenderBackend { get; private set; }
        internal static RenderQueue RenderQueue { get; private set; }

        public static IFileSystem FileSystem { get; private set; }
        public static ResourceManager ResourceManager { get; private set; }
        public static ScriptingInterface ScriptingInterface { get; private set; }
        public static ISoundSystem SoundSystem { get; private set; }
        public static IWindow Window { get; private set; }
        public static bool ShutdownRequested { get { return shutdownRequested; } }
        public static bool CheatsEnabled { get { return sv_cheats; } }

        public static EventDispatcher EventDispatcher { get; private set; }
        public static SceneGraph Scene { get; private set; }

        public static bool Start(EngineConfiguration configuration)
        {
            Engine.shutdownRequested = false;
            Engine.hasShutdown = false;

            // Attach the print streams to the printing system.
            AttachPrintStream(configuration.PrintStreams.ToArray());

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
            RenderQueue = new RenderQueue();
            RenderBackend = SystemFactory.CreateRenderBackend();

            // Create sound/graphics context.
            if (!Window.CreateWindow()) return false;
            if (!RenderBackend.CreateContext()) return false;
            if (!SoundSystem.CreateContext()) return false;

            // Load server and client.
            if (!LoadServer()) return false;
            if (!LoadClient()) return false;

            RenderBackend.Initialize();
            SoundSystem.Initialize();

            return true;
        }

        private static void RegisterCvars(EngineConfiguration configuration)
        {
            RegisterSystemCvars(configuration);

            if (configuration.InitializeGraphicsSystem) 
                RegisterGraphicsCvars();

            if (configuration.InitializeServer) 
                RegisterServerCvars();

            if (configuration.InitializeClient) 
                RegisterClientCvars();
        }

        private static void RegisterSystemCvars(EngineConfiguration configuration)
        {
            // sys - System.
            ScriptingInterface.RegisterCvarInt("sys_maxFps", "Maximum frames per second to render", CvarFlag.None, 120, 1, 1000);
            ScriptingInterface.RegisterCvarInt("sys_ups", "Amount of updates per second", CvarFlag.ReadOnly, 60, 1, 1000);
            ScriptingInterface.RegisterCvarBool("sys_initClient", "Initialize the client", CvarFlag.ReadOnly, configuration.InitializeClient);
            ScriptingInterface.RegisterCvarBool("sys_initServer", "Initialize the server", CvarFlag.ReadOnly, configuration.InitializeServer);
            ScriptingInterface.RegisterCvarBool("sys_initSound", "Initialize the sound system", CvarFlag.ReadOnly, configuration.InitializeSoundSystem);
            ScriptingInterface.RegisterCvarBool("sys_initGraphics", "Initialize the graphic system", CvarFlag.ReadOnly, configuration.InitializeGraphicsSystem);
            ScriptingInterface.RegisterCvarBool("sys_smp", "Use multicore processing", CvarFlag.WriteProtected, false);
            ScriptingInterface.RegisterCvarEnum<NetModel>("sys_netModel", "Network model of the engine", CvarFlag.WriteProtected, NetModel.Mixed);

            // fs - File system.
            ScriptingInterface.RegisterCvarString("fs_root", "Root of the file system", CvarFlag.ReadOnly, configuration.RootDirectory);
            ScriptingInterface.RegisterCvarString("fs_client", "Client DLL location", CvarFlag.ReadOnly, configuration.ClientDLL);
            ScriptingInterface.RegisterCvarString("fs_server", "Server DLL location", CvarFlag.ReadOnly, configuration.ServerDLL);

            ScriptingInterface.RegisterCvarCallback<int>("sys_maxFps", sys_maxFpsCallback);
            ScriptingInterface.RegisterCvarCallback<NetModel>("sys_netModel", sys_netModelCallback);
        }

        private static void RegisterGraphicsCvars()
        {
            // w - Window, client should set the appropriate values during initialization.
            ScriptingInterface.RegisterCvarString("w_title", "Window title", CvarFlag.WriteProtected, "DarkTech Engine");
            ScriptingInterface.RegisterCvarInt("w_x", "Window x location", CvarFlag.None, 0, 0, 65536);
            ScriptingInterface.RegisterCvarInt("w_y", "Window y location", CvarFlag.None, 0, 0, 65536);
            ScriptingInterface.RegisterCvarInt("w_width", "Window width", CvarFlag.None, 1280, 1, 65536);
            ScriptingInterface.RegisterCvarInt("w_height", "Window height", CvarFlag.None, 720, 1, 65536);

            // r - Renderer
            ScriptingInterface.RegisterCvarEnum<Vsync>("r_vsync", "Vsync mode", CvarFlag.None, Vsync.On);
        }

        private static void RegisterClientCvars()
        {

        }

        private static void RegisterServerCvars()
        {
            sv_cheats = ScriptingInterface.RegisterCvarBool("sv_cheats", "Enable cheats", CvarFlag.WriteProtected, false);
            ScriptingInterface.RegisterCvarInt("sv_ups", "Amount of server updates per second", CvarFlag.WriteProtected, 20, 1, 1000);
        }

        private static void RegisterCommands()
        {
            ScriptingInterface.RegisterCommand("quit", "Closes the engine and returns to the desktop", false, quit);
        }

        private static bool LoadServer()
        {
            server = new DummyServer();

            if (!ScriptingInterface.GetCvarValue<bool>("sys_initServer"))
                return true;

            string serverPath = Engine.ScriptingInterface.GetCvarValue<string>("fs_server");

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

            if (!ScriptingInterface.GetCvarValue<bool>("sys_initClient"))
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
            EnterGameLoop();
            ShowWindow();
        }

        private static void EnterGameLoop()
        {
            // If no window is created don't spawn a new thread to run the game loop, but run the game loop on the current thread.
            if (!ScriptingInterface.GetCvarValue<bool>("sys_initGraphics"))
            {
                // Will block until RequestShutdown is called.
                GameLoop();
            }
            else
            {
                // A window is created, spawn a new thread to run the game loop on.
                Thread mainLoopThread = new Thread(GameLoop);
                mainLoopThread.Name = "Main loop";

                mainLoopThread.Start();
            }
        }

        private static void ShowWindow()
        {
            // If no window is created don't do anything.
            if (!ScriptingInterface.GetCvarValue<bool>("sys_initGraphics"))
                return;

            // Will start the window message loop on the current thread, blocks until the window closes.
            Window.EnterMessageLoop();

            // Once the window closes request a shutdown to make sure all other threads also exit.
            RequestShutdown();
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
            RenderQueue.Dispose();

            // Dispose the window which should also force it to close.
            Window.Dispose();

            hasShutdown = true;
        }
        #endregion

        private static void quit(ArgList args)
        {
            RequestShutdown();
        }
    }
}
