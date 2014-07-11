using DarkTech.Common.Math;

namespace DarkTech.Engine.Sound
{
    internal sealed class Listener
    {
        public Vector3f Location { get; set; }
        public Vector3f Angle { get; set; }
        public float Range { get; set; }
        public float InnerAngle { get; set; }
        public float OuterAngle { get; set; }
        public bool IsDirty { get; set; }
    }
}
