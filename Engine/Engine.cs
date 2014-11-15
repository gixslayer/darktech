using DarkTech.Engine.FileSystem;
using DarkTech.Engine.Graphics;
using DarkTech.Engine.Graphics.Render;
using DarkTech.Engine.Logging;
using DarkTech.Engine.Resources;
using DarkTech.Engine.Scripting;
using DarkTech.Engine.Sound;
using DarkTech.Engine.Timing;
using DarkTech.Engine.Utils;
using DarkTech.WindowLib;

namespace DarkTech.Engine
{
    public static partial class Engine
    {
        private static IClient client;
        private static IServer server;
        private static CvarBool sv_cheats;
        private static CvarEnum<EngineModel> sys_model;
        private static DeltaTimer clientTimer;
        private static DeltaTimer serverTimer;
        private static DeltaTimer debugTimer;

        public static LogDispatcher Log { get; private set; }
        public static FileSystem.FileSystem FileSystem { get; private set; }
        public static ResourceManager ResourceManager { get; private set; }
        public static ScriptingInterface ScriptingInterface { get; private set; }
        public static ISoundSystem SoundSystem { get; private set; }
        public static Window Window { get; private set; }
        public static IRenderer Renderer { get; private set; }
        public static ITimer Timer { get; private set; }
        public static bool ShutdownRequested { get; private set; }
        public static bool CheatsEnabled { get { return sv_cheats; } }
        public static EngineModel Model { get { return sys_model.Value; } }
        public static bool HasClient { get { return Model != EngineModel.ServerOnly; } }
        public static bool HasServer { get { return Model != EngineModel.ClientOnly; } }

        #region Control
        public static bool Start(EngineConfiguration configuration)
        {
            ShutdownRequested = false;
            Log = new LogDispatcher();

            // Always send log messages to stdout.
            Log.RegisterReceiver(new ConsoleLogWriter());

            // Ensure the current platform is supported.
            if (!Platform.IsSupported())
            {
                Log.WriteLine("error/system/startup", "Unsupported platform");

                return false;
            }

            try
            {
                Initialize(configuration);
            }
            catch (InitializeException e)
            {
                Log.WriteLine("error/system/startup", e.Message);

                return false;
            }

            Run();
            Shutdown();

            return true;
        }

        public static void RequestShutdown()
        {
            ShutdownRequested = true;
        }
        #endregion

        #region Initialize
        private static void Initialize(EngineConfiguration configuration)
        {
            // Create the scripting interface first so any other component can register their cvars/commands.
            ScriptingInterface = SystemFactory.CreateScriptingInterface();

            // Register cvars/commands that are required by the engine.
            RegisterCvars(configuration);
            RegisterCommands();

            // Create the file system now so that the client/server dlls can be loaded.
            FileSystem = SystemFactory.CreateFileSystem();

            if (HasServer)
            {
                server = LoadDLL<IServer>("fs_server");

                server.Initialize();
            }

            if (HasClient)
            {
                client = LoadDLL<IClient>("fs_client");

                client.Initialize();
            }

            ResourceManager = SystemFactory.CreateResourceManager();
            SoundSystem = SystemFactory.CreateSoundSystem();
            Window = SystemFactory.CreateWindow();
            Renderer = SystemFactory.CreateRenderer();
            Timer = SystemFactory.CreateTimer();

            if (HasServer)
            {
                server.Load();
            }

            if (HasClient)
            {
                Renderer.Initialize();
                client.Load();
                SoundSystem.Initialize();
            }
        }

        private static void RegisterCvars(EngineConfiguration configuration)
        {
            RegisterSharedCvars(configuration);
            
            if (HasServer)
            {
                RegisterServerOnlyCvars(configuration);
            }

            if (HasClient)
            {
                RegisterClientOnlyCvars(configuration);
            }
        }

        private static void RegisterSharedCvars(EngineConfiguration configuration)
        {
            // sys - System.            
            sys_model = ScriptingInterface.RegisterCvarEnum<EngineModel>("sys_model", "Model of the engine", CvarFlag.WriteProtected, configuration.Model);

            // fs - File system.
            ScriptingInterface.RegisterCvarString("fs_root", "Root of the file system", CvarFlag.ReadOnly, configuration.RootDirectory);
        }

