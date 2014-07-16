using System;

using DarkTech.Engine.Resources;
using DarkTech.Engine.Sound.Mixing;

namespace DarkTech.Engine.Sound
{
    internal sealed class CommandPlaySound : Command
    {
        public SoundDefinition SoundDefinition { get; set; }
        public EffectChain EffectChain { get; set; }
        public int MixerChannelIndex { get; set; }

        internal CommandPlaySound() : base(CommandType.PlaySound) { }
    }
}
