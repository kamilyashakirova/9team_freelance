using NLog;
using NLog.Config;
using System.Drawing.Text;
namespace freelance.forms
{
    public partial class Enter : Form
    {
        PrivateFontCollection fonts = new PrivateFontCollection();
        public static Logger logger = LogManager.GetCurrentClassLogger();
        private string message1 = "Вы успешно вошли";
        private string message2 = "Неверный логин или пароль.";
        string localizationfile;
        public Enter(string localizationfilename)
        {
            localizationfile = localizationfilename;
            Localization.UpdateLocalizedStrings(localizationfile);
            Localization.LanguageChanged += UpdateLocalization;
            fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
            InitializeComponent();
            FontClass.SetCustomFont(this, 12);
            FontClass.SetCustomFont(login_txtb, 11);
            FontClass.SetCustomFont(password_txtb, 11);
            hi_lbl.Font = new Font(fonts.Families[0], 16, FontStyle.Bold);
            hi_lbl.Location = new Point(125, 187);
            FontClass.SetCustomFont(enter_btn, 11);
            forgotpassword_lbl.Font = new Font(fonts.Families[0], 12, FontStyle.Underline);
            LogManager.Configuration = new XmlLoggingConfiguration("../../../logg/NLog.config");
            logger.Info("Успешно открыта форма 'Enter'");
        }
        private void enter_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Вход'");
            if (password_txtb.Text != String.Empty)
            {
                logger.Info("Проверка логина и пароля");
                var enter = workingwithDB.LogIn(login_txtb.Text, password_txtb.Text);
                var enterr = workingwithDB.AfterForgotPasswordForm(login_txtb.Text, password_txtb.Text);
                if (enter || enterr)
                {
                    logger.Info("Пользователь успешно вошёл");
                    MessageBox.Show(message1);
                    this.Close();
                }
                else if(!enter && !enterr)
                {
                    entererror_lbl.Text = message2;
                    logger.Error("неверный логин или пароль");
                }
            }
        }
        private void hide_picb_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Спрятать пароль'");
            password_txtb.PasswordChar = '*';
            password_txtb.Font = new Font(fonts.Families[0], 11);
            hide_picb.Visible = false;
            show_pic.Visible = true;
        }
        private void show_pic_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Увидеть пароль'");
            password_txtb.PasswordChar = '\0';
            password_txtb.Font = new Font(fonts.Families[0], 11);
            hide_picb.Visible = true;
            show_pic.Visible = false;
        }

        private void forgotpassword_lbl_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Забыли пароль?'");
            var forgotpasswordForm = new ForgotpasswordForm();
            forgotpasswordForm.Show();
        }
        private void registration_lbl_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Зарегистрироваться'");
            var registration = new RegistrationForm();
            registration.Show();
        }
        private void UpdateLocalization(object sender, EventArgs e)
        {
            this.Text = Localization.GetLocalizedString("Enter");
            hi_lbl.Text = Localization.GetLocalizedString("hi_lbl");
            login_txtb.PlaceholderText = Localization.GetLocalizedString("login_txtb");
            password_txtb.PlaceholderText = Localization.GetLocalizedString("password_txtb");
            enter_btn.Text = Localization.GetLocalizedString("enter_btn");
            forgotpassword_lbl.Text = Localization.GetLocalizedString("forgotpassword_lbl");
            registration_lbl.Text = Localization.GetLocalizedString("registration_lbl");
            message2 = Localization.GetLocalizedString("message2enter");
            message1 = Localization.GetLocalizedString("message1enter");
        }
        private void rus_change_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Русский', изменение языка на татарский");
            localizationfile = "../../../Localization/newLocalization.csv";
            Localization.UpdateLocalizedStrings(localizationfile);
            rus_change_btn.Visible = false;
            tat_change_btn.Visible = true;
        }

        private void tat_change_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Татарча', изменение языка на русский");
            localizationfile = "../../../Localization/Localization.csv";
            Localization.UpdateLocalizedStrings(localizationfile);
            tat_change_btn.Visible = false;
            rus_change_btn.Visible = true;
        }
    }
}
