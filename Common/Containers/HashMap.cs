using System;
using System.Collections;
using System.Collections.Generic;

namespace DarkTech.Common.Containers
{
    public sealed class HashMap<TKey, TValue> : IMap<TKey, TValue>
    {
        private readonly IEqualityComparer<TKey> comparer;
        private readonly Bucket[] buckets;

        public int Count { get; private set; }

        public HashMap(int buckets = 1024, bool useArrayList = true, int initialBucketCapacity = 16, IEqualityComparer<TKey> comparer = null)
        {
            this.comparer = comparer == null ? EqualityComparer<TKey>.Default : comparer;
            this.buckets = new Bucket[buckets];
            this.Count = 0;

            for (int i = 0; i < buckets; i++)
            {
                this.buckets[i] = new Bucket(comparer, useArrayList, initialBucketCapacity);
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                return GetBucket(key).Get(key);
            }
            set
            {
                if (GetBucket(key).Set(key, value))
                {
                    Count++;
                }
            }
        }

        public void Add(TKey key, TValue value)
        {
            GetBucket(key).Add(key, value);
            Count++;
        }

        public bool Contains(TKey key)
        {
            return GetBucket(key).Contains(key);
        }

        public void Remove(TKey key)
        {
            if (GetBucket(key).Remove(key))
            {
                Count--;
            }
        }

        public void Clear()
        {
            foreach (Bucket bucket in buckets)
            {
                bucket.Clear();
            }

            Count = 0;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }

        private Bucket GetBucket(TKey key)
        {
            return buckets[comparer.GetHashCode(key) % buckets.Length];
        }

        private sealed class Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>
        {
            private readonly IEnumerator<KeyValuePair<TKey, TValue>>[] buckets;
            private int index;
            private KeyValuePair<TKey, TValue> current;

            public KeyValuePair<TKey, TValue> Current
            {
                get { return current; }
            }
            object IEnumerator.Current
            {
                get { return (object)current; }
            }

            public Enumerator(HashMap<TKey, TValue> map)
            {
                this.buckets = new IEnumerator<KeyValuePair<TKey, TValue>>[map.buckets.Length];
                this.index = 0;
                this.current = null;

                for (int i = 0; i < map.buckets.Length; i++)
                {
                    buckets[i] = map.buckets[i].GetEnumerator();
                }
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                if (index >= buckets.Length)
                {
                    return false;
                }

                while (index < buckets.Length)
                {
                    if (!buckets[index].MoveNext())
                    {
                        index++;
                    }
                    else
                    {
                        current = buckets[index].Current;
                        return true;
                    }
                }

                return false;
            }

            public void Reset()
            {
                // Only required for COM Interoperability.
                throw new NotSupportedException();
            }
        }

        private sealed class Bucket : IEnumerable<KeyValuePair<TKey, TValue>>
        {
            private readonly IEqualityComparer<TKey> comparer;
            private readonly IList<KeyValuePair<TKey, TValue>> list;

            internal Bucket(IEqualityComparer<TKey> comparer, bool useArrayList, int initialCapacity)
            {
                this.comparer = comparer;
                this.list = useArrayList ? new ArrayList<KeyValuePair<TKey, TValue>>(initialCapacity) : (IList<KeyValuePair<TKey, TValue>>)new LinkedList<KeyValuePair<TKey, TValue>>();
            }

            public void Add(TKey key, TValue value)
            {
                foreach (KeyValuePair<TKey, TValue> element in list)
                {
                    if (comparer.Equals(element.Key, key))
                    {
                        throw new ArgumentException("Duplicate key", "key");
                    }
                }

                list.Add(new KeyValuePair<TKey, TValue>(key, value));
            }

            public bool Set(TKey key, TValue value)
            {
                foreach (KeyValuePair<TKey, TValue> element in list)
                {
                    if (comparer.Equals(element.Key, key))
                    {
                        element.Value = value;

                        return false;
                    }
                }

                list.Add(new KeyValuePair<TKey, TValue>(key, value));

                return true;
            }

            public bool Remove(TKey key)
            {
                int index = 0;
                bool found = false;

                foreach (KeyValuePair<TKey, TValue> element in list)
                {
                    if (comparer.Equals(element.Key, key))
                    {
                        found = true;
                        break;
                    }

                    index++;
                }

                if (found)
                {
                    list.RemoveAt(index);

                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool Contains(TKey key)
            {
                foreach (KeyValuePair<TKey, TValue> element in list)
                {
                    if (comparer.Equals(element.Key, key))
                    {
                        return true;
                    }
                }

                return false;
            }

            public TValue Get(TKey key)
            {
                foreach (KeyValuePair<TKey, TValue> element in list)
                {
                    if (comparer.Equals(element.Key, key))
                    {
                        return element.Value;
                    }
                }

                throw new KeyNotFoundException();
            }

            public void Clear()
            {
                list.Clear();
            }

            public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
            {
                return list.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return list.GetEnumerator();
            }
        }
    }
}
