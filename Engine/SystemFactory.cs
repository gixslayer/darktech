using DarkTech.Engine.FileSystem;
using DarkTech.Engine.Graphics;
using DarkTech.Engine.Graphics.Render;
using DarkTech.Engine.Graphics.Render.BackEnd;
using DarkTech.Engine.Graphics.Render.FrontEnd;
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
            if (Engine.ScriptingInterface.GetCvarValue<NetModel>("sys_netModel") == NetModel.ServerOnly) 
                return new DummyWindow();
            else
                return Platform.CreateWindow();
        }

        public static IRenderBackEnd CreateRenderBackEnd(RenderQueue renderQueue)
        {
            if (Engine.ScriptingInterface.GetCvarValue<NetModel>("sys_netModel") == NetModel.ServerOnly)
                return new DummyBackEnd();
            else
                return new OpenGLBackEnd(renderQueue);
        }

        public static IRenderFrontEnd CreateRenderFrontEnd(RenderQueue renderQueue)
        {
            return new RenderFrontEnd(renderQueue);
        }

        public static ResourceManager CreateResourceManager()
        {
            return new ResourceManager();
        }

        public static ScriptingInterface CreateScriptingInterface()
        {
            return new ScriptingInterface();
        }

        public static RenderQueue CreateRenderQueue()
        {
            return new RenderQueue();
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
