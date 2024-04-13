
using System.Drawing.Text;

namespace freelance
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void hide_picb_Click(object sender, EventArgs e)
        {
            password_txtb.PasswordChar = '*';
            hide_picb.Visible = false;
            show_pic.Visible = true;
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            if ((password_txtb.Text != String.Empty))
            {
                var enter = workingwithDB.LogIn(login_txtb.Text, password_txtb.Text);
                if (enter)
                {
                    MessageBox.Show("вы успешно вошли");
                    Close();
                }
                entererror_lbl.Text = "неверный логин или пароль";
            }
        }

        private void show_pic_Click(object sender, EventArgs e)
        {
            password_txtb.PasswordChar = '\0';
            hide_picb.Visible = true;
            show_pic.Visible = false;
        }

        private void forgotpassword_lbl_Click(object sender, EventArgs e)
        {
            forgotpasswordForm forgotpasswordForm = new forgotpasswordForm();
            forgotpasswordForm.Show();
        }

        private void registration_lbl_Click(object sender, EventArgs e)
        {
            registrationForm registration = new registrationForm();
            registration.Show();
        }

        private void login_txtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
