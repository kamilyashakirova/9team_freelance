using System.Drawing.Text;
namespace freelance.forms
{
    public partial class Enter : Form
    {
        PrivateFontCollection fonts = new PrivateFontCollection();
    public Enter()
        {
            fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
            InitializeComponent();
            FontClass.SetCustomFont(this, 12);
            FontClass.SetCustomFont(login_txtb, 11);
            FontClass.SetCustomFont(password_txtb, 11);
            FontClass.SetCustomFont(hi_lbl, 18);
            FontClass.SetCustomFont(enter_btn, 11);
            forgotpassword_lbl.Font = new Font(fonts.Families[0], 12, FontStyle.Underline);
        }
        private void hide_picb_Click(object sender, EventArgs e)
        {
            password_txtb.PasswordChar = '*';
            password_txtb.Font = new Font(fonts.Families[0], 11);
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
                    this.Close();
                }
                entererror_lbl.Text = "неверный логин или пароль";
            }
        }

        private void show_pic_Click(object sender, EventArgs e)
        {
            password_txtb.PasswordChar = '\0';
            password_txtb.Font = new Font(fonts.Families[0], 11);
            hide_picb.Visible = true;
            show_pic.Visible = false;
        }

        private void forgotpassword_lbl_Click(object sender, EventArgs e)
        {
            var forgotpasswordForm = new forgotpasswordForm();
            forgotpasswordForm.Show();
        }

        private void registration_lbl_Click(object sender, EventArgs e)
        {
            var registration = new registrationForm();
            registration.Show();
        }
    }
}
