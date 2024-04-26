using freelance.forms;

namespace freelance
{
    internal static class Program
    {
        public static bool allowed;
        public static int uId;
        public static Dictionary<string, string> localizationDictionary = new Dictionary<string, string>();
        /// <summary>
        /// метод, для входа в аккаунт
        /// </summary>
        /// <param name="allowed"></param>
        /// <param name="uId"></param>
        public static void LogInInfo(bool allowed, int uId)
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
                Application.Run(new Enter());
                if (allowed)
                {
                    allowed = false;
                    Application.Run(new ListOfRecomendations(uId));
                }
            }
            while (allowed);
        }
    }
}