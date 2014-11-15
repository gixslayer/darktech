namespace DarkTech.Engine.Resources
{
    public sealed class LoadResourceException : ResourceException
    {
        public LoadResourceException(string message) : base(message) { }
        public LoadResourceException(string format, params object[] args) : base(format, args) { }
    }
}
