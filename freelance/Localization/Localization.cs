namespace freelance.forms
{
    internal static class Localization
    {
        public static Dictionary<string, string> localizationDictionary = new Dictionary<string, string>();
        public static event EventHandler LanguageChanged;
        private static string? filePath;
        private static string[]? lines;
        private static string[]? parts;
        public static void LoadLocalizationDictionary(Form form, string language)
        {
            localizationDictionary.Clear();
            filePath = $"../../../Localization/{language}.csv";
            if (File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        localizationDictionary[parts[0]] = parts[1];
                    }
                }
            }
            Update(form);
            LanguageChanged?.Invoke(null, EventArgs.Empty);
        }
        public static void Update (Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Label || control is Button || control is CheckBox)
                {
                    if (localizationDictionary.ContainsKey(control.Name))
                    {
                        control.Text = localizationDictionary[control.Name];
                    }
                }
            }
        }
        public static string GetLocalizedString(string key)
        {
            if (localizationDictionary.ContainsKey(key))
            {
                return localizationDictionary[key];
            }
            else
            {
                return key;
            }
        }
    }
}

