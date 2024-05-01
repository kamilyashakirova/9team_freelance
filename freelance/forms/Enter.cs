using NLog;
using NLog.Config;
using System.Drawing.Text;
namespace freelance.forms
{
    public partial class Enter : Form
    {
        PrivateFontCollection fonts = new PrivateFontCollection();
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static Dictionary<string, string> localizationDictionary = new Dictionary<string, string>();
        private string message1 = "Вы успешно вошли";
        private string message2 = "Неверный логин или пароль.";
        private static string locfile = "Localization";
        ForgotpasswordForm forgotpasswordForm = new ForgotpasswordForm(locfile);
        RegistrationForm registration = new RegistrationForm(locfile);
        public Enter()
        {
            fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
            InitializeComponent();
            hi_lbl.Font = new Font(fonts.Families[0], 16, FontStyle.Bold);
            hi_lbl.Location = new Point(125, 187);
            forgotpassword_lbl.Font = new Font(fonts.Families[0], 12, FontStyle.Underline);
            LogManager.Configuration = new XmlLoggingConfiguration("../../../logg/NLog.config");
            logger.Info("Успешно открыта форма 'Enter'");
            Localization.LanguageChanged += UpdateLocalization;
        }
        private void enter_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Вход'");
            if (password_txtb.Text != String.Empty)
            {
                logger.Info("Проверка логина и пароля");
                var enter = workingwithDB.LogIn(login_txtb.Text, password_txtb.Text);
                if (enter)
                {
                    MessageBox.Show(message1);
                    logger.Info("Пользователь успешно вошёл");
                    this.Close();
                }
                else
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
            forgotpasswordForm.Show();
        }
        private void registration_lbl_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Зарегистрироваться'");
            registration.Show();
        }
        //Локализация
        private void rus_change_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Русский', изменение языка на татарский");
            Localization.LoadLocalizationDictionary(this, "newLocalization");
            locfile = "newLocalization";
            forgotpasswordForm = new ForgotpasswordForm(locfile);
            registration = new RegistrationForm(locfile);
            rus_change_btn.Visible = false;
            tat_change_btn.Visible = true;
        }
        private void tat_change_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Татарча', изменение языка на русский");
            Localization.LoadLocalizationDictionary(this, "Localization");
            locfile = "Localization";
            forgotpasswordForm = new ForgotpasswordForm(locfile);
            registration = new RegistrationForm(locfile);
            tat_change_btn.Visible = false;
            rus_change_btn.Visible = true;
        }
        private void UpdateLocalization(object sender, EventArgs e)
        {
            this.Text = Localization.GetLocalizedString("Enter");
            login_txtb.PlaceholderText = Localization.GetLocalizedString("login_txtb");
            password_txtb.PlaceholderText = Localization.GetLocalizedString("password_txtb");
            message2 = Localization.GetLocalizedString("message2enter");
            message1 = Localization.GetLocalizedString("message1enter");
        }

        private void Enter_Load(object sender, EventArgs e)
        {
            Localization.LoadLocalizationDictionary(this, locfile);
        }
    }
}
