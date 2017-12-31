using System.Runtime.InteropServices;
using System.Windows.Forms;
using static Kitava.Library.InputSimulator;

namespace Kitava.Library
{
    class Keyboard
    {
        public static void Down(Keys key)
        {
            var input = new Input
            {
                Type = SendInputEventType.InputKeyboard
            };

            input.Union.KeyboardInputData.Flag = KeyboardEventFlags.KEYBDEVENTF_EXTENDEDKEY;
            input.Union.KeyboardInputData.VirtualKey = SwitchKey(key);
            SendInput(1, ref input, Marshal.SizeOf(new Input()));
        }

        public static void Up(Keys key)
        {
            var input = new Input
            {
                Type = SendInputEventType.InputKeyboard
            };

            input.Union.KeyboardInputData.Flag = KeyboardEventFlags.KEYBDEVENTF_KEYUP | KeyboardEventFlags.KEYBDEVENTF_EXTENDEDKEY;
            input.Union.KeyboardInputData.VirtualKey = SwitchKey(key);
            SendInput(1, ref input, Marshal.SizeOf(new Input()));
        }

        public static void Press(Keys key)
        {
            Down(key);
            Up(key);
        }

        public static void Copy()
        {
            Down(Keys.Control);
            Press(Keys.C);
            Up(Keys.Control);
        }
    }
}