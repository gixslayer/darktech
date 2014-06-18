using System;
using System.Collections.Generic;

namespace DarkTech.Engine
{
    public abstract class ComponentEventHandler : Component
    {
        private readonly Dictionary<Type, List<EventHandlerBase>> handlers;
        private readonly Queue<Event> eventQueue;

        public ComponentEventHandler()
        {
            this.handlers = new Dictionary<Type, List<EventHandlerBase>>();
            this.eventQueue = new Queue<Event>();

            Engine.EventDispatcher.RegisterGlobalHandler(GlobalHandler);
        }

        protected void RegisterEventHandler<T>(Action<T> handler) where T : Event 
        {
            Type type = typeof(T);

            if (!handlers.ContainsKey(type))
            {
                handlers.Add(type, new List<EventHandlerBase>());
            }

            handlers[type].Add(new EventHandler<T>(handler));
        }

        private void GlobalHandler(Event e)
        {
            eventQueue.Enqueue(e);
        }

        public sealed override void Update(float dt)
        {
            while (eventQueue.Count != 0)
            {
                Event e = eventQueue.Dequeue();

                Type type = e.GetType();

                if (handlers.ContainsKey(type))
                {
                    foreach (EventHandlerBase handler in handlers[type])
                    {
                        handler.Invoke(e);
                    }
                }
            }
        }
    }
}
