using System;
using System.Collections;
using System.Collections.Generic;

namespace DarkTech.Common.Containers
{
    public sealed class LinkedQueue<T> : IQueue<T>
    {
        private Node head;
        private Node tail;

        public int Count { get; private set; }

        public LinkedQueue()
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

                Node currentNode = head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                return currentNode.Value;
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("index");
                }

                Node currentNode = head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Value = value;
            }
        }

        public void CopyTo(LinkedQueue<T> queue)
        {
            Node headCopy = head == null ? null : head.Copy();
            Node tailCopy = headCopy;

            while (tailCopy != null && tailCopy.Next != null)
            {
                tailCopy = tailCopy.Next;
            }

            queue.head = headCopy;
            queue.tail = tailCopy;
            queue.Count = Count;
        }

        public void Enqueue(T item)
        {
            if (Count == 0)
            {
                head = new Node(item, null);
                tail = head;
            }
            else
            {
                Node newTail = new Node(item, null);
                tail.Next = newTail;
                tail = newTail;
            }

            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Cannot dequeue an empty queue");
            }

            T value = head.Value;
            head = head.Next;

            if (Count == 1)
            {
                tail = null;
            }

            Count--;

            return value;
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

        private sealed class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }

            public Node(T value, Node next)
            {
                this.Value = value;
                this.Next = next;
            }

            public Node Copy()
            {
                return new Node(Value, Next == null ? null : Next.Copy());
            }
        }

        private sealed class Enumerator : IEnumerator<T>
        {
            private Node current;

            public T Current
            {
                get { return current.Value; }
            }
            object IEnumerator.Current
            {
                get { return (object)current.Value; }
            }

            internal Enumerator(Node head)
            {
                this.current = new Node(default(T), head);
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
                throw new NotSupportedException();
            }
        }

    }
}
