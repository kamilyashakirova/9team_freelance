using System.Data;
using System.Drawing.Text;
namespace freelance.forms
{
    public partial class ListOfRecomendations : Form
    {
        public int userID;

        PrivateFontCollection fonts = new PrivateFontCollection();
        public ListOfRecomendations(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
            this.Font = new Font(fonts.Families[0], 10);
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = new Font(fonts.Families[0], 10); ;
            }
        }
        private void settings_btn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show("Настройки", settings_btn, 0, 40, 800);
        }
        private void settings_btn_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Hide((Control)sender);
        }
        private void likedlist_btn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show("Избранное", likedlist_btn, 0, 40, 800);
        }
        private void likedlist_btn_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Hide((Control)sender);
        }

        private void like_btn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show("Нравится", like_btn, 0, 60, 800);
        }

        private void like_btn_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Hide((Control)sender);
        }

        private void dislike_btn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show("Не нравится", dislike_btn, 0, 60, 800);
        }

        private void dislike_btn_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Hide((Control)sender);
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            var p = new ClientProfile(userID);
            p.Show();
        }
        private void likedlist_btn_Click(object sender, EventArgs e)
        {
            var likedperformers = new Likedperformers();
            likedperformers.Show();
        }
        private void like_btn_Click(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                var performer = db.Performers.Where(p => p.ID.ToString() == this.listofrecs_dgv.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
                if (performer != null)
                {
                    performer.PStatus = "нравится";
                    db.Performers.Update(performer);
                    db.SaveChanges();
                }
            }
        }
        private void dislike_btn_Click(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                var performer = db.Performers.Where(p => p.ID.ToString() == this.listofrecs_dgv.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
                if (performer != null)
                {
                    performer.PStatus = "не нравится";
                    db.Performers.Update(performer);
                    db.SaveChanges();
                }
            }
        }
        private void listofrecs_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var card = new PerformerCard();
            if (!(this.listofrecs_dgv.CurrentRow is null))
            {
                card.ID_Card_txt.Text = this.listofrecs_dgv.CurrentRow.Cells[0].Value.ToString();
                card.pnameCard_txt.Text = this.listofrecs_dgv.CurrentRow.Cells[1].Value.ToString();
                card.pspecializationCard_txt.Text = this.listofrecs_dgv.CurrentRow.Cells[2].Value.ToString();
                card.ptimeCard_txt.Text = this.listofrecs_dgv.CurrentRow.Cells[3].Value.ToString();
                card.ppriceCard_txt.Text = this.listofrecs_dgv.CurrentRow.Cells[4].Value.ToString();
                card.pExpipienceCard_txt.Text = this.listofrecs_dgv.CurrentRow.Cells[5].Value.ToString();
                card.pratingCard_txt.Text = this.listofrecs_dgv.CurrentRow.Cells[6].Value.ToString();
                using (var db = new DBcontext())
                {
                    var performer = db.Performers.Where(p => p.PName == card.pnameCard_txt.Text).FirstOrDefault();
                    if (performer != null)
                    {
                        Bitmap image = new Bitmap("../../../images/" + performer.PPicture);
                        card.ppictureCard_pic.Image = image;
                    }
                }
                card.Show();
            }
            else if ((this.listofrecs_dgv.CurrentRow is null))
            {
                MessageBox.Show("выберите всю строку в таблице");
            }
        }
        private void listOfRecomendations_Load(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                var performers = db.Performers.ToList();
                listofrecs_dgv.Rows.Clear();
                foreach (var performer in performers)
                {
                    listofrecs_dgv.Rows.Add(performer.ID, performer.PName, performer.PSpecialization,
                        performer.PTime, performer.PPriceofwork, performer.PExperience, performer.PRating);
                }
            }
        }
    }
}

