using NLog;
using NLog.Config;
using System.Net.Mail;
namespace freelance.forms
{
    public partial class ForgotpasswordForm : Form
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        private string file = String.Empty;
        private string message_fpf1 = "Введите логин";
        private string message_fpf2 = "Такого почтового ящика не существует";
        private string message_fpf3 = "Вы успешно вошли";
        private string message_fpf4 = "Неверный логин";
        private string message_fpf5 = "Некорректный адрес электронной почты";
        public ForgotpasswordForm(string locfile)
        {
            file = locfile;
            InitializeComponent();
            LogManager.Configuration = new XmlLoggingConfiguration("../../../logg/NLog.config");
            Localization.LanguageChanged += UpdateLocalization;
            logger.Info("Успешно открылось форма 'ForgotpasswordForm'.");
        }
        public static string GenerateNewPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var password = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }
        private void sendemail(string email, string? password)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("9teamfreelance@mail.ru", "freelance");
            try
            {
                mail.To.Add(new MailAddress(email));
            }
            catch (Exception ex)
            {
                MessageBox.Show(message_fpf5);
                logger.Error(ex.ToString());
            }
            mail.Subject = "frelance: восстановление пароля";
            mail.Body = $"ваш новый пароль: {password}. пожалуйста, никому его не сообщайте";
            SmtpClient smtp = new SmtpClient("smtp.mail.ru");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("9teamfreelance@mail.ru", "BrbJHbFfsjS7SeGG8pNq");
            try
            {
                smtp.Send(mail);
                logger.Info("Пользователю успешно отправилось письмо на почту.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(message_fpf2);
                logger.Error(ex.ToString());
            }
        }

        private void sendpassword_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DBcontext())
                {
                    if (login_txt.Text != String.Empty)
                    {
                        var user = db.Users.Where(user => user.ULogin == login_txt.Text).FirstOrDefault();
                        if (user != null)
                        {
                            string password = GenerateNewPassword();
                            sendemail(user.Email, password);
                            user.UPasswordHash = Hashing.hash(password);
                            db.SaveChanges();
                            writepassword_lbl.Visible = true;
                            newpassword_txt.Visible = true;
                            newenter_btn.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show(message_fpf4);
                        }
                    }
                    else
                    {
                        MessageBox.Show(message_fpf1);
                        writepassword_lbl.Visible = false;
                        newpassword_txt.Visible = false;
                        newenter_btn.Visible = false;
                    }
                }

            }
            catch
            {
                MessageBox.Show(message_fpf1);
            }
        }
        private void newenter_btn_Click(object sender, EventArgs e)
        {

            logger.Info("Нажата кнопка 'Войти' для формы 'ForgotpasswordForm'");
            if ((newpassword_txt.Text != String.Empty))
            {
                var enter = workingwithDB.LogIn(login_txt.Text, newpassword_txt.Text);
                if (enter)
                {
                    MessageBox.Show(message_fpf3);
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
        //Локализация
        private void ForgotpasswordForm_Load(object sender, EventArgs e)
        {

            Localization.LoadLocalizationDictionary(this, file);
        }
        private void UpdateLocalization(object sender, EventArgs e)
        {
            this.Text = Localization.GetLocalizedString("ForgotpasswordForm");
            newpassword_txt.PlaceholderText = Localization.GetLocalizedString("newpassword_txt");
            message_fpf1 = Localization.GetLocalizedString("login_txtb");
            message_fpf2 = Localization.GetLocalizedString("message_fpf2");
            message_fpf3 = Localization.GetLocalizedString("message1enter");
            message_fpf4 = Localization.GetLocalizedString("message_fpf4");
            message_fpf5 = Localization.GetLocalizedString("message_fpf5");
        }
    }
}
