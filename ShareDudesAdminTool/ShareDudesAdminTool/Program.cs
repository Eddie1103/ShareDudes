namespace ShareDudesAdminTool
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
            Application.Run(new Login());

            /*
            string apiUrl = "http://192.168.6.217:5000";
            //string apiUrl = "192.168.6.217:5000";

            Connection connection = new Connection(apiUrl);
            await connection.Start();
            */

        }
    }  
}