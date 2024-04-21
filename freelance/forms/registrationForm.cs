namespace freelance.forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            FontClass.SetCustomFont(this, 10);
            FontClass.SetCustomFont(reg_lbl, 18);
            FontClass.SetCustomFont(registration_btn, 18);
        }
        private void show_pic_Click(object sender, EventArgs e)
        {
            show_pic.Visible = true;
            rpassword_txtb.PasswordChar = '\0';
            show_pic.Visible = false;
            hide_picb.Visible = true;
        }
        private void hide_picb_Click(object sender, EventArgs e)
        {           
            hide_picb.Visible = true;
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
                    MessageBox.Show("Вы успешно зарегистрировались.");
                }
                else
                {
                    MessageBox.Show("Ошибка. Проверьте, правильно ли Вы повторили пароль.");
                }
            }
            else
            {
                MessageBox.Show("Заполните поле для почты");
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rsurname_txtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rname_txtb.Text))
            {
                MessageBox.Show("Поле имени не должно быть пустым.");
            }
            if (rname_txtb.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Имя не должно содержать цифры.");
            }
        }

        private void rpatronomic_txtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rsurname_txtb.Text))
            {
                MessageBox.Show("Поле фамилии не должно быть пустым.");
            }
            if (rsurname_txtb.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Фамилия не должна содержать цифры.");
            }
        }
        private void rlogin_txtb_TextChanged(object sender, EventArgs e)
        {
            if (rpatronomic_txtb.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Отчество не должно содержать цифры.");
            }
        }
    }
}
