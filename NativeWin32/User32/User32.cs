using System;
using System.Runtime.InteropServices;

namespace DarkTech.NativeWin32.User32
{
    public static class User32
    {
        public const string USER32DLL = "user32.dll";

        public const int ENUM_CURRENT_SETTINGS = -1;
        public const int ENUM_REGISTRY_SETTINGS = -2;

        [DllImport(USER32DLL, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustWindowRectEx(ref Rect lpRect, [In] WindowStyles dwStyle, [In] bool bMenu, [In] WindowStylesEx dwExStyle);

        [DllImport(USER32DLL)]
        public static extern DisplayChange ChangeDisplaySettings([In] ref DevMode devMode, [In] ChangeDisplaySettingsFlags flags);

        [DllImport(USER32DLL)]
        public static extern DisplayChange ChangeDisplaySettings([In] IntPtr devMode, [In] ChangeDisplaySettingsFlags flags);

        [DllImport(USER32DLL)]
        public static extern DisplayChange ChangeDisplaySettingsEx([In, MarshalAs(UnmanagedType.LPTStr)] string lpszDeviceName, [In] ref DevMode lpDevMode, IntPtr hWnd, 
            [In] ChangeDisplaySettingsFlags dwflags, [In] IntPtr lParam);

        [DllImport(USER32DLL)]
        public static extern DisplayChange ChangeDisplaySettingsEx([In, MarshalAs(UnmanagedType.LPTStr)] string lpszDeviceName, [In] IntPtr lpDevMode, IntPtr hWnd,
            [In] ChangeDisplaySettingsFlags dwflags, [In] IntPtr lParam);

        [DllImport(USER32DLL, SetLastError = true)]
        public static extern IntPtr CreateWindowEx([In] WindowStylesEx dwExStyle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpClassName, 
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, [In] WindowStyles dwStyle, [In] int x, [In] int y, [In] int nWidth, [In] int nHeight, 
            [In] IntPtr hWndParent, [In] IntPtr hMenu, [In] IntPtr hInstance, [In] IntPtr lpParam);

        [DllImport(USER32DLL)]
        public static extern IntPtr DefWindowProc([In] IntPtr hWnd, [In] WindowMessage uMsg, [In] IntPtr wParam, [In] IntPtr lParam);

        [DllImport(USER32DLL, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyWindow([In] IntPtr hWnd);

        [DllImport(USER32DLL)]
        public static extern IntPtr DispatchMessage([In] ref Msg lpmsg);

        [DllImport(USER32DLL)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayDevices([In, MarshalAs(UnmanagedType.LPTStr)] string lpszDeviceName, [In] uint iDevNum, ref DisplayDevice lpDisplayDevice, [In] uint dwFlags);

        [DllImport(USER32DLL)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettings([In, MarshalAs(UnmanagedType.LPTStr)] string lpszDeviceName, [In] int iModeNum, ref DevMode lpDevMode);

        [DllImport(USER32DLL, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClientRect([In] IntPtr hWnd, out Rect lpRect);

        [DllImport(USER32DLL)]
        public static extern IntPtr GetDC([In] IntPtr hWnd);

        [DllImport(USER32DLL, SetLastError = true)]
        public static extern sbyte GetMessage(out Msg lpMsg, [In] IntPtr hWnd, [In] uint wMsgFilterMin, [In] uint wMsgFilterMax);
        // GetMessage return values:
        // 0 = WM_QUIT
        // nonzero = message other than WM_QUIT
        // -1 = error

        [DllImport(USER32DLL)]
        public static extern uint GetRawInputData([In] IntPtr hRawInput, [In] RawInputCommand uiCommand, out RawInput pData, ref uint pcbSize, [In] uint cbSizeHeader);

        [DllImport(USER32DLL)]
        public static extern int GetSystemMetrics([In] SystemMetric nIndex);

        [DllImport(USER32DLL, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect([In] IntPtr hWnd, out Rect lpRect);

        [DllImport(USER32DLL, SetLastError = true)]
        public static extern IntPtr LoadCursor([In] IntPtr hInstance, [In] IdcStandardCursors lpCursorName);

        [DllImport(USER32DLL, SetLastError = true)]
        public static extern IntPtr LoadIcon([In] IntPtr hInstance, [In] SystemIcons lpIconName);

        [DllImport(USER32DLL, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveWindow([In] IntPtr hWnd, [In] int X, [In] int Y, [In] int nWidth, [In] int nHeight, [In] bool bRepaint);

        [DllImport(USER32DLL)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessage(out Msg lpMsg, [In] IntPtr hWnd, [In] uint wMsgFilterMin, [In] uint wMsgFilterMax, [In] PeekMessageMode wRemoveMsg);

        [DllImport(USER32DLL)]
        public static extern void PostQuitMessage([In] int nExitCode);

        [DllImport(USER32DLL, SetLastError = true)]
        public static extern ushort RegisterClass([In] ref WndClass lpWndClass);

        [DllImport(USER32DLL, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterRawInputDevices([In, MarshalAs(UnmanagedType.LPArray)] RawInputDevice[] pRawInputDevices, [In] uint uiNumDevices, [In] uint cbSize);

        [DllImport(USER32DLL)]
        public static extern int ReleaseDC([In] IntPtr hWnd, [In] IntPtr hDC);

        [DllImport(USER32DLL, SetLastError = true)]
        public static extern IntPtr SetFocus([In] IntPtr hWnd);

        [DllImport(USER32DLL)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow([In] IntPtr hWnd);

        [DllImport(USER32DLL, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowText([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpString);

        [DllImport(USER32DLL)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow([In] IntPtr hWnd, [In] ShowWindowCommands nCmdShow);

        [DllImport(USER32DLL)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMessage([In] ref Msg lpMsg);

        [DllImport(USER32DLL, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterClass([In] [MarshalAs(UnmanagedType.LPStr)] string lpClassName, [In] IntPtr hInstance);

        [DllImport(USER32DLL)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateWindow([In] IntPtr hWnd);
    }
}
