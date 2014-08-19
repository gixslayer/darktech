using DarkTech.Common.Math;

namespace DarkTech.Engine.Sound
{
    internal sealed class Listener
    {
        public Vector3f Location { get; set; }
        public Vector3f Direction { get; set; }
        public float Range { get; set; }
        public bool IsDirty { get; set; }

        public void Update(Listener listener)
        {
            this.IsDirty = !(this.Equals(listener));

            this.Location = listener.Location;
            this.Direction = listener.Direction;
            this.Range = listener.Range;
        }

        private bool Equals(Listener listener)
        {
            if (!this.Location.Equals(listener.Location)) return false;
            if (!this.Direction.Equals(listener.Direction)) return false;
            if (this.Range != listener.Range) return false;

            return true;
        }
    }
}
