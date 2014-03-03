using System.Collections;

namespace DarkTech.Engine
{
    internal sealed class ComponentSet : IEnumerable
    {
        private ComponentSetEntry top;
        private int count;

        public int Count { get { return count; } }

        public ComponentSet()
        {
            this.top = null;
            this.count = 0;
        }

        public void Add(Component component)
        {
            if (!Contains(component.GetType()))
            {
                top = new ComponentSetEntry(component, top);

                count++;
            }
            else
            {
                Engine.Warningf("Duplicate entry in ComponentSet ({0})", component.GetType().FullName);
            }
        }

        public bool Contains<T>() where T : Component
        {
            return Contains(typeof(T));
        }

        public void Remove<T>() where T : Component
        {
            System.Type type = typeof(T);
            ComponentSetEntry current = top;
            ComponentSetEntry prev = null;

            for (int i = 0; i < count; i++)
            {
                if (current.Value.GetType().Equals(type))
                {
                    if (current == top)
                    {
                        top = current.Next;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }

                    count--;

                    return;
                }

                prev = current;
                current = current.Next;
            }
        }

        public T Get<T>() where T : Component
        {
            System.Type type = typeof(T);

            for (ComponentSetEntry walker = top; walker != null; walker = walker.Next)
            {
                if (walker.Value.GetType().Equals(type))
                {
                    return (T)walker.Value;
                }
            }

            return null;
        }

        public void Clear()
        {
            top = null;
            count = 0;
        }

        private bool Contains(System.Type type)
        {
            for (ComponentSetEntry walker = top; walker != null; walker = walker.Next)
            {
                if (walker.Value.GetType().Equals(type))
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerator GetEnumerator()
        {
            return new ComponentSetEnumerator(top);
        }
    }

    internal sealed class ComponentSetEntry
    {
        public Component Value { get; set; }
        public ComponentSetEntry Next { get; set; }

        public ComponentSetEntry(Component value, ComponentSetEntry next)
        {
            this.Value = value;
            this.Next = next;
        }
    }

    internal sealed class ComponentSetEnumerator : IEnumerator
    {
        private ComponentSetEntry top;
        private ComponentSetEntry current;

        public ComponentSetEnumerator(ComponentSetEntry top)
        {
            this.top = top;
            this.current = top;
        }

        public object Current
        {
            get { return current.Value; }
        }

        public bool MoveNext()
        {
            if (current == null)
            {
                return false;
            }

            current = current.Next;

            return current != null;
        }

        public void Reset()
        {
            current = top;
        }
    }
}
