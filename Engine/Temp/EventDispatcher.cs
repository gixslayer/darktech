using System;
using System.Collections.Generic;

namespace DarkTech.Engine
{
    public sealed class EventDispatcher
    {
        private Queue<Event> producer;
        private Queue<Event> consumer;
        private readonly Dictionary<EventType, List<EventHandlerBase>> handlers;
        private readonly List<Action<Event>> globalHandlers;

        public EventDispatcher()
        {
            this.producer = new Queue<Event>();
            this.consumer = new Queue<Event>();
            this.handlers = new Dictionary<EventType, List<EventHandlerBase>>();
            this.globalHandlers = new List<Action<Event>>();
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

        public void RegisterGlobalHandler(Action<Event> globalHandler)
        {
            globalHandlers.Add(globalHandler);
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
                Queue<Event> temp = producer;
                producer = consumer;
                consumer = temp;
            }

            while (consumer.Count != 0)
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

            foreach (Action<Event> globalHandler in globalHandlers)
            {
                globalHandler(e);
            }
        }
    }

    internal abstract class EventHandlerBase
    {
        public abstract void Invoke(Event e);
    }

    internal sealed class EventHandler<T> : EventHandlerBase where T : Event
    {
        private readonly Action<T> handler;

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
