using System;
using System.Collections;
using System.Collections.Generic;

namespace DarkTech.Common.Containers
{
    public sealed class ArrayStack<T> : IStack<T>
    {
        private int index;
        private T[] elements;

        public int Count
        {
            get { return index; }
        }

        public ArrayStack(int initialCapacity = 16)
        {
            if (initialCapacity < 1)
            {
                throw new ArgumentOutOfRangeException("initialCapacity");
            }

            this.index = 0;
            this.elements = new T[initialCapacity];
        }

        public void CopyTo(ArrayStack<T> stack)
        {
            if (stack.elements.Length < Count)
            {
                stack.elements = new T[Count];
            }

            Array.Copy(elements, 0, stack.elements, 0, Count);
            stack.index = index;
        }

        public void Push(T item)
        {
            if (index >= elements.Length)
            {
                // Resize
                int newSize = elements.Length * 2;
                T[] oldElements = elements;
                elements = new T[newSize];

                Array.Copy(oldElements, 0, elements, 0, index);
            }

            elements[index++] = item;
        }

        public T Pop()
        {
            if (index == 0)
            {
                throw new InvalidOperationException("Cannot pop an empty stack");
            }

            T element = elements[--index];

            elements[index] = default(T);

            return element;
        }

        public T Peek()
        {
            if (index == 0)
            {
                throw new InvalidOperationException("Cannot peek an empty stack");
            }

            return elements[index - 1];
        }

        public void Clear()
        {
            if (index != 0)
            {
                Array.Clear(elements, 0, index);

                index = 0;
            }
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
            private int index;

            public T Current
            {
                get { return elements[index]; }
            }
            object IEnumerator.Current
            {
                get { return (object)elements[index]; }
            }

            internal Enumerator(ArrayStack<T> stack)
            {
                this.elements = stack.elements;
                this.index = stack.Count;
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                if (index <= 0)
                {
                    return false;
                }

                index--;

                return true;
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }
        }
    }
}
