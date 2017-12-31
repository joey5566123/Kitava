using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace Kitava.Library
{
    class Window
    {
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(String className, String windowTitle);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern Boolean ShowWindow(IntPtr handle, WindowEventFlags flag);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern Boolean GetWindowPlacement(IntPtr handle, ref WindowPlacement windowPlacement);
        [DllImport("user32.dll")]
        private static extern Boolean SetForegroundWindow(IntPtr handle);
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(String section, String key, String defaultString, StringBuilder returnedString, int size, String filePath);

        private enum WindowEventFlags : uint
        {
            Hide = 0,
            ShowNormal = 1,
            ShowMinimized = 2,
            ShowMaximized = 3,
            Maximize = 3,
            ShowNormalNoActivate = 4,
            Show = 5,
            Minimize = 6,
            ShowMinNoActivate = 7,
            ShowNoActivate = 8,
            Restore = 9,
            ShowDefault = 10,
            ForceMinimized = 11
        };

        private struct WindowPlacement
        {
            public int Length;
            public int Mode;
            public int Flag;
            private Point MinimizePoint;
            private Point MaximizePoint;
            public Rectangle Rectangle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Rectangle
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public static Rectangle ShowWindow()
        {
            var windowPlacement = new WindowPlacement();
            var handle = FindWindow(null, "Path of Exile");

            GetWindowPlacement(handle, ref windowPlacement);
            if (windowPlacement.Flag == (Int32)WindowEventFlags.ShowMinimized)
            {
                ShowWindow(handle, WindowEventFlags.Restore);
                return windowPlacement.Rectangle;
            }
            SetForegroundWindow(handle);
            return windowPlacement.Rectangle;
        }

        public static Boolean IsFullscreen()
        {
            var returnedString = new StringBuilder(255);

            GetPrivateProfileString("DISPLAY", "borderless_windowed_fullscreen", String.Empty, returnedString, 255, @"C:\Users\"+ Environment.UserName + @"\Documents\My Games\Path of Exile\garena_tw_production_Config.ini");
            if (returnedString.ToString() == Boolean.TrueString.ToLower())
            {
                return true;
            }
            GetPrivateProfileString("DISPLAY", "fullscreen", String.Empty, returnedString, 255, @"C:\Users\" + Environment.UserName + @"\Documents\My Games\Path of Exile\garena_tw_production_Config.ini");
            if (returnedString.ToString() == Boolean.TrueString.ToLower())
            {
                return true;
            }
            return false;
        }
    }
}