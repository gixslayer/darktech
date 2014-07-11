using System;
using System.Collections;
using System.Collections.Generic;

namespace DarkTech.Common.Containers
{
    public sealed class HashSet<T> : ISet<T>
    {
        private readonly IEqualityComparer<T> comparer;
        private readonly Bucket[] buckets;

        public int Count { get; private set; }

        public HashSet(int buckets = 1024, int initialCapacity = 16)
        {
            this.comparer = EqualityComparer<T>.Default;
            this.buckets = new Bucket[buckets];

            for (int i = 0; i < buckets; i++)
            {
                this.buckets[i] = new Bucket(initialCapacity);
            }
        }

        public bool Add(T item)
        {
            int hash = comparer.GetHashCode(item);
            int bucketIndex = hash & buckets.Length;

            if (buckets[bucketIndex].Add(item))
            {
                Count++;

                return true;
            }

            return false;
        }

        public bool Contains(T item)
        {
            int hash = comparer.GetHashCode(item);
            int bucketIndex = hash & buckets.Length;

            return buckets[bucketIndex].Contains(item);
        }

        public void Remove(T item)
        {
            int hash = comparer.GetHashCode(item);
            int bucketIndex = hash & buckets.Length;

            if (buckets[bucketIndex].Remove(item))
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

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }

        private sealed class Enumerator : IEnumerator<T>
        {
            private readonly IEnumerator<T>[] buckets;
            private int index;
            private T current;

            public T Current
            {
                get { return current; }
            }
            object IEnumerator.Current
            {
                get { return (object)current; }
            }

            public Enumerator(HashSet<T> set)
            {
                this.buckets = new IEnumerator<T>[set.buckets.Length];
                this.index = 0;
                this.current = default(T);

                for (int i = 0; i < set.buckets.Length; i++)
                {
                    buckets[i] = set.buckets[i].GetEnumerator();
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

        private sealed class Bucket : IEnumerable<T>
        {
            private readonly IList<T> list;

            internal Bucket(int initialCapacity = 16)
            {
                this.list = new ArrayList<T>(initialCapacity);
            }

            public bool Contains(T item)
            {
                return list.Contains(item);
            }

            public bool Add(T item)
            {
                if (list.Contains(item))
                {
                    return false;
                }

                list.Add(item);

                return true;
            }

            public bool Remove(T item)
            {
                int oldCount = list.Count;

                list.Remove(item);

                return list.Count != oldCount;
            }

            public void Clear()
            {
                list.Clear();
            }

            public IEnumerator<T> GetEnumerator()
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
