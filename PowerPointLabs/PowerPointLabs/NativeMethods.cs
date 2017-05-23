﻿// <auto-generated/>
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace PPExtraEventHelper
{
    internal class Native
    {
        [DllImport("user32.dll", EntryPoint = "SetWindowsHookEx", SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        public static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(int xPoint, int yPoint);

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(Native.POINT point);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 msg, IntPtr wParam, [Out] StringBuilder lParam);

        [DllImport("user32")]
        public static extern bool HideCaret(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetFocus();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetFocus(IntPtr hWnd);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPixel(
            System.IntPtr hdc,    // handle to DC
            int nXPos,  // x-coordinate of pixel
            int nYPos   // y-coordinate of pixel
        );

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetDC(IntPtr wnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ReleaseDC(IntPtr dc);

        //Minimum supported client: Vista
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool AddClipboardFormatListener(IntPtr hwnd);

        //Minimum supported client: Vista
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

        //Minimum supported client: Windows 2000
        [DllImport("user32.dll")]
        internal static extern IntPtr SetClipboardViewer(IntPtr hwnd);

        //Minimum supported client: Windows 2000
        [DllImport("user32.dll")]
        internal static extern IntPtr ChangeClipboardChain(IntPtr hwnd, IntPtr hWndNext);

        [DllImport("user32.DLL")]
        internal static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        internal static extern int GetWindowThreadProcessId(IntPtr hwnd, int id);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        
        [DllImport("user32.dll", EntryPoint = "CreateWindowEx", CharSet = CharSet.Unicode)]
        internal static extern IntPtr CreateWindowEx(int dwExStyle,
                                                      string lpszClassName,
                                                      string lpszWindowName,
                                                      int style,
                                                      int x, int y,
                                                      int width, int height,
                                                      IntPtr hwndParent,
                                                      IntPtr hMenu,
                                                      IntPtr hInst,
                                                      [MarshalAs(UnmanagedType.AsAny)] object pvParam);

        [DllImport("user32.dll", EntryPoint = "DestroyWindow", CharSet = CharSet.Unicode)]
        internal static extern bool DestroyWindow(IntPtr hwnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetLayeredWindowAttributes(IntPtr hwnd, int crKey, byte bAlpha, LayeredWindowAttributeFlags dwFlags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "PostMessageA")]
        internal static extern bool PostMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        internal static extern int SetWindowsHookEx(int idHook, HookProc lpfn, int hInstance, int threadId);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        internal static extern bool UnhookWindowsHookEx(int idHook);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        internal static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        internal static extern byte VkKeyScan(char key);

        [DllImport("user32.dll")]
        internal static extern short GetKeyState(VirtualKey nVirtKey);

        [DllImport("user32.dll")]
        internal static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr
           hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess,
           uint idThread, uint dwFlags);

        [DllImport("user32.dll")]
        internal static extern bool UnhookWinEvent(IntPtr hWinEventHook);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool InvalidateRect(IntPtr hWnd, IntPtr rect, [MarshalAs(UnmanagedType.Bool)] bool erase);

        [DllImport("user32.dll")]
        internal static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        [DllImport("gdi32.dll")]
        internal static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("user32.dll")]
        internal static extern int GetWindowLong(IntPtr hwnd, int index);

        [DllImport("user32.dll")]
        internal static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

        // Minimum supported client: Vista
        [DllImport("Magnification.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool MagInitialize();

        // Minimum supported client: Vista
        [DllImport("Magnification.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool MagUninitialize();

        // Minimum supported client: Vista
        [DllImport("Magnification.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool MagSetWindowTransform(IntPtr hwnd, ref MAGTRANSFORM pTransform);

        // Minimum supported client: Vista
        [DllImport("Magnification.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool MagSetWindowSource(IntPtr hwnd, RECT rect);

        // Minimum supported client: Vista 
        [DllImport("Magnification.dll", CallingConvention = CallingConvention.StdCall)] 
        [return: MarshalAs(UnmanagedType.Bool)] 
        internal static extern bool MagSetWindowFilterList(IntPtr hwnd, int dwFilterMode, int count, IntPtr[] pHWND);

        [DllImport("winmm.dll")]
        internal static extern int mciSendString(string mciCommand,
                                                 StringBuilder mciRetInfo,
                                                 int infoLen,
                                                 IntPtr callBack);

        internal delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType,
        IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

        internal delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        internal delegate int RegionHookProc(Rectangle region, int nCode, IntPtr wParam, IntPtr lParam);

        internal static Point GetPoint(IntPtr lParam)
        {
            var uLParam = GetUncheckedInt(lParam);
            
            // cast to long first so that it's 64-bit compatible
            var x = unchecked((short)(long)uLParam);
            var y = unchecked((short)((long)uLParam >> 16));

            return new Point(x, y);
        }

        private static uint GetUncheckedInt(IntPtr ptr)
        {
            return unchecked(IntPtr.Size == 8 ? (uint)ptr.ToInt64() : (uint)ptr.ToInt32());
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct RECT
        {
            internal int Left;        // x position of upper-left corner
            internal int Top;         // y position of upper-left corner
            internal int Right;       // x position of lower-right corner
            internal int Bottom;      // y position of lower-right corner
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct MAGTRANSFORM
        {
            internal float m00;
            internal float m10;
            internal float m20;
            internal float m01;
            internal float m11;
            internal float m21;
            internal float m02;
            internal float m12;
            internal float m22;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal class MouseHookStruct
        {
            internal Point pt;
            internal int hwnd;
            internal int wHitTestCode;
            internal int dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal class Point
        {
            internal int x;
            internal int y;

            internal Point() {}
            internal Point(int _x, int _y)
            {
                x = _x;
                y = _y;
            }
        }

        internal enum HookType
        {
            WH_MOUSE = 0x7,
            WH_MOUSE_LL = 0xE,
            WH_KEYBOARD = 0x2,
            WH_KEYBOARD_LL = 0xD
        }

        internal enum Message
        {
            WM_SETREDRAW = 0XB,
            WM_PAINT = 0xf,
            WM_KEYDOWN = 0x100,
            WM_COMMAND = 0x111,
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_LBUTTONDBLCLK = 0x0203,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205,
            WM_PARENTNOTIFY = 0x0210,
            WM_DRAWCLIPBOARD = 0x308,
            WM_CHANGECBCHAIN = 0x30D,
            WM_CLIPBOARDUPDATE = 0x031D,
            WM_GETTEXT = 0x000D,
            WM_GETTEXTLENGTH = 0x000E,

            TVGN_CARET = 0x9,
            TV_FIRST = 0x1100,
            TVM_SELECTITEM = (TV_FIRST + 11),
            TVM_GETNEXTITEM = (TV_FIRST + 10),
            TVM_GETITEM = (TV_FIRST + 12),
            TVM_ENSUREVISIBLE = (TV_FIRST + 20),

            WS_EX_COMPOSITED = 0x02000000
        }

        internal enum VirtualKey
        {
            VK_LSHIFT = 0xA0,
            VK_RSHIFT = 0xA1,
            VK_LCONTROL = 0xA2,
            VK_RCONTROL = 0xA3,
            VK_LMENU = 0xA4,
            VK_RMENU = 0xA5,
            VK_RETURN = 0x0D,
          	VK_ESCAPE =	0x1B,
            VK_LEFT = 0x25,
            VK_UP = 0x26,
            VK_RIGHT = 0x27,
            VK_DOWN = 0x28,
            VK_OEM_COMMA = 0xBC,
            VK_OEM_PERIOD = 0xBE,
            VK_A = 0x41,
            VK_B = 0x42,
            VK_C = 0x43,
            VK_D = 0x44,
            VK_E = 0x45,
            VK_F = 0x46,
            VK_G = 0x47,
            VK_H = 0x48,
            VK_I = 0x49,
            VK_J = 0x4a,
            VK_K = 0x4b,
            VK_L = 0x4c,
            VK_M = 0x4d,
            VK_N = 0x4e,
            VK_O = 0x4f,
            VK_P = 0x50,
            VK_Q = 0x51,
            VK_R = 0x52,
            VK_S = 0x53,
            VK_T = 0x54,
            VK_U = 0x55,
            VK_V = 0x56,
            VK_W = 0x57,
            VK_X = 0x58,
            VK_Y = 0x59,
            VK_Z = 0x5a,
            VK_0 = 0x30,
            VK_1 = 0x31,
            VK_2 = 0x32,
            VK_3 = 0x33,
            VK_4 = 0x34,
            VK_5 = 0x35,
            VK_6 = 0x36,
            VK_7 = 0x37,
            VK_8 = 0x38,
            VK_9 = 0x39,
        }

        internal static bool IsAlphanumericKey(VirtualKey key)
        {
            return (VirtualKey.VK_0 <= key && key <= VirtualKey.VK_9) ||
                   (VirtualKey.VK_A <= key && key <= VirtualKey.VK_Z);
        }

        internal static bool IsNumberKey(VirtualKey key)
        {
            return (VirtualKey.VK_0 <= key && key <= VirtualKey.VK_9);
        }

        internal enum Event
        {
            EVENT_SYSTEM_MENUEND = 0x5,
            EVENT_OBJECT_CREATE = 0x8000,
        }
        
        internal enum MagnifierStyle : int
        {
            MS_SHOWMAGNIFIEDCURSOR = 0x0001,
            MS_CLIPAROUNDCURSOR = 0x0002,
            MS_INVERTCOLORS = 0x0004
        }

        internal enum MagnifierFilterMode : int
        {
            MW_FILTERMODE_EXCLUDE = 0,
            MW_FILTERMODE_INCLUDE = 1
        }

        internal enum WindowLong : int
        {
            GWL_WNDPROC = -4,
            GWL_HINSTANCE = -6,
            GWL_HWNDPARENT = -8,
            GWL_ID = -12,
            GWL_STYLE = -16,
            GWL_EXSTYLE = -20,
            GWL_USERDATA = -21
        }

        internal enum WindowStyles : int
        {
            WS_OVERLAPPED = 0x00000000,
            WS_POPUP = -2147483648,
            WS_CHILD = 0x40000000,
            WS_MINIMIZE = 0x20000000,
            WS_VISIBLE = 0x10000000,
            WS_DISABLED = 0x08000000,
            WS_CLIPSIBLINGS = 0x04000000,
            WS_CLIPCHILDREN = 0x02000000,
            WS_MAXIMIZE = 0x01000000,
            WS_CAPTION = 0x00C00000,
            WS_BORDER = 0x00800000,
            WS_DLGFRAME = 0x00400000,
            WS_VSCROLL = 0x00200000,
            WS_HSCROLL = 0x00100000,
            WS_SYSMENU = 0x00080000,
            WS_THICKFRAME = 0x00040000,
            WS_GROUP = 0x00020000,
            WS_TABSTOP = 0x00010000,
            WS_MINIMIZEBOX = 0x00020000,
            WS_MAXIMIZEBOX = 0x00010000
        }

        internal enum ExtendedWindowStyles : int
        {
            WS_EX_DLGMODALFRAME = 0x00000001,
            WS_EX_NOPARENTNOTIFY = 0x00000004,
            WS_EX_TOPMOST = 0x00000008,
            WS_EX_ACCEPTFILES = 0x00000010,
            WS_EX_TRANSPARENT = 0x00000020,
            WS_EX_MDICHILD = 0x00000040,
            WS_EX_TOOLWINDOW = 0x00000080,
            WS_EX_WINDOWEDGE = 0x00000100,
            WS_EX_CLIENTEDGE = 0x00000200,
            WS_EX_CONTEXTHELP = 0x00000400,
            WS_EX_RIGHT = 0x00001000,
            WS_EX_LEFT = 0x00000000,
            WS_EX_RTLREADING = 0x00002000,
            WS_EX_LTRREADING = 0x00000000,
            WS_EX_LEFTSCROLLBAR = 0x00004000,
            WS_EX_RIGHTSCROLLBAR = 0x00000000,
            WS_EX_CONTROLPARENT = 0x00010000,
            WS_EX_STATICEDGE = 0x00020000,
            WS_EX_APPWINDOW = 0x00040000,
            WS_EX_LAYERED = 0x00080000,
            WS_EX_NOINHERITLAYOUT = 0x00100000,
            WS_EX_LAYOUTRTL = 0x00400000,
            WS_EX_COMPOSITED = 0x02000000,
            WS_EX_NOACTIVATE = 0x08000000
        }
        
        internal enum LayeredWindowAttributeFlags : int
        {
            LWA_COLORKEY = 0x00000001,
            LWA_ALPHA = 0x00000002
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public int mouseData;
            public int flags;
            public int time;
            public UIntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }
    }
}
