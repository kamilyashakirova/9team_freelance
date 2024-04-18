using System.Data;
using System.Drawing.Text;
using System.Net.PeerToPeer;
namespace freelance.forms
{
    public partial class PerformerCard : Form
    {
        PrivateFontCollection fonts = new PrivateFontCollection();
        public PerformerCard()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | 
                ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
            this.Font = new Font(fonts.Families[0], 10);
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = new Font(fonts.Families[0], 10); ;
            }
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
            tooltip.Show("Не нравится", like_btn, 0, 60, 800);
        }
        private void dislike_btn_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Hide((Control)sender);
        }
        private void dislike_btn_Click(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                var performer = db.Performers.Where(p => p.ID.ToString() == ID_Card_txt.Text).FirstOrDefault();
                if (performer != null)
                {
                    performer.PStatus = "не нравится";
                    db.Performers.Update(performer);
                    db.SaveChanges();
                }
            }
        }
        private void like_btn_Click(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                var performer = db.Performers.Where(p => p.ID.ToString() == ID_Card_txt.Text).FirstOrDefault();
                if (performer != null)
                {
                    performer.PStatus = "нравится";
                    db.Performers.Update(performer);
                    db.SaveChanges();
                }
            }
        }
    }
}
