using da3_07451_final.Business;

namespace da3_07451_final
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
            new App().StartApp();
        }
        //ApplicationConfiguration.Initialize();
        //    Application.Run(new FilmsActeursManagementForm());
    }
}