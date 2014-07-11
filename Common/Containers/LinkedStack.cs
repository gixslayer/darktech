using System;
using System.Collections;
using System.Collections.Generic;

namespace DarkTech.Common.Containers
{
    public sealed class LinkedStack<T> : IStack<T>
    {
        private Node top;

        public int Count { get; private set; }

        public LinkedStack()
        {
            this.top = null;
            this.Count = 0;
        }

        public void CopyTo(LinkedStack<T> stack)
        {
            stack.top = top == null ? null : top.Copy();
            stack.Count = Count;
        }

        public void Push(T item)
        {
            top = new Node(item, top);

            Count++;
        }

        public T Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Cannot pop empty stack");
            }

            // Get value of top entry.
            T value = top.Value;

            // Move top entry to the previous entry.
            top = top.Next;

            // Reduce the count.
            Count--;

            // Return the popped value.
            return value;
        }

        public T Peek()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Cannot peek empty stack");
            }

            return top.Value;
        }

        public void Clear()
        {
            top = null;
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(top);
        }

       IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(top);
        }

       private sealed class Node
       {
           public T Value { get; set; }
           public Node Next { get; set; }

           internal Node(T value, Node next)
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

           internal Enumerator(Node top)
           {
               this.current = new Node(default(T), top);
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
