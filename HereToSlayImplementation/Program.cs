using Microsoft.Identity.Client;
using System.Runtime.InteropServices;

namespace HereToSlayImplementation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                GM.LoginForm = new Form1();
                GM.LoginForm.Show();
                Application.Run();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Terminated with exception");
            }

            Console.WriteLine("Terminated successfully");

        }
    }

    static class GM
    {
        public static Form1 LoginForm { get; set; }
        public static Form2 LobbyForm;
        public static Form3 GameForm;
        public static Form4 WinForm;
    }
}