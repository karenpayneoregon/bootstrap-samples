using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Bootstrap5CheckBoxExample.Classes;

    public static class WindowHelper
    {
        public static void SetConsoleWindowTitle(this WebApplication app, string title)
        {

            Process[] processes = Process.GetProcesses();

            var consoleTitle = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                string.Concat(AppDomain.CurrentDomain.FriendlyName, ".exe"));

            var process = processes.FirstOrDefault(x => x.MainWindowTitle == consoleTitle);
            SetWindowText(process.MainWindowHandle, title);

        }


        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);

    }
