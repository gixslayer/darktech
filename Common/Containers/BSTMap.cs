using System;
using System.Collections;
using System.Collections.Generic;

namespace DarkTech.Common.Containers
{
    public sealed class BSTMap<TKey, TValue> : IMap<TKey, TValue> where TKey : IComparable<TKey>
    {
        private Node root;

        public int Count { get; private set; }

        public BSTMap()
        {
            this.root = null;
            this.Count = 0;
        }

        public TValue this[TKey key]
        {
            get
            {
                return Get(key);
            }
            set
            {
                Set(key, value);
            }
        }

        public void Add(TKey key, TValue value)
        {
            if (root == null)
            {
                root = new Node(new KeyValuePair<TKey, TValue>(key, value));

                Count++;
            }

            if (Add(root, key, value))
            {
                Count++;
            }
        }

        public bool Contains(TKey key)
        {
            Node currentNode = root;

            while (currentNode != null)
            {
                int compareResult = currentNode.Data.Key.CompareTo(key);

                if (compareResult == 0) // currentNode.Data.Key == key
                {
                    return true;
                }
                else if (compareResult < 0) // currentNode.Data.Key < key
                {
                    currentNode = currentNode.Right;
                }
                else // currentNode.Data.Key > key
                {
                    currentNode = currentNode.Left;
                }
            }

            return false;
        }

        public void Remove(TKey key)
        {
            if (root == null)
            {
                return;
            }

            root = Remove(root, key);
        }

        public void Clear()
        {
            root = null;
            Count = 0;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return new Enumerator(root);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(root);
        }

        private bool Add(Node node, TKey key, TValue value)
        {
            int compareResult = node.Data.Key.CompareTo(key);

            if (compareResult == 0) // node.Data.Key == key
            {
                return false; // Prevent duplicate key entry.
            }
            else if (compareResult < 0) // node.Data.Key < key
            {
                if (node.Right == null)
                {
                    node.Right = new Node(new KeyValuePair<TKey, TValue>(key, value));

                    return true;
                }

                return Add(node.Right, key, value);
            }
            else // node.Data.Key > key
            {
                if (node.Left == null)
                {
                    node.Left = new Node(new KeyValuePair<TKey, TValue>(key, value));

                    return true;
                }

                return Add(node.Left, key, value);
            }
        }

        private TValue Get(TKey key)
        {
            Node currentNode = root;

            while (currentNode != null)
            {
                int compareResult = currentNode.Data.Key.CompareTo(key);

                if (compareResult == 0) // currentNode.Data.Key == key
                {
                    return currentNode.Data.Value;
                }
                else if (compareResult < 0) // currentNode.Data.Key < key
                {
                    currentNode = currentNode.Right;
                }
                else // currentNode.Data.Key > key
                {
                    currentNode = currentNode.Left;
                }
            }

            throw new KeyNotFoundException();
        }

        private void Set(TKey key, TValue value)
        {
            Node currentNode = root;

            while (currentNode != null)
            {
                int compareResult = currentNode.Data.Key.CompareTo(key);

                if (compareResult == 0) // currentNode.Data.Key == key
                {
                    currentNode.Data.Value = value;

                    return;
                }
                else if (compareResult < 0) // currentNode.Data.Key < key
                {
                    currentNode = currentNode.Right;
                }
                else // currentNode.Data.Key > key
                {
                    currentNode = currentNode.Left;
                }
            }

            // Key does not exist within tree, add new entry.
            Add(key, value);
        }

        private Node Remove(Node node, TKey key)
        {
            if (node == null)
            {
                return null;
            }

            int compareResult = node.Data.Key.CompareTo(key);

            if (compareResult == 0) // node.Data.Key == key
            {
                // Delete the node 'node'.

                // No children.
                if (node.Left == null && node.Right == null)
                {
                    Count--;

                    return null;
                }
                else if (node.Left == null) // Only right child.
                {
                    Count--;

                    return node.Right;
                }
                else if (node.Right == null) // Only left child.
                {
                    Count--;

                    return node.Left;
                }
                else // Both children.
                {
                    Node min = FindMin(node.Right);

                    node.Data = min.Data;
                    node.Right = Remove(node.Right, min.Data.Key);
                }
            }
            else if (compareResult < 0) // node.Data.Key < key
            {
                node.Right = Remove(node.Right, key);
            }
            else // node.Data.Key > key
            {
                node.Left = Remove(node.Left, key);
            }

            return node;
        }

        private Node FindMin(Node node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }

        private sealed class Node
        {
            public KeyValuePair<TKey, TValue> Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            internal Node(KeyValuePair<TKey, TValue> data, Node left = null, Node right = null)
            {
                this.Data = data;
                this.Left = left;
                this.Right = right;
            }
        }

        private sealed class Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>
        {
            private readonly IStack<Node> stack;
            private KeyValuePair<TKey, TValue> current;

            public KeyValuePair<TKey, TValue> Current
            {
                get { return current; }
            }
            object IEnumerator.Current
            {
                get { return (object)current; }
            }

            internal Enumerator(Node root)
            {
                this.stack = new LinkedStack<Node>();
                this.current = null;

                stack.Push(root);
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                Node node = stack.Pop();

                current = node.Data;

                if (node.Left != null)
                {
                    stack.Push(node.Left);
                }

                if (node.Right != null)
                {
                    stack.Push(node.Right);
                }

                return true;
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }
        }
    }
}
