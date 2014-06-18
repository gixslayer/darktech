using System;

namespace DarkTech.Engine.Graphics
{
    public sealed class DummyWindow : IWindow
    {
        public IntPtr Handle { get { return IntPtr.Zero; } }
        public int Width { get { return 0; } }
        public int Height { get { return 0; } }
        public int X { get { return 0; } }
        public int Y { get { return 0; } }
        public string Title { get { return string.Empty; } }

        public bool CreateWindow() { return true; }
        public bool ShowWindow() { return true; }
        public void ProcessEvents() { }
        public void SetTitle(string title) { }
        public void AdjustWindow(int x, int y, int width, int height) { }
        public void Dispose() { }
    }
}
