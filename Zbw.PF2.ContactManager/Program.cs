using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.UI;

namespace Zbw.PF2.ContactManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration
            ApplicationConfiguration.Initialize();
            
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.SetCompatibleTextRenderingDefault(false);

            FontManager.InitializeFonts();

            Application.Run(new MainForm());
        }
    }
}