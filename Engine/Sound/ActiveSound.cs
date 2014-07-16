using DarkTech.Common.Math;

using DarkTech.Engine.Resources;

namespace DarkTech.Engine.Sound
{
    internal sealed class ActiveSound
    {
        public Vector3f Location { get; set; }
        public Vector3f Direction { get; set; }
        public SoundDefinition SoundDefinition { get; set; }
        public bool IsDirty { get; set; }
    }
}
