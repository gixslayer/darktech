using DarkTech.Common.Math;
using DarkTech.Engine.Resources;
using DarkTech.Engine.Sound.Mixing;

namespace DarkTech.Engine.Sound
{
    internal sealed class CommandPlaySoundAt : Command
    {
        public SoundDefinition SoundDefinition { get; set; }
        public EffectChain EffectChain { get; set; }
        public int MixerChannelIndex { get; set; }
        public Vector3f Location { get; set; }
        public Vector3f Direction { get; set; }

        internal CommandPlaySoundAt() : base(CommandType.PlaySoundAt) { }
    }
}
