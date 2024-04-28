using freelance.forms;
using System.Drawing.Text;
using System.Net.Mail;
using System.Security.Cryptography;
namespace freelance
{
    public static class ForUnitTests
    {
        public static string CheckLocalization(string a)
        {

            Localization.localizationDictionary = new Dictionary<string, string>()
        {
            { a, "value" }
        };
            var res = Localization.GetLocalizedString(a);
            return res;
        }
        public static void CheckSendEmail(string email, string message)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("9teamfreelance@mail.ru", "freelance");
            try
            {
                mail.To.Add(new MailAddress(email));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            mail.Subject = "frelance";
            mail.Body = message;
            SmtpClient smtp = new SmtpClient("smtp.mail.ru");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("9teamfreelance@mail.ru", "BrbJHbFfsjS7SeGG8pNq");
            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void Test_Surname_TextChange(string message1, string message2)
        {
            var textBox = new TextBox();

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(message1);
            }
            if (textBox.Text.Any(char.IsDigit))
            {
                MessageBox.Show(message2);
            }
        }

        public static void Test_Patronomic_TextChanged(string message1, string message2)
        {
            var textBox = new TextBox();

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(message1);
            }
            if (textBox.Text.Any(char.IsDigit))
            {
                MessageBox.Show(message2);
            }
        }

        public static void Test_Rlogin_TextChange(string message1)
        {
            var textBox = new TextBox();

            if (textBox.Text.Any(char.IsDigit))
            {
                MessageBox.Show(message1);
            }
        }

        public static void Test_REmail_TextChange(string message1, string message2)
        {
            var textBox = new TextBox();
            var label = new Label();

            if (textBox.Text.Any(char.IsDigit))
            {
                MessageBox.Show(message1);
            }
            if (label.Text.Any(char.IsDigit))
            {
                MessageBox.Show(message2);
            }
        }
        public static string Test_Hasing(string data)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(data));
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static void Test_LogInInfo(bool allowed, int uId)
        {
            Program.allowed = allowed;
            Program.uId = uId;
        }
        public static Font Test_LoadingCustomFont(int fontsize)
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
        public static string TestGenerateNewPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var password = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }
    }

}
