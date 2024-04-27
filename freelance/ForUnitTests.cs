using freelance.forms;
using System.Net.Mail;
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

        public static void TestCheckDislikedPerformers(string message1)
        {
            using (var db = new DBcontext())
            {
                var performer = db.Performers.Where(p => p.ID.ToString() == "1").FirstOrDefault();
                if (performer != null)
                {
                    if (db.DislikedPerformers.Any(u => u.PerformerID == performer.ID))
                    {
                        MessageBox.Show(message1);
                    }
                }
            }

        }

        public static void TestAddLikeIfPerformerNotLiked(string message1)
        {
            using (var db = new DBcontext())
            {
                var performer = db.Performers.Where(p => p.ID.ToString() == "2").FirstOrDefault();
                if (performer != null)
                    if (db.LikedPerformers.Any(u => u.PerformerID == performer.ID))
                    {
                        MessageBox.Show(message1);
                    }
            }
        }

        public static void TestAddLikedPerformers(string message1)
        {
            using (var db = new DBcontext())
            {
                var performer = db.Performers.Where(p => p.ID.ToString() == "2").FirstOrDefault();
                int clientID = 1;
                if (performer != null)
                    if (!db.LikedPerformers.Any(u => u.PerformerID == performer.ID))
                    {
                        workingwithDB.AddLike(clientID, performer.ID);
                    }
                    else
                    {
                        MessageBox.Show(message1);
                    }
            }
        }

        public static void TestAddDislikeToPerformer(string message1)
        {
            using (var db = new DBcontext())
            {
                var performer = db.Performers.Where(p => p.ID.ToString() == "1").FirstOrDefault();
                if (performer != null)
                    if (!db.DislikedPerformers.Any(u => u.PerformerID == performer.ID))
                    {
                        workingwithDB.AddDislike(performer.ClientID, performer.ID);
                        MessageBox.Show(message1);
                    }
            }
        }
    }

}
