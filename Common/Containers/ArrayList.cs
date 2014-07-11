using System;
using System.Collections;
using System.Collections.Generic;

namespace DarkTech.Common.Containers
{
    public sealed class ArrayList<T> : IList<T>
    {
        private int index;
        private T[] elements;

        public int Count 
        { 
            get { return index; } 
        }

        public ArrayList(int initialCapacity = 16)
        {
            // The initial capacity must be at least zero. 
            // Even though a capacity of zero would force a resize on the first store call it is considered valid.
            if (initialCapacity < 0)
            {
                throw new ArgumentOutOfRangeException("initialCapacity");
            }

            this.index = 0;
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

                return elements[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("index");
                }

                elements[index] = value;
            }
        }

        public void CopyTo(ArrayList<T> list)
        {
            if (list.elements.Length < index)
            {
                list.elements = new T[index];
            }

            Array.Copy(elements, 0, list.elements, 0, index);
            list.index = index;
        }

        public void Add(T item)
        {
            // Check if the list is full.
            if (index >= Count)
            {
                // Resize the list.
                Resize();
            }

            // Set the item to the first free element (at offset) and then increment the offset.
            elements[index++] = item;
        }

        public void Insert(int index, T item)
        {
            // Check if the list is full.
            if (this.index >= Count)
            {
                // Resize the list.
                Resize();
            }

            // Copy data from [index, Count) to [index + 1, Count + 1), effectively shifting all elements after index - 1 one step to the right
            // in order to create space for the new element.
            Array.Copy(elements, index, elements, index + 1, this.index - index);

            // Insert the new element.
            elements[index] = item;

            // Update the member index to account for the added element (as the Count property and the Add method rely on this value).
            this.index++;
        }

        public void Remove(T item)
        {
            // Find the index of the item.
            // If the item does not exist within the container, -1 is returned.
            int index = IndexOf(item);

            // Only remove the element at the returned index if it's a valid index.
            if (index != -1)
            {
                RemoveAt(index);
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            // Copy data from [index + 1, Count) to [index, Count - 1), effectively shifting all elements after index one step to the left
            // in order to remove the element at index and reorder the container at the same time.
            Array.Copy(elements, index + 1, elements, index, Count - (index + 1));

            // Update the member index to account for the removed element (as the Count property and the Add method rely on this value).
            this.index--;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (elements[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (elements[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public void Clear()
        {
            Array.Clear(elements, 0, index);

            index = 0;
        }

        private void Resize()
        {
            // Calculate the new size (double the current size).
            // Create a local reference to the current member reference 'elements'.
            // Allocate a new array with the new size which replaces the current member reference 'elements'.
            int newSize = elements.Length * 2;
            T[] oldElements = elements;
            elements = new T[newSize];

            // Copy the data from the old elements over to the new elements.
            Array.Copy(oldElements, 0, elements, 0, Count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ArrayList<T>.Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayList<T>.Enumerator(this);
        }

        private sealed class Enumerator : IEnumerator<T>
        {
            private readonly ArrayList<T> list;
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

            internal Enumerator(ArrayList<T> list)
            {
                this.list = list;
                this.index = 0;
                this.current = default(T);
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                if (index >= list.Count)
                {
                    current = default(T);

                    return false;
                }

                current = list[index++];

                return true;
            }

            public void Reset()
            {
                // Only required for COM interoperability.
                throw new NotSupportedException();
            }
        }
    }
}
