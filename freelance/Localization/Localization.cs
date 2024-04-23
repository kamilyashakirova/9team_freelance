namespace freelance.forms
{
    internal static class Localization
    {
        private static Dictionary<string, string> localizedStrings = new Dictionary<string, string>();
        public static event EventHandler LanguageChanged;
        /// <summary>
        /// Метод для перевода строки на другой язык
        /// </summary>
        /// <param name="filePath"></param>
        public static void UpdateLocalizedStrings(string filePath)
        {
            localizedStrings.Clear();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        if (data.Length >= 2)
                        {
                            localizedStrings[data[0]] = data[1];
                        }
                    }
                }
                LanguageChanged?.Invoke(null, EventArgs.Empty);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка. Файл не читается: " + e.Message);
            }
        }
        /// <summary>
        /// Метод для того чтобы вернуть локализованную строку для присвоения её ключу
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetLocalizedString(string key)
        {
            if (localizedStrings.ContainsKey(key))
            {
                return localizedStrings[key];
            }
            else
            {
                return key;
            }
        }
    }
}

