namespace freelance
{
    internal static class Program
    {
        static bool allowed;
        static int uId;
        /// <summary>
        /// метод, для входа в аккаунт
        /// </summary>
        /// <param name="allowed"></param>
        /// <param name="uId"></param>
        public static void LogInInfo(bool allowed, int uId = -1)
        {
            Program.allowed = allowed;
            Program.uId = uId;
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Enter());
        }
    }
}