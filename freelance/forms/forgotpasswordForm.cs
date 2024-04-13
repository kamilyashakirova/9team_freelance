using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Net.Mail;
namespace freelance
{
    public partial class forgotpasswordForm : Form
    {
        public forgotpasswordForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// метод для отправки сообщения с паролем от аккаунта пользователя на его почту 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        private void sendemail(string? email, string? password)
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
                var elog = hashing.hash(login_txt.Text);
                var user = db.users.Where(user => user.uLogin == elog).FirstOrDefault();
                sendemail(user.email, user.uPasswordHash);
                writepassword_lbl.Visible = true;
                newpassword_txt.Visible = true;
                newenter_btn.Visible = true;
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
