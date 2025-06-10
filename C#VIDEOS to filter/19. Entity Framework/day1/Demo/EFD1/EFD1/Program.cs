namespace EFD1
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
            Application.Run(new Form1());
            // Scaffold-DbContext "Server=DESKTOP-JP4B1RU;Database=EFD1;Trusted_Connection=True;Trust Server Certificate=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
        }
    }
}