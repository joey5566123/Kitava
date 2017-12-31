using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Kitava.Library
{
    class Hotkey
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr handle, int hashCode, int modifiers, int key);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr handle, int hashCode);

        public static int RegisterHotkey(IntPtr handle, int modifiers, Keys key)
        {
            var hashCode = modifiers ^ Convert.ToInt32(key) ^ handle.ToInt32();

            RegisterHotKey(handle, hashCode, modifiers, (Int32)key);
            return hashCode;
        }
    }
}