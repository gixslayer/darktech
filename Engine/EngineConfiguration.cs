using System.Collections.Generic;
using TextWriter = System.IO.TextWriter;

namespace DarkTech.Engine
{
    public sealed class EngineConfiguration
    {
        public NetModel NetModel { get; set; }
        public string RootDirectory { get; set; }
        public string ClientDLL { get; set; }
        public string ServerDLL { get; set; }
    }
}
