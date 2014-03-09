using System;

using DarkTech.Engine.Resources;
using DarkTech.Engine.Scripting;

namespace DarkTech.Engine
{
    public static partial class Engine
    {
        public static SceneGraph Scene { get; private set; }
        public static FileSystem FileSystem { get; private set; }
        public static ResourceManager ResourceManager { get; private set; }
        public static ScriptingInterface ScriptingInterface { get; private set; }
        public static EventDispatcher EventDispatcher { get; private set; }

        public static bool CheatsEnabled { get { return ScriptingInterface.GetCvar<CvarBool>("sv_cheats"); } }

        public static bool Initialize()
        {
            AttachPrintStream(Console.Out);

            Scene = new SceneGraph();
            ResourceManager = new ResourceManager();
            ScriptingInterface = new ScriptingInterface();
            EventDispatcher = new EventDispatcher();

            try
            {
                FileSystem = Platform.CreateFileSystem();
            }
            catch (PlatformNotSupportedException e)
            {
                Error(e.Message);

                return false;
            }

            return true;
        }
    }
}
