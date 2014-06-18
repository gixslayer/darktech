using DarkTech.Engine.FileSystem;
using DarkTech.Engine.Graphics;
using DarkTech.Engine.Resources;
using DarkTech.Engine.Scripting;
using DarkTech.Engine.Sound;
using DarkTech.Engine.Timing;

namespace DarkTech.Engine
{
    internal static class SystemFactory
    {
        public static IFileSystem CreateFileSystem()
        {
            return Platform.CreateFileSystem();
        }

        public static IWindow CreateWindow()
        {
            if (Engine.ScriptingInterface.GetCvarValue<bool>("sys_initGraphics")) 
            {
                return Platform.CreateWindow();
            }    
            else
                return new DummyWindow();
        }

        public static IRenderBackend CreateRenderBackend()
        {
            if (Engine.ScriptingInterface.GetCvarValue<bool>("sys_initGraphics"))
                return new BackendOpenGL();
            else
                return new DummyBackend();
        }

        public static ResourceManager CreateResourceManager()
        {
            return new ResourceManager();
        }

        public static ScriptingInterface CreateScriptingInterface()
        {
            return new ScriptingInterface();
        }

        public static ISoundSystem CreateSoundSystem()
        {
            // TODO: Create correct sound system
            /*if (Engine.ScriptingInterface.GetCvarValue<bool>("sys_initSound"))
                return new SoundSystemOpenAL();
            else
                return new DummySoundSystem();*/

            return null;
        }

        public static ITimer CreateTimer()
        {
            return Platform.CreateTimer();
        }
    }
}