        private static void RegisterClientOnlyCvars(EngineConfiguration configuration)
        {
            // cl - Client.
            ScriptingInterface.RegisterCvarInt("cl_fps", "Amount of client frames per second", CvarFlag.None, 1000, 1, 1000);

            ScriptingInterface.RegisterCvarCallback<int>("cl_fps", cl_fpsCallback);

            // fs - File system.
            ScriptingInterface.RegisterCvarString("fs_client", "Client DLL location", CvarFlag.ReadOnly, configuration.ClientDLL);

            // r - Renderer.
            ScriptingInterface.RegisterCvarEnum<Vsync>("r_vsync", "Vsync mode", CvarFlag.None, Vsync.On);

            // snd - Sound system.
            ScriptingInterface.RegisterCvarString("snd_device", "Name of the sound device to use", CvarFlag.None, "default");
            ScriptingInterface.RegisterCvarInt("snd_freq", "Sound frequency", CvarFlag.ReadOnly, 44100);
            ScriptingInterface.RegisterCvarInt("snd_bufferSize", "Sound buffer size in samples", CvarFlag.None, 147, 1, 44100);
            ScriptingInterface.RegisterCvarInt("snd_bufferCount", "Amount of preprocessed buffers", CvarFlag.None, 2, 1, 100);
            ScriptingInterface.RegisterCvarBool("snd_shutdownRequested", "Determines if a sound system shutdown is requested", CvarFlag.WriteProtected, false);
            ScriptingInterface.RegisterCvarBool("snd_noSound", "Disable sound", CvarFlag.None, false);
            ScriptingInterface.RegisterCvarFloat("snd_distanceModel_exp_bias", "Bias for the exponential distance model", CvarFlag.None, 2f, 1f, 100f);
            ScriptingInterface.RegisterCvarFloat("snd_distanceModel_invExp_bias", "Bias for the inverse exponential distance model", CvarFlag.None, 2f, 1f, 100f);
            ScriptingInterface.RegisterCvarEnum<DistanceModel>("snd_distanceModel", "Distance model for positional audio", CvarFlag.None, DistanceModel.Linear);

            // w - Window, client should set the appropriate values during initialization.
            ScriptingInterface.RegisterCvarString("w_className", "Window class name", CvarFlag.ReadOnly, "DarkTech-Engine");
            ScriptingInterface.RegisterCvarString("w_title", "Window title", CvarFlag.None, "DarkTech Engine");
            ScriptingInterface.RegisterCvarInt("w_x", "Window x location", CvarFlag.None, 0, 0, 65536);
            ScriptingInterface.RegisterCvarInt("w_y", "Window y location", CvarFlag.None, 0, 0, 65536);
            ScriptingInterface.RegisterCvarInt("w_width", "Window width", CvarFlag.None, 1280, 1, 65536);
            ScriptingInterface.RegisterCvarInt("w_height", "Window height", CvarFlag.None, 720, 1, 65536);
            ScriptingInterface.RegisterCvarBool("w_noBorder", "Remove window border", CvarFlag.None, false);
        }

        private static void RegisterServerOnlyCvars(EngineConfiguration configuration)
        {
            // fs - File system.
            ScriptingInterface.RegisterCvarString("fs_server", "Server DLL location", CvarFlag.ReadOnly, configuration.ServerDLL);

            // sv - Server.
            sv_cheats = ScriptingInterface.RegisterCvarBool("sv_cheats", "Enable cheats", CvarFlag.WriteProtected, false);
            ScriptingInterface.RegisterCvarInt("sv_fps", "Amount of server frames per second", CvarFlag.WriteProtected, 20, 1, 1000);

            ScriptingInterface.RegisterCvarCallback<int>("sv_fps", sv_fpsCallback);
        }

        private static void RegisterCommands()
        {
            ScriptingInterface.RegisterCommand("quit", "Closes the engine and returns to the desktop", false, quit);

            // r - Renderer.
            ScriptingInterface.RegisterCommand("r_restart", "Restart the renderer", false, r_restart);

            // snd - Sound system.
            ScriptingInterface.RegisterCommand("snd_restart", "Restart the sound system", false, snd_restart);
        }

        private static T LoadDLL<T>(string pathCvar)
        {
            string dllPath = ScriptingInterface.GetCvarValue<string>(pathCvar);
            T result;

            if (!AssemblyUtils.LoadType<T>(dllPath, out result))
            {
                throw new InitializeException("Failed to load dll {0}", dllPath);
            }

            return result;
        }
        #endregion

        #region Run
        private static void Run()
        {
            if (HasClient)
            {
                // Start the sound system thread.
                SoundSystem.Start();

                // Make the window visible.
                Window.Show();
            }

            // Enter the game loop. This will block the calling thread until the engine shuts down.
            GameLoop();
            
            // Shut down systems and perform cleanup.
            Shutdown();
        }

        private static void GameLoop()
        {
            float tsClient = 1.0f / ScriptingInterface.GetCvarValue<int>("cl_fps");
            float tsServer = 1.0f / ScriptingInterface.GetCvarValue<int>("sv_fps");
            float tsDebug = 1.0f;

            clientTimer = new DeltaTimer(Timer, tsClient);
            serverTimer = new DeltaTimer(Timer, tsServer);
            debugTimer = new DeltaTimer(Timer, tsDebug);

            while (!ShutdownRequested)
            {
                if (HasServer)
                {
                    ServerFrame();
                }

                if (HasClient)
                {
                    ClientFrame();
                }

                DebugFrame();
            }
        }

        private static void ServerFrame()
        {
            serverTimer.Update();

            // Server receive.

            while (serverTimer.HasNextFrame)
            {
                server.Update(serverTimer.Timestep);
                serverTimer.RanFrame();
            }
        }

        private static void ClientFrame()
        {
            clientTimer.Update();

            Window.ProcessEvents();

            while (clientTimer.HasNextFrame)
            {
                client.Update(clientTimer.Timestep);
                clientTimer.RanFrame();
            }

            Renderer.BeginFrame();
            client.Render();
            Renderer.EndFrame();
        }

        private static void DebugFrame()
        {
            debugTimer.Update();

            if (debugTimer.HasNextFrame)
            {
                // Compute client/server ups/fps.

                debugTimer.ResetAccumilator();
            }
        }

        #endregion

        #region Shutdown
        private static void Shutdown()
        {
            ResourceManager.Dispose();
            Timer.Dispose();

            if (HasServer)
            {
                server.Dispose();
            }

            if (HasClient)
            {
                client.Dispose();
                SoundSystem.Dispose();
                Renderer.Dispose();
                Window.Destroy();
            }

            Log.Dispose();
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

        #region Cvar callbacks
        private static void sv_fpsCallback(string name, int oldValue, int newValue)
        {
            serverTimer.Timestep = 1.0f / newValue;
        }

        private static void cl_fpsCallback(string name, int oldValue, int newValue)
        {
            clientTimer.Timestep = 1.0f / newValue;
        }
        #endregion
    }
}
