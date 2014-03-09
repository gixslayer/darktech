namespace DarkTech.Engine
{
    internal sealed class EventQueue
    {
        private EventQueueEntry first;
        private EventQueueEntry last;

        public bool HasNext { get { return first != null; } }

        public EventQueue()
        {
            this.first = null;
            this.last = null;
        }

        public void Enqueue(Event e)
        {
            if (first == null)
            {
                first = new EventQueueEntry(e);
                last = first;
            }
            else
            {
                EventQueueEntry entry = new EventQueueEntry(e);

                last.Next = entry;
                last = entry;
            }
        }

        public Event Dequeue()
        {
            if (first == null)
                throw new System.InvalidOperationException("Cannot dequeue an empty queue");

            Event e = first.Event;

            first = first.Next;

            if (first == null)
            {
                last = null;
            }

            return e;
        }

        private class EventQueueEntry
        {
            public Event Event { get; set; }
            public EventQueueEntry Next { get; set; }

            public EventQueueEntry(Event e)
            {
                this.Event = e;
                this.Next = null;
            }
        }
    }
}
