using System;

namespace DarkTech.Engine.Resources
{
    public abstract class Resource : IDisposable
    {
        public ResourceCategory Category { get; private set; }

        public Resource(ResourceCategory category)
        {
            this.Category = category;
        }

        public abstract void Dispose();
    }
}
