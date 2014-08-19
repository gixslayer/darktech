using System;

namespace DarkTech.WindowLib
{
    public abstract class Window
    {
        public delegate void ResizedHandler(int width, int height);
        public delegate void MovedHandler(int x, int y);
        public delegate void WindowHandler();
        public delegate void KeyboardHandler(int keyCode);
        public delegate void MouseButtonHandler(int mouseButton);
        public delegate void MouseHandler(int x, int y);
        public delegate void MouseWheelHandler(int delta);

        public IntPtr Handle { get; protected set; }
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        public string Title { get; protected set; }
        public WindowMode Mode { get; protected set; }

        public event ResizedHandler Resized = delegate { };
        public event MovedHandler Moved = delegate { };
        public event WindowHandler Creating = delegate { };
        public event WindowHandler Created = delegate { };
        public event WindowHandler Destroying = delegate { };
        public event WindowHandler Destroyed = delegate { };
        public event KeyboardHandler KeyDown = delegate { };
        public event KeyboardHandler KeyUp = delegate { };
        public event KeyboardHandler KeyPressed = delegate { };
        public event MouseButtonHandler MouseDown = delegate { };
        public event MouseButtonHandler MouseUp = delegate { };
        public event MouseHandler MouseMoved = delegate { };
        public event MouseWheelHandler MouseWheelMoved = delegate { };

        public abstract void Create();
        public abstract void Destroy();
        public abstract void Show();
        public abstract void Hide();
        public abstract void SetTitle(string title);
        public abstract void AdjustWindow(int x, int y, int width, int height);
        public abstract void ProcessEvents();
        public abstract void RegisterInputDevice();

        protected void OnResized(int width, int height)
        {
            Resized(width, height);
        }

        protected void OnMoved(int x, int y)
        {
            Moved(x, y);
        }

        protected void OnCreating()
        {
            Creating();
        }

        protected void OnCreated()
        {
            Created();
        }

        protected void OnDestroying()
        {
            Destroying();
        }

        protected void OnDestroyed()
        {
            Destroyed();
        }

        protected void OnKeyDown(int keyCode)
        {
            KeyDown(keyCode);
        }

        protected void OnKeyUp(int keyCode)
        {
            KeyUp(keyCode);
        }

        protected void OnKeyPressed(int keyCode)
        {
            KeyPressed(keyCode);
        }

        protected void OnMouseDown(int mouseButton)
        {
            MouseDown(mouseButton);
        }

        protected void OnMouseUp(int mouseButton)
        {
            MouseUp(mouseButton);
        }

        protected void OnMouseMoved(int x, int y)
        {
            MouseMoved(x, y);
        }

        protected void OnMouseWheelMoved(int delta)
        {
            MouseWheelMoved(delta);
        }

        public static Window CreateWindow(IntPtr hInstance, WindowConfiguration configuration)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    return new WindowWin32(hInstance, configuration);

                default:
                    throw new PlatformNotSupportedException();
            }
            
        }
    }
}
