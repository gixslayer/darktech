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
        public static bool CheatsEnabled { get; private set; }
    }
}
