using System;
using System.Diagnostics;

using DarkTech.Engine.FileSystem;
using DarkTech.Engine.Graphics;
using DarkTech.Engine.Graphics.Render;
using DarkTech.Engine.Resources;
using DarkTech.Engine.Scripting;
using DarkTech.Engine.Sound;
using DarkTech.Engine.Timing;
using DarkTech.WindowLib;

namespace DarkTech.Engine
{
    internal static class SystemFactory
    {
        public static FileSystem.FileSystem CreateFileSystem()
        {
            return new FileSystem.FileSystem();
        }

        public static Window CreateWindow()
        {
            IntPtr hInstance = Process.GetCurrentProcess().Handle;
            WindowConfiguration config = new WindowConfiguration();
            Window window;

            config.ClassName = Engine.ScriptingInterface.GetCvarValue<string>("w_className");
            config.Title = Engine.ScriptingInterface.GetCvarValue<string>("w_title");
            config.X = Engine.ScriptingInterface.GetCvarValue<int>("w_x");
            config.Y = Engine.ScriptingInterface.GetCvarValue<int>("w_y");
            config.Width = Engine.ScriptingInterface.GetCvarValue<int>("w_width");
            config.Height = Engine.ScriptingInterface.GetCvarValue<int>("w_height");
            config.Mode = Engine.ScriptingInterface.GetCvarValue<bool>("w_noBorder") ? WindowMode.NoBorder : WindowMode.Windowed;

            try
            {
                window = Window.CreateWindow(hInstance, config);
                window.Create();
            }
            catch (WindowException e)
            {
                throw new InitializeException("Failed to create window: {0}", e.Message);
            }

            return window;
        }

        public static ResourceManager CreateResourceManager()
        {
            return new ResourceManager();
        }

        public static ScriptingInterface CreateScriptingInterface()
        {
            return new ScriptingInterface();
        }

        public static IRenderer CreateRenderer()
        {
            return new OpenGLRenderer();
        }

        public static ISoundSystem CreateSoundSystem()
        {
            if (Engine.ScriptingInterface.GetCvarValue<bool>("snd_noSound") || Engine.ScriptingInterface.GetCvarValue<EngineModel>("sys_netModel") == EngineModel.ServerOnly)
                return new DummySoundSystem();
            else
                return new SoundSystem();
        }

        public static ITimer CreateTimer()
        {
            ITimer timer =  Platform.CreateTimer();

            if (!timer.Initialize())
            {
                throw new InitializeException("Timer failed to initialize");
            }

            return timer;
        }
    }
}
