﻿using System.Data;
using System.Drawing.Text;
namespace freelance.forms
{
    public partial class Dislikedperformers : Form
    {
        PrivateFontCollection fonts = new PrivateFontCollection();
        public Dislikedperformers()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
            this.Font = new Font(fonts.Families[0], 10);
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = new Font(fonts.Families[0], 10); ;
            }
            disliked_lbl.Font = new Font(fonts.Families[0], 16);
        }
        private void disliked_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var card = new PerformerCard();
            if (!(this.disliked_dgv.CurrentRow is null))
            {

                card.ID_Card_txt.Text = this.disliked_dgv.CurrentRow.Cells[0].Value.ToString();
                card.pnameCard_txt.Text = this.disliked_dgv.CurrentRow.Cells[1].Value.ToString();
                card.pspecializationCard_txt.Text = this.disliked_dgv.CurrentRow.Cells[2].Value.ToString();
                card.ptimeCard_txt.Text = this.disliked_dgv.CurrentRow.Cells[3].Value.ToString();
                card.ppriceCard_txt.Text = this.disliked_dgv.CurrentRow.Cells[4].Value.ToString();
                card.pExpipienceCard_txt.Text = this.disliked_dgv.CurrentRow.Cells[5].Value.ToString();
                card.pratingCard_txt.Text = this.disliked_dgv.CurrentRow.Cells[6].Value.ToString();
                using (var db = new DBcontext())
                {
                    var performer = db.Performers.Where(p => p.PName == card.pnameCard_txt.Text).FirstOrDefault();
                    if (performer != null)
                    {
                        Bitmap image = new Bitmap("../../../images/" + performer.PPicture);
                        card.ppictureCard_pic.Image = image;
                    }
                }
                card.dislike_btn.Visible = false;
                card.Show();
            }
            else if ((this.disliked_dgv.CurrentRow is null))
            {
                MessageBox.Show("Нажмите необходимую строку в таблице.");
            }
        }

        private void Dislikedperformers_Load_1(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                var disliked = db.DislikedPerformers.ToList();
                foreach (var dislike in disliked)
                {
                    var performer = db.Performers.FirstOrDefault(u => u.ID == dislike.PerformerID);
                    if (performer != null)
                    {
                        disliked_dgv.Rows.Add(performer.ID, performer.PName, performer.PSpecialization,
                            performer.PTime, performer.PPriceofwork, performer.PExperience, performer.PRating);
                    }
                }
            }
        }
    }
}
