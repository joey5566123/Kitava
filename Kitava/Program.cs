using Kitava.GUI;
using System;
using System.Windows.Forms;

namespace Kitava
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new KitavaForm());
        }
    }
}