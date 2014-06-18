using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkTech.Engine.Resources
{
    public sealed class SoundAlias : Resource
    {
        public float Gain { get; private set; }
        public float MinGain { get; private set; }
        public float MaxGain { get; private set; }
        public float Pitch { get; private set; }
        public SoundBuffer Buffer { get; private set; }

        public SoundAlias() : base(ResourceCategory.Sound)
        {

        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
