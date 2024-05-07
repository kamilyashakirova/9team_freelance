using freelance.forms;


namespace freelance
{
    internal static class Program
    {
        public static bool allowed;
        public static Guid uId;
        public static string loc = "Localization";
        /// <summary>
        /// метод, для входа в аккаунт
        /// </summary>
        /// <param name="allowed"></param>
        /// <param name="uId"></param>
        public static void LogInInfo(bool allowed, Guid uId)
        {
            Program.allowed = allowed;
            Program.uId = uId;
        }
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            do
            {
                var enter = new Enter();
                Application.Run(enter);
                if (allowed)
                {
                    allowed = false;
                    Application.Run(new ListOfRecomendations(uId, enter.locfile));
                }
            }
            while (allowed);
        }
    }
}