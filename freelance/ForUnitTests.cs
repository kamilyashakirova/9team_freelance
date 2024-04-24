using freelance.forms;

namespace freelance
{
     public static class ForUnitTests
     {
        public static string CheckBoxLocalizated(string filepath, string key)
        {
            Localization.UpdateLocalizedStrings(filepath);
            key = Localization.GetLocalizedString($"{key}");
            var res = Localization.GetLocalizedString(key);
            return res;
        }
     }
}
