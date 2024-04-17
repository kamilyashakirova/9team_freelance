using System.Data;
using System.Drawing.Text;
namespace freelance.forms
{
    public partial class Likedperformers : Form
    {
        PrivateFontCollection fonts = new PrivateFontCollection();
        public Likedperformers()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
            this.Font = new Font(fonts.Families[0], 10);
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = new Font(fonts.Families[0], 10); ;
            }
            liked_lbl.Font = new Font(fonts.Families[0],16);
        }
        private void likedperformers_Load(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                var performers = db.Performers.ToList();
                liked_dgv.Rows.Clear();
                foreach (var performer in performers)
                {
                    if (performer.PStatus == "нравится")
                    {
                        liked_dgv.Rows.Add(performer.ID ,performer.PName, performer.PSpecialization, performer.PTime,
                            performer.PPriceofwork, performer.PExperience, performer.PRating);
                    }
                }
            }
        }
        private void liked_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var card = new PerformerCard();
            if (!(this.liked_dgv.CurrentRow is null))
            {
                card.ID_Card_txt.Text = this.liked_dgv.CurrentRow.Cells[0].Value.ToString();
                card.pnameCard_txt.Text = this.liked_dgv.CurrentRow.Cells[1].Value.ToString();
                card.pspecializationCard_txt.Text = this.liked_dgv.CurrentRow.Cells[2].Value.ToString();
                card.ptimeCard_txt.Text = this.liked_dgv.CurrentRow.Cells[3].Value.ToString();
                card.ppriceCard_txt.Text = this.liked_dgv.CurrentRow.Cells[4].Value.ToString();
                card.pExpipienceCard_txt.Text = this.liked_dgv.CurrentRow.Cells[5].Value.ToString();
                card.pratingCard_txt.Text = this.liked_dgv.CurrentRow.Cells[6].Value.ToString();
                using (var db = new DBcontext())
                {
                    var performer = db.Performers.Where(p => p.PName == card.pnameCard_txt.Text).FirstOrDefault();
                    if (performer != null)
                    {
                        Bitmap image = new Bitmap("../../../images/" + performer.PPicture);
                        card.ppictureCard_pic.Image = image;
                    }
                }
                card.like_btn.Visible = false;
                card.Show();
            }
            else if ((this.liked_dgv.CurrentRow is null))
            {
                MessageBox.Show("Выберите необходимую строку в таблице.");
            }
        }
    }
}
