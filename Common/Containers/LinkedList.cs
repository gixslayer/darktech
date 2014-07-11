using System;
using System.Collections;
using System.Collections.Generic;

namespace DarkTech.Common.Containers
{
    public sealed class LinkedList<T> : IList<T>
    {
        private Link head;

        public int Count { get; private set; }

        public LinkedList()
        {
            this.head = null;
            this.Count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("index");
                }

                Link result = head;

                for (int i = 0; i < index; i++)
                {
                    result = result.Next;
                }

                return result.Value;
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("index");
                }

                Link target = head;

                for (int i = 0; i < index; i++)
                {
                    target = target.Next;
                }

                target.Value = value;
            }
        }

        public void CopyTo(LinkedList<T> list)
        {
            list.Count = Count;
            list.head = head.Copy();
        }

        public void Add(T item)
        {
            head = new Link(item, head);

            Count++;
        }

        public void Insert(int index, T item)
        {
            if (index == 0)
            {
                head = new Link(item, head);
            }
            else
            {
                Link preceedingLink = head;

                for (int i = 1; i < index; i++)
                {
                    preceedingLink = preceedingLink.Next;
                }

                preceedingLink.Next = new Link(item, preceedingLink.Next);
            }

            Count++;
        }

        public void Remove(T item)
        {
            Link previous = null;
            Link current = head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous == null)
                    {
                        head = head.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

                    Count--;
                    break;
                }

                previous = current;
                current = current.Next;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                Link preceedingLink = head;

                for (int i = 1; i < index; i++)
                {
                    preceedingLink = preceedingLink.Next;
                }

                Link targetLink = preceedingLink.Next;

                preceedingLink.Next = targetLink.Next;
            }

            Count--;
        }

        public int IndexOf(T item)
        {
            int index = 0;

            for (Link walker = head; walker != null; walker = walker.Next)
            {
                if (walker.Value.Equals(item))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public bool Contains(T item)
        {
            for (Link walker = head; walker != null; walker = walker.Next)
            {
                if (walker.Value.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public void Clear()
        {
            head = null;
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(head);
        }

        private sealed class Link
        {
            public T Value { get; set; }
            public Link Next { get; set; }

            public Link(T value, Link next)
            {
                this.Value = value;
                this.Next = next;
            }

            public Link Copy()
            {
                return new Link(Value, Next == null ? null : Next.Copy());
            }
        }

        private sealed class Enumerator : IEnumerator<T>
        {
            private Link current;

            public T Current
            {
                get { return current.Value; }
            }
            object IEnumerator.Current
            {
                get { return (object)current.Value; }
            }

            internal Enumerator(Link head)
            {
                this.current = new Link(default(T), head);
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                if (current.Next == null)
                {
                    return false;
                }

                current = current.Next;

                return true;
            }

            public void Reset()
            {
                // Only used for COM Interoperability.
                throw new NotSupportedException();
            }
        }
    }
}
