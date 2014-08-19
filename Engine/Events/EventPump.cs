using System;

using DarkTech.Common.Containers;

namespace DarkTech.Engine.Events
{
    public sealed class EventPump
    {
        private readonly object syncRoot;
        private readonly ArrayQueue<Event> frontBuffer;
        private readonly ArrayQueue<Event> backBuffer;
        private readonly ArrayList<EventDispatcher> eventDispatchers;
        private readonly EventMapping eventMapping;

        internal EventPump()
        {
            this.syncRoot = new object();
            this.frontBuffer = new ArrayQueue<Event>(64);
            this.backBuffer = new ArrayQueue<Event>(64);
            this.eventDispatchers = new ArrayList<EventDispatcher>(32);
            this.eventMapping = new EventMapping();
        }

        /// <summary>
        /// Enqueues a new event to the current event queue.
        /// </summary>
        /// <param name="e">The event to add to the queue.</param>
        public void Enqueue(Event e)
        {
            lock (syncRoot)
            {
                frontBuffer.Enqueue(e);
            }
        }

        public void RegisterEventHandler<T>(Action<T> callback) where T : Event
        {
            EventType eventType = eventMapping.GetEventType<T>();
            EventDispatcher eventDispatcher = GetDispatcherForType(eventType);
            EventHandler eventHandler = new EventHandler<T>(callback);

            eventDispatcher.RegisterHandler(eventHandler);
        }

        /// <summary>
        /// Pump all the queued events to the designated handlers. This method should only ever be called from the game thread.
        /// </summary>
        internal void PumpEvents()
        {
            // Copy the front buffer to the back buffer before processing.
            // It's important to minimize time spend within the lock to avoid stalling other threads trying to enqueue events.
            lock (syncRoot)
            {
                frontBuffer.CopyTo(backBuffer);
                frontBuffer.Clear();
            }

            // The enumerator will preserve the correct queue order.
            foreach (Event e in backBuffer)
            {
                bool processed = false;

                // Enumerate through all the registered event dispatchers.
                foreach (EventDispatcher dispatcher in eventDispatchers)
                {
                    // If the dispatcher returns true the event has been processed and send to all registered handlers.
                    if (dispatcher.ProcessEvent(e))
                    {
                        processed = true;

                        break;
                    }
                }

                // If no event dispatcher processed the event throw out a warning.
                if (!processed)
                {
                    Engine.Warningf("Event {0} was not processed", e.Type);
                }
            }

            // Clear the back buffer to prevent holding references to otherwise potentially dead instances.
            backBuffer.Clear();
        }

        /// <summary>
        /// Returns the registered event dispatcher for the designated event type. If no appropriate event dispatcher is found a new instance is registered.
        /// </summary>
        /// <param name="eventType">The event type to return a dispatcher instance for.</param>
        /// <returns></returns>
        private EventDispatcher GetDispatcherForType(EventType eventType)
        {
            // Enumerate through all existing event dispatchers to attempt to find an existing dispatcher for the given event type.
            foreach (EventDispatcher dispatcher in eventDispatchers)
            {
                if (dispatcher.TargetType == eventType)
                {
                    // An existing dispatcher has been found, return the reference and stop enumerating because only one dispatcher 
                    // should ever exist for a given event type.
                    return dispatcher;
                }
            }

            // If no existing dispatcher was found then create a new dispatcher and register it.
            // This is the only place a new event dispatcher should ever be registered to guarantee that there is only one dispatcher
            // for each event type.
            EventDispatcher newDispatcher = new EventDispatcher(eventType);

            eventDispatchers.Add(newDispatcher);

            // Return the reference to the newly created event dispatcher.
            return newDispatcher;
        }
    }
}
