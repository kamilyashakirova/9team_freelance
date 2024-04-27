using freelance.forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail;
using System.ComponentModel;
namespace freelance
{
    public static class ForUnitTests
    {
        public static string CheckLocalization(string a)
        {

            Localization.localizationDictionary = new Dictionary<string, string>()
            {
                { a, "Bonjour" }
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
    }
}
