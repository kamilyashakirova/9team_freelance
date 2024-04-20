﻿using System.Data;
namespace freelance.forms
{
    public partial class Myservices : Form
    {
        private int clientID;
        public Myservices(int clientID)
        {
            this.clientID = clientID;
            InitializeComponent();
        }
        private void Myservices_Load(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                if (db.Performers.Any(u => u.ClientID == clientID))
                {
                    var performers = db.Performers.Where(u => u.ClientID == clientID);
                    foreach (var performer in performers)
                    {
                        myservices_dgv.Rows.Add(performer.ID, performer.PName, performer.PSpecialization,
                                            performer.PTime, performer.PLanguage, performer.PExperience, performer.PProduct);
                    }
                }
                else
                {
                    MessageBox.Show("У Вас пока нет своих объявлений");
                    myservices_dgv.Rows.Clear();
                }
            }
        }

        private void addservice_btn_Click(object sender, EventArgs e)
        {
            var add = new AddSevices(clientID);
            add.Show();
        }

        private void myservices_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var card = new PerformerCard(clientID);
            if (!(this.myservices_dgv.CurrentRow is null))
            {
                card.ID_Card_txt.Text = this.myservices_dgv.CurrentRow.Cells[0].Value.ToString();
                card.pnameCard_txt.Text = this.myservices_dgv.CurrentRow.Cells[1].Value.ToString();
                card.pspecializationCard_txt.Text = this.myservices_dgv.CurrentRow.Cells[2].Value.ToString();
                card.ptimeCard_txt.Text = this.myservices_dgv.CurrentRow.Cells[3].Value.ToString();
                card.planguage_txt.Text = this.myservices_dgv.CurrentRow.Cells[4].Value.ToString();
                card.pExpipienceCard_txt.Text = this.myservices_dgv.CurrentRow.Cells[5].Value.ToString();
                card.pproduct_txt.Text = this.myservices_dgv.CurrentRow.Cells[6].Value.ToString();
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
        }
    }
}
