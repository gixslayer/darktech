using System;

namespace DarkTech.Engine.Graphics
{
    public interface IWindow : IDisposable
    {
        IntPtr Handle { get; }
        int Width { get; }
        int Height { get; }
        int X { get; }
        int Y { get; }
        string Title { get; }

        bool CreateWindow();
        bool ShowWindow();
        void ProcessEvents();
        void SetTitle(string title);
        void AdjustWindow(int x, int y, int width, int height);
    }
}
