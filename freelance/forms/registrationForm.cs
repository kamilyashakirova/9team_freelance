namespace freelance.forms
{
    public partial class RegistrationForm : Form
    {
        private string message1_reg = "Вы успешно зарегистрировались.";
        private string message2_reg = "Ошибка. Проверьте, правильно ли Вы повторили пароль.";
        private string message3_reg = "Заполните поле для почты";
        private string message1_regname = "Поле имени не должно быть пустым.";
        private string message2_regname = "Имя не должно содержать цифры.";
        private string message1_regsurname = "Поле фамилии не должно быть пустым.";
        private string message2_regsurname = "Фамилия не должна содержать цифры.";
        private string message1_regpatronymic = "Отчество не должно содержать цифры.";

        private static Mutex mutex = new Mutex();

        public RegistrationForm()
        {
            InitializeComponent();
            FontClass.SetCustomFont(this, 10);
            FontClass.SetCustomFont(reg_lbl, 18);
            FontClass.SetCustomFont(registration_btn, 18);

            Localization.LanguageChanged += UpdateLocalization;
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
            mutex.WaitOne();
            if (!string.IsNullOrWhiteSpace(rEmail_txtb.Text))
            {
                if (rpasswordrepeat_txtb.Text == rpassword_txtb.Text)
                {
                    workingwithDB.AddUserAndClient(rlogin_txtb.Text, rpassword_txtb.Text, rEmail_txtb.Text, rname_txtb.Text, rsurname_txtb.Text, rpatronomic_txtb.Text);
                    MessageBox.Show(message1_reg);
                    mutex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show(message2_reg);
                }
            }
            else
            {
                MessageBox.Show(message3_reg);
            }
            mutex.ReleaseMutex();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
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
        private void UpdateLocalization(object sender, EventArgs e)
        {
            this.Text = Localization.GetLocalizedString("RegistrationForm");
            reg_lbl.Text = Localization.GetLocalizedString("reg_lbl");
            rnae_lbl.Text = Localization.GetLocalizedString("rnae_lbl");
            rname_txtb.PlaceholderText = Localization.GetLocalizedString("rname_txtb");
            rsurname_lbl.Text = Localization.GetLocalizedString("rsurname_lbl");
            rsurname_txtb.PlaceholderText = Localization.GetLocalizedString("rsurname_txtb");
            rpatronymic_lbl.Text = Localization.GetLocalizedString("rpatronymic_lbl");
            rpatronomic_txtb.PlaceholderText = Localization.GetLocalizedString("rpatronomic_txtb");
            rlogin_lbl.Text = Localization.GetLocalizedString("rlogin_lbl");
            rlogin_txtb.PlaceholderText = Localization.GetLocalizedString("rlogin_txtb");
            rpassword_lbl.Text = Localization.GetLocalizedString("rpassword_lbl");
            rpassword_txtb.PlaceholderText = Localization.GetLocalizedString("rpassword_txtb");
            rpasswordrepeat_lbl.Text = Localization.GetLocalizedString("rpasswordrepeat_lbl");
            rpasswordrepeat_txtb.PlaceholderText = Localization.GetLocalizedString("rpasswordrepeat_txtb");
            rEmail_lbl.Text = Localization.GetLocalizedString("rEmail_lbl");
            rEmail_txtb.PlaceholderText = Localization.GetLocalizedString("rEmail_txtb");
            registration_btn.Text = Localization.GetLocalizedString("registration_btn");

            message1_reg = Localization.GetLocalizedString("message1_reg");
            message2_reg = Localization.GetLocalizedString("message2_reg");
            message3_reg = Localization.GetLocalizedString("message3_reg");
            message1_regname = Localization.GetLocalizedString("message1_regname");
            message2_regname = Localization.GetLocalizedString("message2_regname");
            message1_regsurname = Localization.GetLocalizedString("message1_regsurname");
            message2_regsurname = Localization.GetLocalizedString("message2_regsurname");
            message1_regpatronymic = Localization.GetLocalizedString("message1_regpatronymic");
        }
    }
}
