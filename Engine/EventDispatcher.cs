using System;
using System.Collections.Generic;

namespace DarkTech.Engine
{
    public delegate void EventHandler<T>(T e) where T : Event;

    public sealed class EventDispatcher
    {
        private EventQueue producer;
        private EventQueue consumer;
        private Dictionary<EventType, List<EventHandlerBase>> handlers;

        public EventDispatcher()
        {
            this.producer = new EventQueue();
            this.consumer = new EventQueue();
            this.handlers = new Dictionary<EventType, List<EventHandlerBase>>();
        }

        public void RegisterHandler<T>(Action<T> handler) where T : Event
        {
            EventType eventType = Event.GetEventType<T>();

            if (!handlers.ContainsKey(eventType))
            {
                handlers.Add(eventType, new List<EventHandlerBase>());
            }

            handlers[eventType].Add(new EventHandler<T>(handler));
        }

        // Several threads will call this function.
        public void Enqueue(Event e)
        {
            lock (producer)
            {
                producer.Enqueue(e);
            }
        }

        // Only one thread will call this function (Main engine thread).
        internal void Pump()
        {
            // Swap queues
            lock (producer)
            {
                EventQueue temp = producer;
                producer = consumer;
                consumer = temp;
            }

            while (consumer.HasNext)
            {
                Event e = consumer.Dequeue();

                Dispatch(e);
            }
        }

        internal void Dispatch(Event e)
        {
            if (handlers.ContainsKey(e.Type))
            {
                foreach (EventHandlerBase handler in handlers[e.Type])
                {
                    handler.Invoke(e);
                }
            }
        }

        private abstract class EventHandlerBase
        {
            public abstract void Invoke(Event e);
        }

        private sealed class EventHandler<T> : EventHandlerBase where T : Event
        {
            private Action<T> handler;

            public EventHandler(Action<T> handler)
            {
                this.handler = handler;
            }

            public override void Invoke(Event e)
            {
                handler(e as T);
            }
        }
    }
}
