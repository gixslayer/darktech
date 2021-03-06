﻿using System;
using System.Runtime.InteropServices;

namespace DarkTech.NativeWin32.User32
{
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
    public struct DevMode
    {
        public const int CCHDEVICENAME = 32;
        public const int CCHFORMNAME = 32;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
        [FieldOffset(0)]
        public string dmDeviceName;
        [FieldOffset(32)]
        public short dmSpecVersion;
        [FieldOffset(34)]
        public short dmDriverVersion;
        [FieldOffset(36)]
        public short dmSize;
        [FieldOffset(38)]
        public short dmDriverExtra;
        [FieldOffset(40)]
        public DM dmFields;

        [FieldOffset(44)]
        short dmOrientation;
        [FieldOffset(46)]
        short dmPaperSize;
        [FieldOffset(48)]
        short dmPaperLength;
        [FieldOffset(50)]
        short dmPaperWidth;
        [FieldOffset(52)]
        short dmScale;
        [FieldOffset(54)]
        short dmCopies;
        [FieldOffset(56)]
        short dmDefaultSource;
        [FieldOffset(58)]
        short dmPrintQuality;

        [FieldOffset(44)]
        public Point dmPosition;
        [FieldOffset(52)]
        public int dmDisplayOrientation;
        [FieldOffset(56)]
        public int dmDisplayFixedOutput;

        [FieldOffset(60)]
        public short dmColor; // See note below!
        [FieldOffset(62)]
        public short dmDuplex; // See note below!
        [FieldOffset(64)]
        public short dmYResolution;
        [FieldOffset(66)]
        public short dmTTOption;
        [FieldOffset(68)]
        public short dmCollate; // See note below!
        [FieldOffset(72)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)]
        public string dmFormName;
        [FieldOffset(102)]
        public short dmLogPixels;
        [FieldOffset(104)]
        public int dmBitsPerPel;
        [FieldOffset(108)]
        public int dmPelsWidth;
        [FieldOffset(112)]
        public int dmPelsHeight;
        [FieldOffset(116)]
        public int dmDisplayFlags;
        [FieldOffset(116)]
        public int dmNup;
        [FieldOffset(120)]
        public int dmDisplayFrequency;
    }
}
