using System.Collections.Generic;
using TextWriter = System.IO.TextWriter;

namespace DarkTech.Engine
{
    public sealed class EngineConfiguration
    {
        public bool InitializeGraphicsSystem { get; set; }
        public bool InitializeSoundSystem { get; set; }
        public bool InitializeClient { get; set; }
        public bool InitializeServer { get; set; }

        public string WindowTitle { get; set; }
        public int WindowWidth { get; set; }
        public int WindowHeight { get; set; }
        public int WindowX { get; set; }
        public int WindowY { get; set; }

        public string RootDirectory { get; set; }
        public string ClientDLL { get; set; }
        public string ServerDLL { get; set; }

        public int UPS { get; set; }
        public List<TextWriter> PrintStreams { get; set; }

        public EngineConfiguration()
        {
            PrintStreams = new List<TextWriter>();
        }
    }
}
