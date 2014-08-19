namespace DarkTech.Engine.Events
{
    internal sealed class EventMapping
    {
        public EventType GetEventType<T>() where T : Event
        {
            throw new System.NotImplementedException();
        }
    }
}
