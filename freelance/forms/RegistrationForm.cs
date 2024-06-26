﻿using NLog;

namespace freelance.forms
{
    public partial class RegistrationForm : Form
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        private string message1_reg = "Вы успешно зарегистрировались.";
        private string message2_reg = "Ошибка. Проверьте, правильно ли Вы повторили пароль.";
        private string message3_reg = "Заполните поле для почты";
        private string message1_regname = "Поле имени не должно быть пустым.";
        private string message2_regname = "Имя не должно содержать цифры.";
        private string message1_regsurname = "Поле фамилии не должно быть пустым.";
        private string message2_regsurname = "Фамилия не должна содержать цифры.";
        private string message1_regpatronymic = "Отчество не должно содержать цифры.";
        private string message1_regLogin = "Поле логин не должно быть пустым.";
        private string message1_regPassword = "Поле пароль не должно быть пустым.";

        private string file = String.Empty;
        public RegistrationForm(string locfile)
        {
            InitializeComponent();
            file = locfile;
            Localization.LanguageChanged += UpdateLocalization;
            logger.Info("Успешно открылось форма 'RegistrationForm'.");
        }
        private void show_pic_Click(object sender, EventArgs e)
        {
            rpassword_txtb.PasswordChar = '\0';
            show_pic.Visible = false;
            hide_picb.Visible = true;
        }
        private void hide_picb_Click(object sender, EventArgs e)
        {
            rpassword_txtb.PasswordChar = '*';
            hide_picb.Visible = false;
            show_pic.Visible = true;
        }
        private void registration_btb_click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rEmail_txtb.Text))
            {
                if (rpasswordrepeat_txtb.Text == rpassword_txtb.Text)
                {
                    workingwithDB.AddUserAndClient(rlogin_txtb.Text, rpassword_txtb.Text, rEmail_txtb.Text, rname_txtb.Text, rsurname_txtb.Text, rpatronomic_txtb.Text);
                    MessageBox.Show(message1_reg);
                    logger.Info("Пользователь успешно зарегистрировался.");
                }
                else
                {
                    MessageBox.Show(message2_reg);
                    logger.Error("Ошибка в регистрации");
                }
            }
            else
            {
                MessageBox.Show(message3_reg);
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {

            logger.Info("Пользователь успешно зарегистрировался.");
            this.Close();
        }

        private void rsurname_txtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rname_txtb.Text))
            {
                MessageBox.Show(message1_regname);
            }
            if (rname_txtb.Text.Any(char.IsDigit))
            {
                MessageBox.Show(message2_regname);
            }
        }

        private void rpatronomic_txtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rsurname_txtb.Text))
            {
                MessageBox.Show(message1_regsurname);
            }
            if (rsurname_txtb.Text.Any(char.IsDigit))
            {
                MessageBox.Show(message2_regsurname);
            }
        }
        private void rlogin_txtb_TextChanged(object sender, EventArgs e)
        {
            if (rpatronomic_txtb.Text.Any(char.IsDigit))
            {
                MessageBox.Show(message1_regpatronymic);
            }
        }

        private void rEmail_txtb_TextChanged(object sender, EventArgs e)
        {
            if (rlogin_txtb.Text.Any(char.IsDigit))
            {
                MessageBox.Show(message1_regLogin);
            }
            if (rpassword_lbl.Text.Any(char.IsDigit))
            {
                MessageBox.Show(message1_regPassword);
            }
        }
        //Локализация
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            Localization.LoadLocalizationDictionary(this, file);
        }
        private void UpdateLocalization(object sender, EventArgs e)
        {
            this.Text = Localization.GetLocalizedString("RegistrationForm");
            rname_txtb.PlaceholderText = Localization.GetLocalizedString("rname_txtb");
            rsurname_txtb.PlaceholderText = Localization.GetLocalizedString("rsurname_txtb");
            rpatronomic_txtb.PlaceholderText = Localization.GetLocalizedString("rpatronomic_txtb");
            rlogin_txtb.PlaceholderText = Localization.GetLocalizedString("rlogin_txtb");
            rpassword_txtb.PlaceholderText = Localization.GetLocalizedString("rpassword_txtb");
            rpasswordrepeat_txtb.PlaceholderText = Localization.GetLocalizedString("rpasswordrepeat_txtb");
            rEmail_txtb.PlaceholderText = Localization.GetLocalizedString("rEmail_txtb");

            message1_reg = Localization.GetLocalizedString("message1_reg");
            message2_reg = Localization.GetLocalizedString("message2_reg");
            message3_reg = Localization.GetLocalizedString("message3_reg");
            message1_regname = Localization.GetLocalizedString("message1_regname");
            message2_regname = Localization.GetLocalizedString("message2_regname");
            message1_regsurname = Localization.GetLocalizedString("message1_regsurname");
            message2_regsurname = Localization.GetLocalizedString("message2_regsurname");
            message1_regpatronymic = Localization.GetLocalizedString("message1_regpatronymic");
            message1_regLogin = Localization.GetLocalizedString("message1_regLogin");
            message1_regPassword = Localization.GetLocalizedString("message1_regPassword");
        }
    }
}
