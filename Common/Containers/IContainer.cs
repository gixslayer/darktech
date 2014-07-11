using System.Collections.Generic;

namespace DarkTech.Common.Containers
{
    public interface IContainer<T> : IEnumerable<T>
    {
        int Count { get; }

        void Clear();
    }
}
