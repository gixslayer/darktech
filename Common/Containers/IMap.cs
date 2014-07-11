using System.Collections.Generic;

namespace DarkTech.Common.Containers
{
    public interface IMap<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        int Count { get; }

        TValue this[TKey key] { get; set; }

        void Add(TKey key, TValue value);
        bool Contains(TKey key);
        void Remove(TKey key);
        void Clear();
    }
}
