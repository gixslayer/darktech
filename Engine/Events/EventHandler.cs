using System;

namespace DarkTech.Engine.Events
{
    internal abstract class EventHandler
    {
        public abstract void Invoke(Event e);
    }

    internal sealed class EventHandler<T> : EventHandler where T : Event
    {
        private readonly Action<T> handler;

        public EventHandler(Action<T> handler)
        {
            this.handler = handler;
        }

        public override void Invoke(Event e)
        {
            handler((T)e);
        }
    }
}
