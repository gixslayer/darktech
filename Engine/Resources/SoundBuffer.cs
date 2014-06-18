using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkTech.Engine.Resources
{
    public sealed class SoundBuffer : Resource
    {
        internal uint Handle { get; private set; }

        public SoundBuffer()
            : base(ResourceCategory.Sound)
        {

        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
