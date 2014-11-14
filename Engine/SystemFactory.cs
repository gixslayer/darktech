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
        public static IFileSystem CreateFileSystem()
        {
            return Platform.CreateFileSystem();
        }

        public static Window CreateWindow()
        {
            IntPtr hInstance = Process.GetCurrentProcess().Handle;
            WindowConfiguration config = new WindowConfiguration();

            config.ClassName = Engine.ScriptingInterface.GetCvarValue<string>("w_className");
            config.Title = Engine.ScriptingInterface.GetCvarValue<string>("w_title");
            config.X = Engine.ScriptingInterface.GetCvarValue<int>("w_x");
            config.Y = Engine.ScriptingInterface.GetCvarValue<int>("w_y");
            config.Width = Engine.ScriptingInterface.GetCvarValue<int>("w_width");
            config.Height = Engine.ScriptingInterface.GetCvarValue<int>("w_height");
            config.Mode = Engine.ScriptingInterface.GetCvarValue<bool>("w_noBorder") ? WindowMode.NoBorder : WindowMode.Windowed;

            return Window.CreateWindow(hInstance, config);
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
            if (Engine.ScriptingInterface.GetCvarValue<bool>("snd_noSound") || Engine.ScriptingInterface.GetCvarValue<NetModel>("sys_netModel") == NetModel.ServerOnly)
                return new DummySoundSystem();
            else
                return new SoundSystem();
        }

        public static ITimer CreateTimer()
        {
            return Platform.CreateTimer();
        }
    }
}
