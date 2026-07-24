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
<<<<<<< HEAD
            ApplicationConfiguration.Initialize(); 
            Application.Run(new StuffDashBoard());
            Application.Run(new FormAdmin());
=======
            ApplicationConfiguration.Initialize();

            Application.Run(new StuffDashBoard());
>>>>>>> 27e0cba64efeb6edba5dc3a271e56def56acbb65

        }
    }
}