using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Kitava.Library
{
    class InputSimulator
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint SendInput(uint nInputs, ref Input pInputs, int size);
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int coordinateX, int coordinateY);

        public enum MouseEventFlags : uint
        {
            MOUSEEVENTF_MOVE = 0x0001,
            MOUSEEVENTF_LEFTDOWN = 0x0002,
            MOUSEEVENTF_LEFTUP = 0x0004,
            MOUSEEVENTF_RIGHTDOWN = 0x0008,
            MOUSEEVENTF_RIGHTUP = 0x0010,
            MOUSEEVENTF_MIDDLEDOWN = 0x0020,
            MOUSEEVENTF_MIDDLEUP = 0x0040,
            MOUSEEVENTF_XDOWN = 0x0080,
            MOUSEEVENTF_XUP = 0x0100,
            MOUSEEVENTF_WHEEL = 0x0800,
            MOUSEEVENTF_VIRTUALDESK = 0x4000,
            MOUSEEVENTF_ABSOLUTE = 0x8000
        }

        public enum KeyboardEventFlags : uint
        {
            KEYBDEVENTF_EXTENDEDKEY = 0x0001,
            KEYBDEVENTF_KEYUP = 0x0002,
            KEYBDEVENTF_UNICODE = 0x0004,
            KEYBDEVENTF_SCANCODE = 0x0008
        }

        public enum SendInputEventType : int
        {
            InputMouse,
            InputKeyboard
        }

        public struct MouseInputData
        {
            public int CoordinateX;
            public int CoordinateY;
            public uint MouseData;
            public MouseEventFlags Flag;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        public struct KeyboardInputData
        {
            public ushort VirtualKey;
            public ushort ScanKey;
            public KeyboardEventFlags Flag;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct InputUnion
        {
            [FieldOffset(0)]
            public MouseInputData MouseInputData;
            [FieldOffset(0)]
            public KeyboardInputData KeyboardInputData;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Input
        {
            public SendInputEventType Type;
            public InputUnion Union;
        }

        public static ushort SwitchKey(Keys key)
        {
            switch (key)
            {
                case Keys.Shift:
                    return 0x10;
                case Keys.Control:
                    return 0x11;
                case Keys.Alt:
                    return 0x12;
                case Keys.A:
                    return 0x41;
                case Keys.B:
                    return 0x42;
                case Keys.C:
                    return 0x43;
                case Keys.D:
                    return 0x44;
                case Keys.E:
                    return 0x45;
                case Keys.F:
                    return 0x46;
                case Keys.G:
                    return 0x47;
                case Keys.H:
                    return 0x48;
                case Keys.I:
                    return 0x49;
                case Keys.J:
                    return 0x4A;
                case Keys.K:
                    return 0x4B;
                case Keys.L:
                    return 0x4C;
                case Keys.M:
                    return 0x4D;
                case Keys.N:
                    return 0x4E;
                case Keys.O:
                    return 0x4F;
                case Keys.P:
                    return 0x50;
                case Keys.Q:
                    return 0x51;
                case Keys.R:
                    return 0x52;
                case Keys.S:
                    return 0x53;
                case Keys.T:
                    return 0x54;
                case Keys.U:
                    return 0x55;
                case Keys.V:
                    return 0x56;
                case Keys.W:
                    return 0x57;
                case Keys.X:
                    return 0x58;
                case Keys.Y:
                    return 0x59;
                case Keys.Z:
                    return 0x5A;
                default:
                    return 0x00;
            }
        }
    }
}