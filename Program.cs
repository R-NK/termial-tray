using System;
using System.Windows.Forms;

namespace WindowsTerminalTray
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (TerminalTrayIcon ti = new TerminalTrayIcon())
            {
                Application.Run();
            }
        }
    }
}
