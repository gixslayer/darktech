using System;

namespace DarkTech.Engine
{
    public class EngineException : Exception
    {
        public EngineException(string message) : base(message) { }
        public EngineException(string format, params object[] args) : base(string.Format(format, args)) { }
    }
}
