using System;
using System.Runtime.InteropServices;

using DarkTech.NativeWin32;
using DarkTech.NativeWin32.Gdi32;
using DarkTech.NativeWin32.User32;

namespace DarkTech.WindowLib
{
    public sealed class WindowWin32 : Window
    {
        private static readonly IntPtr INTPTR_TRUE = new IntPtr(1);

        private readonly string className;
        private readonly IntPtr hInstance;
        private WndProc wndProc;

        internal WindowWin32(IntPtr hInstance, WindowConfiguration configuration)
        {
            this.className = configuration.ClassName;
            this.hInstance = hInstance;
            this.Mode = configuration.Mode;
            this.Title = configuration.Title;
            this.X = configuration.X;
            this.Y = configuration.Y;
            this.Width = configuration.Width;
            this.Height = configuration.Height;
        }

        public override void Create()
        {
            this.wndProc = new WndProc(WndProc);

            WndClass wndClass;

            wndClass.style = ClassStyles.HorizontalRedraw | ClassStyles.VerticalRedraw | ClassStyles.OwnDC;
            wndClass.lpfnWndProc = wndProc;
            wndClass.cbClsExtra = 0;
            wndClass.cbWndExtra = 0;
            wndClass.hInstance = hInstance;
            wndClass.hIcon = User32.LoadIcon(IntPtr.Zero, SystemIcons.Application);
            wndClass.hCursor = User32.LoadCursor(IntPtr.Zero, IdcStandardCursors.Arrow);
            wndClass.hbrBackground = Gdi32.GetStockObject(StockObjects.BlackBrush);
            wndClass.lpszMenuName = null;
            wndClass.lpszClassName = className;

            if (User32.RegisterClass(ref wndClass) == 0)
            {
                throw new WindowException("RegisterClass failed");
            }

            WindowStyles dwStyle = WindowStyles.Popup | WindowStyles.ClipChildren | WindowStyles.ClipSiblings;

            if (Mode == WindowMode.Windowed)
            {
                dwStyle |= WindowStyles.SysMenu | WindowStyles.Caption;
            }

            Handle = User32.CreateWindowEx(
                WindowStylesEx.Left,
                className,
                Title,
                dwStyle,
                X,
                Y,
                Width,
                Height,
                IntPtr.Zero, // hWndParent
                IntPtr.Zero, // hMenu
                hInstance,
                IntPtr.Zero); // lpParam

            if (Handle == IntPtr.Zero)
            {
                throw new WindowException("CreateWindowEx failed");
            }

            OnCreated();

            AdjustWindow(X, Y, Width, Height);
        }
        
        public override void Destroy()
        {
            if (Handle != IntPtr.Zero)
            {
                if (!User32.DestroyWindow(Handle))
                {
                    throw new WindowException("DestroyWindow failed");
                }

                Handle = IntPtr.Zero;
            }
        }
      
        public override void Show()
        {
            User32.ShowWindow(Handle, ShowWindowCommands.Normal);

            // Required to prevent the taskbar from showing in windowed fullscreen until the window gains focus.
            // TODO: Move this to another place?
            User32.SetForegroundWindow(Handle);
            User32.SetFocus(Handle);
        }

        public override void Hide()
        {
            User32.ShowWindow(Handle, ShowWindowCommands.Hide);
        }

        public override void SetTitle(string title)
        {
            if (!User32.SetWindowText(Handle, title))
            {
                throw new WindowException("SetWindowText failed");
            }

            this.Title = title;
        }

