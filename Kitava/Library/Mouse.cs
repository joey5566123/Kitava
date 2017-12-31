using System;
using System.Drawing;
using System.Runtime.InteropServices;
using static Kitava.Library.InputSimulator;

namespace Kitava.Library
{
    class Mouse
    {
        public static void Move(int coordinateX, int coordinateY)
        {
            SetCursorPos(coordinateX, coordinateY);
        }

        public static void Move(double coordinateX, double coordinateY)
        {
            SetCursorPos(Convert.ToInt32(coordinateX), Convert.ToInt32(coordinateY));
        }

        public static void Move(float coordinateX, float coordinateY)
        {
            SetCursorPos(Convert.ToInt32(coordinateX), Convert.ToInt32(coordinateY));
        }

        public static void Move(Point point)
        {
            SetCursorPos(point.X, point.Y);
        }

        public static void LeftDown()
        {
            var input = new Input
            {
                Type = SendInputEventType.InputMouse
            };

            input.Union.MouseInputData.Flag = MouseEventFlags.MOUSEEVENTF_LEFTDOWN;
            SendInput(1, ref input, Marshal.SizeOf(new Input()));
        }

        public static void LeftUp()
        {
            var input = new Input
            {
                Type = SendInputEventType.InputMouse
            };

            input.Union.MouseInputData.Flag = MouseEventFlags.MOUSEEVENTF_LEFTUP;
            SendInput(1, ref input, Marshal.SizeOf(new Input()));
        }

        public static void LeftClick()
        {
            LeftDown();
            LeftUp();
        }

        public static void RightDown()
        {
            var input = new Input
            {
                Type = SendInputEventType.InputMouse
            };

            input.Union.MouseInputData.Flag = MouseEventFlags.MOUSEEVENTF_RIGHTDOWN;
            SendInput(1, ref input, Marshal.SizeOf(new Input()));
        }

        public static void RightUp()
        {
            var input = new Input
            {
                Type = SendInputEventType.InputMouse
            };

            input.Union.MouseInputData.Flag = MouseEventFlags.MOUSEEVENTF_RIGHTUP;
            SendInput(1, ref input, Marshal.SizeOf(new Input()));
        }

        public static void RightClick()
        {
            RightDown();
            RightUp();
        }
    }
}