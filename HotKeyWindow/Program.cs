using HotkeyWindow;
using System;

using System.Windows.Forms;

namespace HotKeyWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            new tapi();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HotkeyAppContext());
        }
    }
}