        public override void AdjustWindow(int x, int y, int width, int height)
        {
            Rect clientRect;
            Rect windowRect;

            User32.GetClientRect(Handle, out clientRect);
            User32.GetWindowRect(Handle, out windowRect);

            int wAdjustment = (windowRect.right - windowRect.left) - clientRect.right;
            int hAdjustment = (windowRect.bottom - windowRect.top) - clientRect.bottom;

            if (!User32.MoveWindow(Handle, x, y, width + wAdjustment, height + hAdjustment, true))
            {
                throw new WindowException("MoveWindow failed");
            }

            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        public override void ProcessEvents()
        {
            Msg msg;
            int ret;

            while (User32.PeekMessage(out msg, Handle, 0, 0, PeekMessageMode.NoRemove))
            {
                // Taken from MSDN (http://msdn.microsoft.com/en-us/library/ms644936.aspx)
                // If the function retrieves a message other than WM_QUIT, the return value is nonzero.
                // If the function retrieves the WM_QUIT message, the return value is zero. 
                // If there is an error, the return value is -1. 
                // For example, the function fails if hWnd is an invalid window handle or lpMsg is an invalid pointer. 
                // To get extended error information, call GetLastError.
                ret = User32.GetMessage(out msg, Handle, 0, 0);

                if (ret == -1) // Failed to get message.
                {
                    throw new WindowException("GetMessage failed");
                }
                else if (ret == 0) // WM_QUIT message.
                {
                    OnDestroyed();
                }
                else // Other messages.
                {
                    User32.TranslateMessage(ref msg);
                    User32.DispatchMessage(ref msg);
                }
            }
        }

        public override void RegisterInputDevice()
        {
            RawInputDevice[] devices = new RawInputDevice[1];

            devices[0] = new RawInputDevice();
            devices[0].Flags = RawInputDeviceFlags.InputSink;
            devices[0].Usage = HIDUsage.Mouse;
            devices[0].UsagePage = HIDUsagePage.Generic;
            devices[0].WindowHandle = Handle;

            if (!User32.RegisterRawInputDevices(devices, 1, (uint)Marshal.SizeOf(devices[0])))
            {
                Console.WriteLine("FAILED TO REGISTER");
            }
        }

        private IntPtr WndProc(IntPtr hWnd, WindowMessage msg, IntPtr wParam, IntPtr lParam)
        {
            switch (msg)
            {
                case WindowMessage.Move:
                    OnMoved(GetLowWord(lParam), GetHighWord(lParam));
                    return IntPtr.Zero;

                case WindowMessage.Size:
                    OnResized(GetLowWord(lParam), GetHighWord(lParam));
                    return IntPtr.Zero;

                case WindowMessage.Destroy:
                    Handle = IntPtr.Zero;
                    OnDestroying();
                    User32.PostQuitMessage(0);
                    return IntPtr.Zero;

                case WindowMessage.Create:
                    OnCreating();
                    return IntPtr.Zero;

                case WindowMessage.SysKeyDown:
                case WindowMessage.KeyDown:
                    OnKeyDown(wParam.ToInt32()); // VKEY
                    return IntPtr.Zero;

                case WindowMessage.SysKeyUp:
                case WindowMessage.KeyUp:
                    OnKeyUp(wParam.ToInt32()); // VKEY
                    return IntPtr.Zero;

                case WindowMessage.Char:
                    OnKeyPressed(wParam.ToInt32()); // CHARCODE
                    return IntPtr.Zero;

                case WindowMessage.MouseMove:
                    OnMouseMoved(GetLowWord(lParam), GetHighWord(lParam));
                    return IntPtr.Zero;

                case WindowMessage.MouseWheel:
                    OnMouseWheelMoved(GetHighWord(wParam));
                    return IntPtr.Zero;

                case WindowMessage.LButtonDown:
                    OnMouseDown(0);
                    return IntPtr.Zero;

                case WindowMessage.LButtonUp:
                    OnMouseUp(0);
                    return IntPtr.Zero;

                case WindowMessage.MButtonDown:
                    OnMouseDown(1);
                    return IntPtr.Zero;

                case WindowMessage.MButtonUp:
                    OnMouseUp(1);
                    return IntPtr.Zero;

                case WindowMessage.RButtonDown:
                    OnMouseDown(2);
                    return IntPtr.Zero;

                case WindowMessage.RButtonUp:
                    OnMouseUp(2);
                    return IntPtr.Zero;

                case WindowMessage.XButtonDown:
                    OnMouseDown(GetHighWord(wParam) + 2);
                    return INTPTR_TRUE;

                case WindowMessage.XButtonUp:
                    OnMouseUp(GetHighWord(wParam) + 2);
                    return INTPTR_TRUE;

                case WindowMessage.Input:
                    RawInput input = new RawInput();
                    uint size = (uint)Marshal.SizeOf(input);
                    uint headerSize = (uint)Marshal.SizeOf(input.header);
                    uint outSize = User32.GetRawInputData(lParam, RawInputCommand.Input, out input, ref size, headerSize);

                    if (outSize != uint.MaxValue - 1)
                    {
                        HandleRawInput(input);
                    }

                    return IntPtr.Zero;
            }

            return User32.DefWindowProc(hWnd, msg, wParam, lParam);
        }

        private void HandleRawInput(RawInput input)
        {
            if (input.header.dwType != RawInputType.Mouse)
            {
                Console.WriteLine("Other input type");
                return;
            }

            RawMouse mouse = input.data.mouse;

            Console.WriteLine("Raw mouse: {0},{1} -> {2}", mouse.lLastX, mouse.lLastY, mouse.usFlags.ToString());
            Console.WriteLine("button flags: {0}", mouse.usButtonFlags);
            Console.WriteLine("button data: {0}", (short)mouse.usButtonData);
        }

        private static int GetLowWord(IntPtr intPtr)
        {
            return intPtr.ToInt32() & 0xffff;
        }

        private static int GetHighWord(IntPtr intPtr)
        {
            return intPtr.ToInt32() >> 16;
        }
    }
}
