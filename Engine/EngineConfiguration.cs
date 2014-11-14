using System.Collections.Generic;
using TextWriter = System.IO.TextWriter;

namespace DarkTech.Engine
{
    public sealed class EngineConfiguration
    {
        public EngineModel Model { get; set; }
        public string RootDirectory { get; set; }
        public string ClientDLL { get; set; }
        public string ServerDLL { get; set; }
    }
}
