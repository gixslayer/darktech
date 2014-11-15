namespace DarkTech.Engine
{
    public sealed class InitializeException : EngineException
    {
        public InitializeException(string message) : base(message) { }
        public InitializeException(string format, params object[] args) : base(string.Format(format, args)) { }
    }
}
