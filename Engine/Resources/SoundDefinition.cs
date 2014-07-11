namespace DarkTech.Engine.Resources
{
    public sealed class SoundDefinition : Resource
    {
        public float Gain { get; private set; }
        public float Pitch { get; private set; }
        public float Balance { get; private set; }
        public float Range { get; private set; }
        public bool Loop { get; private set; }        
        public SoundData SoundData { get; private set; }

        public SoundDefinition() : base(ResourceCategory.Sound)
        {

        }

        public override void Dispose() { }
    }
}
