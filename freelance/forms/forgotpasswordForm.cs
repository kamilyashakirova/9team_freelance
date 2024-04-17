using System.Net.Mail;
namespace freelance.forms
{
    public partial class forgotpasswordForm : Form
    {
        public forgotpasswordForm()
        {
            InitializeComponent();
            FontClass.SetCustomFont(this, 10);
            FontClass.SetCustomFont(passwordrecovery_lbl, 18);
            FontClass.SetCustomFont(login_lbl,12);
            FontClass.SetCustomFont(writepassword_lbl, 12);
        }
        private void sendemail(string email, string? password)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("9teamfreelance@mail.ru", "freelance");
            try
            {
                mail.To.Add(new MailAddress(email));
            }
            catch
            {
                MessageBox.Show("не годится для адреса электронной почты");
            }
            mail.Subject = "frelance: восстановление пароля";
            mail.Body = $"ваш пароль: {password}. пожалуйста, никому его не сообщайте";
            SmtpClient smtp = new SmtpClient("smtp.mail.ru");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("9teamfreelance@mail.ru", "BrbJHbFfsjS7SeGG8pNq");
            try
            {
                smtp.Send(mail);
            }
            catch
            {
                MessageBox.Show("такого почтового ящика не существует");
            }
        }

        private void sendpassword_btn_Click(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                var user = db.Users.Where(user => user.ULogin == login_txt.Text).FirstOrDefault();
                if (user != null)
                {
                    sendemail(user.Email, user.UPasswordHash);
                    writepassword_lbl.Visible = true;
                    newpassword_txt.Visible = true;
                    newenter_btn.Visible = true;
                }
                else
                {
                    MessageBox.Show("неверный логин");
                }
            }
        }
        private void newenter_btn_Click(object sender, EventArgs e)
        {
            if ((newpassword_txt.Text != String.Empty))
            {
                var enter = workingwithDB.LogIn(login_txt.Text, newpassword_txt.Text);
                if (enter)
                {
                    MessageBox.Show("вы успешно вошли");
                    Close();
                }
                errorRepeatnewp_lbl.Visible = true;
            }
        }
    }
}
