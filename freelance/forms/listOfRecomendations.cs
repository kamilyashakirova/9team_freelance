using System.Data;
using System.Drawing.Text;
namespace freelance.forms
{
    public partial class ListOfRecomendations : Form
    {
        public int userID;
        public int clientID;
        PrivateFontCollection fonts = new PrivateFontCollection();
        public ListOfRecomendations(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            var client = workingwithDB.clientsloaddata(userID);
            if (client != null)
            {
                clientID = int.Parse(client[0]);
            }
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
            var likedperformers = new Likedperformers(clientID);
            likedperformers.Show();
        }
        private void like_btn_Click(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                try
                {
                    var performer = db.Performers.Where(p => p.ID.ToString() == this.listofrecs_dgv1.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
                    if (performer != null)
                    {
                        if (db.LikedPerformers.Any(u => u.PerformerID == performer.ID))
                        {
                            MessageBox.Show("Вы уже добавляли фрилансера в избранное");
                        }
                        else
                        {
                            if (!db.LikedPerformers.Any(u => u.PerformerID == performer.ID)) ;
                            {
                                workingwithDB.AddLike(clientID, performer.ID);
                                MessageBox.Show("Добавлен в избранное");
                            }
                            if (db.DislikedPerformers.Any(u => u.PerformerID == performer.ID))
                            {
                                var u = db.DislikedPerformers.FirstOrDefault(u => u.PerformerID == performer.ID);
                                if (u != null)
                                {
                                    db.DislikedPerformers.Remove(u);
                                    db.SaveChanges();
                                }
                                else
                                {
                                    MessageBox.Show("Ошибка.");
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void dislike_btn_Click(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                try
                {
                    var performer = db.Performers.Where(p => p.ID.ToString() == this.listofrecs_dgv1.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
                    if (performer != null)
                    {
                        if (db.DislikedPerformers.Any(u => u.PerformerID == performer.ID))
                        {
                            MessageBox.Show("Вы уже добавляли фрилансера в скрытое");
                        }
                        else
                        {
                            if (!db.DislikedPerformers.Any(u => u.PerformerID == performer.ID)) ;
                            {
                                workingwithDB.AddDislike(clientID, performer.ID);
                                MessageBox.Show("Добавлен в скрытое");
                            }
                            if (db.LikedPerformers.Any(u => u.PerformerID == performer.ID))
                            {
                                var u = db.LikedPerformers.FirstOrDefault(u => u.PerformerID == performer.ID);
                                if (u != null)
                                {
                                    db.LikedPerformers.Remove(u);
                                    db.SaveChanges();
                                }
                                else
                                {
                                    MessageBox.Show("Ошибка.");
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void listofrecs_dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var card = new PerformerCard(clientID);
            if (!(this.listofrecs_dgv1.CurrentRow is null))
            {
                card.ID_Card_txt.Text = this.listofrecs_dgv1.CurrentRow.Cells[0].Value.ToString();
                card.pnameCard_txt.Text = this.listofrecs_dgv1.CurrentRow.Cells[1].Value.ToString();
                card.pspecializationCard_txt.Text = this.listofrecs_dgv1.CurrentRow.Cells[2].Value.ToString();
                card.ptimeCard_txt.Text = this.listofrecs_dgv1.CurrentRow.Cells[3].Value.ToString();
                card.planguage_txt.Text = this.listofrecs_dgv1.CurrentRow.Cells[4].Value.ToString();
                card.pExpipienceCard_txt.Text = this.listofrecs_dgv1.CurrentRow.Cells[5].Value.ToString();
                card.pproduct_txt.Text = this.listofrecs_dgv1.CurrentRow.Cells[6].Value.ToString();
                using (var db = new DBcontext())
                {
                    var performer = db.Performers.Where(p => p.ID == int.Parse(card.ID_Card_txt.Text)).FirstOrDefault();
                    if (performer != null)
                    {
                        if (performer.PPicture != String.Empty)
                        {
                            Bitmap image = new Bitmap("../../../images/" + performer.PPicture);
                            card.ppictureCard_pic.Image = image;
                        }
                        else
                        {
                            card.ppictureCard_pic.Image = null;
                        }
                    }
                }
                card.Show();
            }
            else if ((this.listofrecs_dgv1.CurrentRow is null))
            {
                MessageBox.Show("Выберите всю строку в таблице");
            }
        }
        private void listOfRecomendations_Load(object sender, EventArgs e)
        {
            Updatelist(clientID, listofrecs_dgv1);
        }
        public static void Showperformers(DataGridView list)
        {
            using (var db = new DBcontext())
            {
                var performers = db.Performers.ToList();
                foreach (var performer in performers)
                {
                    list.Rows.Add(performer.ID, performer.PName, performer.PSpecialization,
                        performer.PTime, performer.PLanguage, performer.PExperience, performer.PProduct);
                }
            }
        }
        public static void Updatelist(int clientID, DataGridView list)
        {
            using (var db = new DBcontext())
            {
                Showperformers(list);
                var interestss = db.Interests.Where(u => u.ClientID == clientID);
                if (interestss != null)
                {
                    foreach (var interests in interestss)
                    {
                        if (interests.IExperience == String.Empty && interests.ISpecialization == String.Empty && interests.ITime == String.Empty && interests.ILanguage == String.Empty && interests.IProduct == String.Empty)
                        {
                            list.Rows.Clear();
                            Showperformers(list);
                        }
                        else
                        {
                            list.Rows.Clear();
                            var performers = db.Performers.Where(p => p.PSpecialization == interests.ISpecialization |
                            p.PExperience == interests.IExperience |
                            p.PLanguage == interests.ILanguage |
                            p.PProduct == interests.IProduct | p.PTime == interests.ITime)
                            .OrderByDescending(p => (p.PSpecialization == interests.ISpecialization ? 1 : 0)
                                + (p.PTime == interests.IExperience ? 1 : 0)
                                + (p.PLanguage == interests.ILanguage ? 1 : 0)
                                + (p.PSpecialization == interests.ISpecialization ? 1 : 0)
                                + (p.PProduct == interests.IProduct ? 1 : 0))
                                .ToList();
                            if (performers != null)
                            {
                                foreach (var performer in performers)
                                {
                                    list.Rows.Add(performer.ID, performer.PName, performer.PSpecialization,
                                    performer.PTime, performer.PLanguage, performer.PExperience, performer.PProduct);
                                }
                            }
                        }
                    }
                }

            }
        }
        private void updatedgv_pic_Click(object sender, EventArgs e)
        {
            listofrecs_dgv1.Rows.Clear();
            Updatelist(clientID, listofrecs_dgv1);
        }
    }
}

