using NLog;
using NLog.Config;
using System.Net.Mail;
namespace freelance.forms
{
    public partial class ForgotpasswordForm : Form
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public ForgotpasswordForm()
        {
            InitializeComponent();
            LogManager.Configuration = new XmlLoggingConfiguration("../../../logg/NLog.config");
            FontClass.SetCustomFont(this, 10);
            FontClass.SetCustomFont(passwordrecovery_lbl, 18);
            FontClass.SetCustomFont(login_lbl, 12);
            FontClass.SetCustomFont(writepassword_lbl, 12);

            Localization.LanguageChanged += UpdateLocalization;

            logger.Info("Успешно открылось форма 'ForgotpasswordForm'.");
        }
        private void sendemail(string email, string? password)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("9teamfreelance@mail.ru", "freelance");
            try
            {
                mail.To.Add(new MailAddress(email));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Некорректный адрес электронной почты");
                logger.Error(ex.ToString());
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
                logger.Info("Пользователю успешно отправилось письмо на почту.");

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Такого почтового ящика не существует");
                logger.Error(ex.ToString());
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

            logger.Info("Нажата кнопка 'Войти' для формы 'ForgotpasswordForm'");
            if ((newpassword_txt.Text != String.Empty))
            {
                var enter = workingwithDB.AfterForgotPasswordForm(login_txt.Text, newpassword_txt.Text);
                if (enter)
                {
                    MessageBox.Show("вы успешно вошли");
                    Close();
                }
                errorRepeatnewp_lbl.Visible = true;
            }
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Назад'");
            this.Close();
        }
        private void UpdateLocalization(object sender, EventArgs e)
        {
            this.Text = Localization.GetLocalizedString("ForgotpasswordForm");
            passwordrecovery_lbl.Text = Localization.GetLocalizedString("passwordrecovery_lbl");
            login_lbl.Text = Localization.GetLocalizedString("login_lbl");
            loginerror_lbl.Text = Localization.GetLocalizedString("loginerror_lbl");
            sendpassword_btn.Text = Localization.GetLocalizedString("sendpassword_btn");
            writepassword_lbl.Text = Localization.GetLocalizedString("writepassword_lbl");
            newpassword_txt.Text = Localization.GetLocalizedString("newpassword_txt");
            passworderror_lbl.Text = Localization.GetLocalizedString("passworderror_lbl");
            newenter_btn.Text = Localization.GetLocalizedString("newenter_btn");
        }
    }
}
