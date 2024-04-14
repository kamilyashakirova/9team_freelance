
using System.Drawing.Text;
using System.Windows.Forms;

namespace freelance
{
    public partial class Enter : Form
    {
        PrivateFontCollection fonts = new PrivateFontCollection();
    public Enter()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
            this.Font = new Font(fonts.Families[0], 12);
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = new Font(fonts.Families[0], 12); ;
            }
            login_txtb.Font = new Font(fonts.Families[0], 11);
            password_txtb.Font = new Font(fonts.Families[0],11);
            hi_lbl.Font = new Font(fonts.Families[0], 16);
            enter_btn.Font = new Font(fonts.Families[0], 11);
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
                    Close();
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
            forgotpasswordForm forgotpasswordForm = new forgotpasswordForm();
            forgotpasswordForm.Show();
        }

        private void registration_lbl_Click(object sender, EventArgs e)
        {
            registrationForm registration = new registrationForm();
            registration.Show();
        }
    }
}
