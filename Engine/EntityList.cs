using System.Collections;

namespace DarkTech.Engine
{
    internal sealed class EntityList : IEnumerable
    {
        private int length;
        private EntityListEntry top;

        public int Length { get { return length; } }

        public EntityList()
        {
            length = 0;
            top = null;
        }

        public void Add(Entity value)
        {
            top = new EntityListEntry(value, top);

            length++;
        }

        public bool Contains(Entity value)
        {
            for (EntityListEntry walker = top; walker != null; walker = walker.Next)
            {
                if (walker.Value.Equals(value))
                {
                    return true;
                }
            }

            return false;
        }

        public bool Remove(Entity value)
        {
            EntityListEntry walker = top;
            EntityListEntry prev = null;

            for (int i = 0; i < length; i++)
            {
                if (walker.Value.Equals(value))
                {
                    // Remove the current entry.
                    if (walker == top)
                    {
                        top = walker.Next;
                    }
                    else
                    {
                        prev.Next = walker.Next;
                    }

                    length--;

                    return true;
                }

                prev = walker;
                walker = walker.Next;
            }

            return false;
        }

        public bool Remove(int index, Entity value)
        {
            EntityListEntry walker = top;
            EntityListEntry prev = null;

            for (int i = 0; i < length; i++)
            {
                if (i >= index)
                {
                    if (walker.Value.Equals(value))
                    {
                        // Remove the current entry.
                        if (walker == top)
                        {
                            top = walker.Next;
                        }
                        else
                        {
                            prev.Next = walker.Next;
                        }

                        length--;

                        return true;
                    }
                }

                prev = walker;
                walker = walker.Next;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            RemoveAt(index, 1);
        }

        public void RemoveAt(int index, int count)
        {
            if (count < 1)
            {
                throw new System.ArgumentOutOfRangeException("count");
            }

            if (index < 0 || index + count > length)
            {
                throw new System.ArgumentOutOfRangeException("index");
            }

            EntityListEntry walker = top;
            EntityListEntry prev = null;

            // Advance to the first entry to remove.
            for (int i = 0; i < index; i++)
            {
                prev = walker;
                walker = walker.Next;
            }

            // Find the node that will be the next node for the node before the remove point (can be null).
            EntityListEntry target = walker;

            for (int i = 0; i < count; i++)
            {
                target = target.Next;
            }

            // Remove the nodes in between.
            if (walker == top)
            {
                top = target;
            }
            else
            {
                prev.Next = target;
            }

            length -= count;
        }

        public void Clear()
        {
            top = null;
            length = 0;
        }

        public IEnumerator GetEnumerator()
        {
            return new EntityListEnum(top);
        }
    }

    internal sealed class EntityListEntry
    {
        public Entity Value { get; set; }
        public EntityListEntry Next { get; set; }

        public EntityListEntry(Entity value, EntityListEntry next)
        {
            Value = value;
            Next = next;
        }
    }

    internal sealed class EntityListEnum : IEnumerator
    {
        private EntityListEntry topEntry;
        private EntityListEntry currentEntry;

        public EntityListEnum(EntityListEntry top)
        {
            this.topEntry = top;
            this.currentEntry = top;
        }

        public object Current
        {
            get { return currentEntry.Value; }
        }

        public bool MoveNext()
        {
            // Prevent a null pointer exception on empty lists (topEntry and currentEntry will always be null).
            if (currentEntry == null)
            {
                return false;
            }

            currentEntry = currentEntry.Next;

            return currentEntry != null;
        }

        public void Reset()
        {
            currentEntry = topEntry;
        }
    }
}
