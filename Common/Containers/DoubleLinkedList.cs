using System;
using System.Collections;
using System.Collections.Generic;

namespace DarkTech.Common.Containers
{
    public sealed class DoubleLinkedList<T> : IList<T>
    {
        private Link head;
        private Link tail;

        public int Count { get; private set; }

        public DoubleLinkedList()
        {
            this.head = null;
            this.tail = null;
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

        public void CopyTo(DoubleLinkedList<T> list)
        {
            list.Count = Count;

            if (Count == 0)
            {
                // No entries in the list.
                list.head = null;
                list.tail = null;
            }
            else if (Count == 1)
            {
                // Only one entry, head and tail have the same reference.
                Link copy = head.Copy();

                list.head = copy;
                list.tail = copy;
            }
            else
            {
                // Multiple entires in the list, head and tail have different references.
                list.head = head.Copy();
                list.tail = tail.Copy();
            }
        }

        public void Add(T item)
        {
            if (Count == 0)
            {
                head = new Link(item, null, null);
                tail = head;
            }
            else
            {
                tail.Next = new Link(item, null, tail);
                tail = tail.Next;
            }

            Count++;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            if (index == 0)
            {
                // Insert in front of the head.
                if (Count == 0)
                {
                    // Insert into empty list.
                    head = new Link(item, null, null);
                    tail = head;
                }
                else
                {
                    // Insert in front of existing list.
                    head = new Link(item, head, null);
                    head.Next.Previous = head;
                }
            }
            else if (index == Count)
            {
                // Insert after the tail.
                tail.Next = new Link(item, null, tail);
                tail = tail.Next;
            }
            else
            {
                Link target = head;

                for (int i = 0; i < index; i++)
                {
                    target = target.Next;
                }

                Link newLink = new Link(item, target, target.Previous);
                newLink.Previous.Next = newLink;
                newLink.Next.Previous = newLink;
            }

            Count++;
        }

        public void Remove(T item)
        {
            for (Link target = head; target != null; target = target.Next)
            {
                if (target.Value.Equals(item))
                {
                    if (Count == 1)
                    {
                        // Remove the only link which is both head and tail.
                        head = null;
                        tail = null;
                    }
                    else  if (target.Previous == null)
                    {
                        // Remove head.
                        head = head.Next;
                        head.Previous = null;
                    }
                    else if (target.Next == null)
                    {
                        // Remove tail.
                        tail = tail.Previous;
                        tail.Next = null;
                    }
                    else
                    {
                        // Remove link in between head and tail.
                        Link origPrevious = target.Previous;
                        Link origNext = target.Next;

                        target.Previous.Next = origNext;
                        target.Next.Previous = origPrevious;
                    }

                    Count--;
                    break;
                }
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            if (Count == 1)
            {
                // Remove the only link which is both head and tail.
                head = null;
                tail = null;
            }
            else if (index == 0)
            {
                // Remove head.
                head = head.Next;
                head.Previous = null;
            }
            else if (index == Count - 1)
            {
                // Remove tail.
                tail = tail.Previous;
                tail.Next = null;
            }
            else
            {
                // Remove link in between head and tail.
                Link target = head;

                for (int i = 0; i < index; i++)
                {
                    target = target.Next;
                }

                Link origPrevious = target.Previous;
                Link origNext = target.Next;

                target.Previous.Next = origNext;
                target.Next.Previous = origPrevious;
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
            tail = null;
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
            public Link Previous { get; set; }
            public Link Next { get; set; }
            public T Value { get; set; }

            public Link(T value, Link next, Link previous)
            {
                this.Value = value;
                this.Next = next;
                this.Previous = previous;
            }

            public Link Copy(Link parent = null)
            {
                return new Link(Value, Next == null ? null : Next.Copy(this), parent);
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
                this.current = new Link(default(T), head, null);
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
                // Only required for COM Interoperability.
                throw new NotSupportedException();
            }
        }
    }
}
