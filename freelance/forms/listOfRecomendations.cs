
using System.Data;
namespace freelance.forms
{
    public partial class ListOfRecomendations : Form
    {
        ClientProfile p = new ClientProfile();
        public ListOfRecomendations(int userID)
        {
            InitializeComponent();
            var client = workingwithDB.clientsloaddata(userID);
            if (client != null)
            {
                p.id_txt.Text = client[0];
                p.cname_txt.Text = client[1];
                p.csurname_txt.Text = client[2];
                p.cpatronymic_txt.Text = client[3];
                p.cemail_txt.Text = client[4];
                if (client[5] != null)
                {
                    Bitmap image = new Bitmap(client[5]);
                    p.clientpicture.Image = image;
                }
            }
            FontClass.SetCustomFont(this, 10);
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
            p.Show();
        }
        private void likedlist_btn_Click(object sender, EventArgs e)
        {
            var likedperformers = new Likedperformers();
            likedperformers.Show();
        }
        private void like_btn_Click(object sender, EventArgs e)
        {
            if (listofrecs_dgv.SelectedRows.Count > 0)
            {
                var performer = listofrecs_dgv.SelectedRows[0].DataBoundItem as Performer;

                if (performer != null)
                {
                    performer.PStatus = "нравится";
                }
            }
        }
        private void dislike_btn_Click(object sender, EventArgs e)
        {
            if (listofrecs_dgv.SelectedRows.Count > 0)
            {
                var performer = listofrecs_dgv.SelectedRows[0].DataBoundItem as Performer;

                if (performer != null)
                {
                    performer.PStatus = "не нравится";
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

