namespace Cashier
{
    internal static class Program
    {
        public static Database db = new Database();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            //Check if the database is connected
            if (!db.Database.CanConnect())
            {
                MessageBox.Show("Database is not connected");
                return;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}