using System;
using System.Collections;
using System.Collections.Generic;

namespace DarkTech.Common.Containers
{
    public sealed class ArrayQueue<T> : IQueue<T>
    {
        private int enqueueOffset;
        private int dequeueOffset;
        private T[] elements;

        public int Count
        {
            get { return enqueueOffset - dequeueOffset; }
        }

        public ArrayQueue(int initialCapacity = 16)
        {
            if (initialCapacity < 1)
            {
                throw new ArgumentOutOfRangeException("initialCapacity");
            }

            this.enqueueOffset = 0;
            this.dequeueOffset = 0;
            this.elements = new T[initialCapacity];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("index");
                }

                return elements[dequeueOffset + index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("index");
                }

                elements[dequeueOffset + index] = value;
            }
        }

        public void CopyTo(ArrayQueue<T> queue)
        {
            if (queue.elements.Length < Count)
            {
                queue.elements = new T[Count];
            }

            Array.Copy(elements, dequeueOffset, queue.elements, 0, Count);
            queue.dequeueOffset = 0;
            queue.enqueueOffset = Count;
        }

        public void Enqueue(T item)
        {
            if (enqueueOffset >= elements.Length)
            {
                if (dequeueOffset != 0)
                {
                    // Push all elements to the start.
                    Array.Copy(elements, dequeueOffset, elements, 0, Count);

                    enqueueOffset = Count;
                    dequeueOffset = 0;
                }
                else
                {
                    // Resize elements.
                    int newSize = elements.Length * 2;
                    T[] oldElements = elements;
                    elements = new T[newSize];

                    Array.Copy(oldElements, 0, elements, 0, Count);
                }
            }

            elements[enqueueOffset++] = item;
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Cannot dequeue an empty queue");
            }

            T element = elements[dequeueOffset];

            elements[dequeueOffset++] = default(T);

            return element;
        }

        public void Clear()
        {
            if (Count != 0)
            {
                Array.Clear(elements, dequeueOffset, Count);
            }

            enqueueOffset = 0;
            dequeueOffset = 0;
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
            private readonly T[] elements;
            private readonly int last;
            private int offset;

            public T Current
            {
                get { return elements[offset]; }
            }
            object IEnumerator.Current
            {
                get { return (object)elements[offset]; }
            }

            internal Enumerator(ArrayQueue<T> queue)
            {
                this.elements = queue.elements;
                this.last = queue.enqueueOffset;
                this.offset = queue.Count == 0 ? last : queue.dequeueOffset - 1;
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                if (offset == last)
                {
                    return false;
                }

                offset++;

                return true;
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }
        }
    }
}
