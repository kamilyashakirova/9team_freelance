using System.Drawing.Text;
namespace freelance.forms
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
            FontClass.SetCustomFont(this, 10);
            FontClass.SetCustomFont(reg_lbl, 18);
            FontClass.SetCustomFont(registration_btn, 18);
        }
        private void hide_picb_Click(object sender, EventArgs e)
        {
            rpassword_txtb.PasswordChar = '*';
            hide_picb.Visible = false;
            show_pic.Visible = true;
        }
        private void show_pic_Click(object sender, EventArgs e)
        {
            rpassword_txtb.PasswordChar = '\0';
            show_pic.Visible = false;
            hide_picb.Visible = true;
        }
        private void registration_btb_click(object sender, EventArgs e)
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
    }
}
