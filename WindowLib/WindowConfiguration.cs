using System;

namespace DarkTech.WindowLib
{
    public sealed class WindowConfiguration
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string ClassName { get; set; }
        public string Title { get; set; }
        public WindowMode Mode { get; set; }
    }
}
