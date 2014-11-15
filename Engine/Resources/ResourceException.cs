namespace DarkTech.Engine.Resources
{
    public abstract class ResourceException : EngineException
    {
        public ResourceException(string message) : base(message) { }
        public ResourceException(string format, params object[] args) : base(format, args) { }
    }
}
