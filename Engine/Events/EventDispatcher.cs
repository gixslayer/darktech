using DarkTech.Common.Containers;

namespace DarkTech.Engine.Events
{
    internal sealed class EventDispatcher
    {
        private readonly EventType targetType;
        private readonly LinkedList<EventHandler> handlers;

        public EventType TargetType
        {
            get { return targetType; }
        }

        public EventDispatcher(EventType targetType)
        {
            this.targetType = targetType;
            this.handlers = new LinkedList<EventHandler>();
        }

        public void RegisterHandler(EventHandler handler)
        {
            handlers.Add(handler);
        }

        public bool ProcessEvent(Event e)
        {
            if (e.Type == targetType)
            {
                foreach (EventHandler handler in handlers)
                {
                    handler.Invoke(e);
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
