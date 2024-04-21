using System.Drawing.Text;
using System.Windows.Forms;
namespace freelance
{
    public class FontClass
    {
        private static Font? customFont;
        public static void SetCustomFont(Control control, int fontsize)
        {
            if (customFont == null)
            {
                customFont = LoadCustomFont(fontsize);
                control.Font = customFont;
            }
            control.Font = customFont;
        }
        private static Font LoadCustomFont(int fontsize)
        {
            Font? font = null;
            try
            {
                var fonts = new PrivateFontCollection();
                fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
                font = new Font(fonts.Families[0], fontsize);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки шрифта: " + ex.Message);
            }
            return font;
        }
    }
}
