using DarkTech.Engine.Resources;
using DarkTech.Engine.Sound.Mixing;

namespace DarkTech.Engine.Sound
{
    internal sealed class CommandPlaySoundAtEntity : Command
    {
        // TEMP PLACEHOLDER
        public int EntityID { get; set; }
        public SoundDefinition SoundDefinition { get; set; }
        public EffectChain EffectChain { get; set; }
        public int MixerChannelIndex { get; set; }

        internal CommandPlaySoundAtEntity() : base(CommandType.PlaySoundAtEntity) { }
    }
}
