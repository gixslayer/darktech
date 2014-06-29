using System;

namespace DarkTech.Engine.Graphics.Windows
{
    internal class WindowWin : IWindow
    {
        private const string CLASS_NAME = "DarkTechEngine";

        private readonly IntPtr hInstance;

        public IntPtr Handle { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public string Title { get; private set; }

        internal WindowWin(IntPtr hInstance)
        {
            this.hInstance = hInstance;
        }

        private IntPtr MyWndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
        {
            switch ((WM)msg)
            {
                case WM.CLOSE:
                    Engine.RequestShutdown();
                    break;

                case WM.DESTROY:
                    //Win32.PostQuitMessage(0);
                    return IntPtr.Zero;

         /*       //case WM.MOVE: // Window position moved.
                case WM.SIZE: // Window resized
                    int i = lParam.ToInt32();

                    Console.WriteLine("RESIZED: {0} {1}", i >> 16, i & 0xffff);
                    break;

                case WM.MOUSEMOVE:
                    break;

                case WM.LBUTTONDOWN:
                case WM.LBUTTONUP:
                    break;

                case WM.KEYDOWN:
                case WM.KEYUP:
                case WM.CHAR:
                    break;*/
            }

            return Win32.DefWindowProc(hWnd, (WM)msg, wParam, lParam);
        }

        public bool CreateWindow()
        {
            int windowX = Engine.ScriptingInterface.GetCvarValue<int>("w_x");
            int windowY = Engine.ScriptingInterface.GetCvarValue<int>("w_y");
            int windowWidth = Engine.ScriptingInterface.GetCvarValue<int>("w_width");
            int windowHeight = Engine.ScriptingInterface.GetCvarValue<int>("w_height");
            string windowTitle = Engine.ScriptingInterface.GetCvarValue<string>("w_title");
            WNDCLASS wndclass = new WNDCLASS();

            wndclass.style = ClassStyles.HorizontalRedraw | ClassStyles.VerticalRedraw;
            wndclass.lpfnWndProc = new WndProc(MyWndProc);
            wndclass.cbClsExtra = 0;
            wndclass.cbWndExtra = 0;
            wndclass.hInstance = hInstance;
            wndclass.hIcon = Win32.LoadIcon(IntPtr.Zero, new IntPtr((int)SystemIcons.IDI_APPLICATION));
            wndclass.hCursor = Win32.LoadCursor(IntPtr.Zero, (int)IDC_STANDARD_CURSORS.IDC_ARROW);
            wndclass.hbrBackground = Win32.GetStockObject(StockObjects.BLACK_BRUSH);
            wndclass.lpszMenuName = null;
            wndclass.lpszClassName = CLASS_NAME;

            if (Win32.RegisterClass(ref wndclass) == 0)
            {
                Engine.Errorf("RegisterClass failed: {0} ({1})", Win32.LastErrorMessage(), Win32.LastError());

                return false;
            }

            WindowStyles dwStyle = WindowStyles.WS_POPUP | WindowStyles.WS_SYSMENU | WindowStyles.WS_CAPTION;// Disable WS_CAPTION for no border/frame.

            Handle = Win32.CreateWindowEx(WindowStylesEx.WS_EX_LEFT, CLASS_NAME, windowTitle, dwStyle, windowX, windowY, windowWidth, windowHeight, IntPtr.Zero, IntPtr.Zero, hInstance, IntPtr.Zero);

            if (Handle == IntPtr.Zero)
            {
                Engine.Errorf("CreateWindowEx failed: {0} ({1})", Win32.LastErrorMessage(), Win32.LastError());

                return false;
            }

            return true;
        }

        public bool ShowWindow()
        {
            Win32.ShowWindow(Handle, ShowWindowCommands.Normal);

            // FIXME: Is this even needed?
            if (!Win32.UpdateWindow(Handle))
            {
                Engine.Error("UpdateWindow failed");

                return false;
            }

            return true;
        }

        public void ProcessEvents()
        {
            MSG msg;

            while (Win32.PeekMessage(out msg, IntPtr.Zero, 0, 0, 1))
            {
                Win32.TranslateMessage(ref msg);
                Win32.DispatchMessage(ref msg);
            }
        }

        public void SetTitle(string title)
        {
            Title = title;

            if (!Win32.SetWindowText(Handle, title))
            {
                Engine.Errorf("SetWindowText failed: {0} ({1})", Win32.LastErrorMessage(), Win32.LastError());
            }
        }

        public void AdjustWindow(int x, int y, int width, int height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;

            RECT clientRect;
            RECT windowRect;

            Win32.GetClientRect(Handle, out clientRect);
            Win32.GetWindowRect(Handle, out windowRect);

            int wAdjustment = (windowRect.right - windowRect.left) - clientRect.right;
            int hAdjustment = (windowRect.bottom - windowRect.top) - clientRect.bottom;

            if (!Win32.MoveWindow(Handle, x, y, width + wAdjustment, height + hAdjustment, true))
            {
                Engine.Errorf("MoveWindow failed: {0} ({1})", Win32.LastErrorMessage(), Win32.LastError());
            }
        }

        public void Dispose()
        {
            if (!Win32.DestroyWindow(Handle))
            {
                Engine.Errorf("DestroyWindow failed: {0} ({1})", Win32.LastErrorMessage(), Win32.LastError());

                return;
            }

            Handle = IntPtr.Zero;

            if (!Win32.UnregisterClass(CLASS_NAME, hInstance))
            {
                Engine.Errorf("UnregisterClass failed: {0} ({1})", Win32.LastErrorMessage(), Win32.LastError());
            }
        }
    }
}
