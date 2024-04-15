using System.Drawing.Text;

namespace freelance
{
    public partial class registrationForm : Form
    {
        PrivateFontCollection fonts = new PrivateFontCollection();
        public registrationForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
            this.Font = new Font(fonts.Families[0], 10);
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = new Font(fonts.Families[0], 10); ;
            }
            reg_lbl.Font = new Font(fonts.Families[0], 18);
            registration_btn.Font = new Font(fonts.Families[0], 12);
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
            if (rpasswordrepeat_txtb.Text == rpasswordrepeat_txtb.Text)
            {
                using (var context = new DBcontext())
                {
                    context.Database.EnsureCreated();
                }
                workingwithDB.AddUserAndClient(rlogin_txtb.Text, rpassword_txtb.Text, rEmail_txtb.Text, rname_txtb.Text, rsurname_txtb.Text, rpatronomic_txtb.Text);
                MessageBox.Show("вы успешно зарегистрировались");
            }
            else 
            {
                MessageBox.Show("ошибка. проверьте правильно ли Вы повторили пароль");
            }
        }
    }
}
