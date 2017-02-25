using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace FocusBattlefield
{
    public class Program
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        public static void Main(string[] args)
        {
            var bfProcess = Process.GetProcessesByName("bf4").FirstOrDefault();
            if (bfProcess == null)
            {
                Console.WriteLine("bf4.exe not found.");
                Console.ReadKey();
                return;
            }

            if (bfProcess.MainWindowHandle == IntPtr.Zero)
            {
                Console.WriteLine("No main window handle.");
                Console.ReadKey();
                return;
            }

            SwitchToThisWindow(bfProcess.MainWindowHandle, true);
        }
    }
}
