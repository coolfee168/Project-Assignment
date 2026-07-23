using ProjectAssignment.sokpanha;

namespace ProjectAssignment
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
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new StuffDashBoard());
=======
            Application.Run(new FormAdmin());
>>>>>>> 57540662b1ff457f8eee948821bcc4c8d2b27e6c
        }
    }
}