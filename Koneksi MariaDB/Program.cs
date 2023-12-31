using System.Runtime.InteropServices;

namespace Koneksi_MariaDB {
    internal static class Program {

        // Kode untuk menampilkan console
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // Kode untuk menampilkan console
            AllocConsole();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}