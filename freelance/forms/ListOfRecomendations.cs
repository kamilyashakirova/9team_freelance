using NLog;
using System.Data;
using System.Drawing.Text;
namespace freelance.forms
{
    public partial class ListOfRecomendations : Form
    {
        public int userID;
        public static int clientID;
        ClientProfile profile = new ClientProfile(clientID, file);
        Likedperformers likedPerformers = new Likedperformers(clientID, file);
        PrivateFontCollection fonts = new PrivateFontCollection();
        PerformerCard card;
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static string file = "Localization";
        private string dislike = "�� ��������";
        private string like = "��������";
        private string liked = "���������";
        private string settings = "���������";
        private string message1liked_list = "�� ��� ��������� ���������� � ���������";
        private string message2liked_list = "�������� � ���������";
        private string message1_list = "������.";
        private string message2_list = "�������� ����������� ������ � �������.";
        private string message1disliked_list = "�� ��� ��������� ���������� � �������";
        private string message2disliked_list = "�������� � �������";
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
            Localization.LanguageChanged += UpdateLocalization;
            logger.Info("������� ��������� ����� 'ListOfRecomendations'.");
        }
        //�������� ������ �� �� � �������
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
                                + (p.PLanguage.Contains(interests.ILanguage) ? 1 : 0)
                                + (p.PSpecialization == interests.ISpecialization ? 1 : 0)
                                + (p.PProduct.Contains(interests.IProduct) ? 1 : 0))
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
            logger.Info("������ ������ '��������'.");
            listofrecs_dgv1.Rows.Clear();
            Updatelist(clientID, listofrecs_dgv1);
        }
        //��� �������� ����������
        private void listofrecs_dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            card = new PerformerCard(clientID, file);
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
                MessageBox.Show(message2_list);
            }
        }
        //������ "��������"
        private void like_btn_Click(object sender, EventArgs e)
        {
            logger.Info("������ ������ '��������'");
            using (var db = new DBcontext())
            {
                try
                {
                    var performer = db.Performers.Where(p => p.ID.ToString() == this.listofrecs_dgv1.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
                    if (performer != null)
                    {
                        if (db.LikedPerformers.Any(u => u.PerformerID == performer.ID))
                        {
                            MessageBox.Show(message1liked_list);
                        }
                        else
                        {
                            if (!db.LikedPerformers.Any(u => u.PerformerID == performer.ID))
                            {
                                workingwithDB.AddLike(clientID, performer.ID);
                                logger.Info("��������� ������� �������� � '���������'");
                                MessageBox.Show(message2liked_list);
                            }
                            var u = db.DislikedPerformers.FirstOrDefault(u => u.PerformerID == performer.ID);
                                if (u != null)
                                {
                                    db.DislikedPerformers.Remove(u);
                                    logger.Info("��������� ������� ����� �� ������ '�������'");
                                    db.SaveChanges();
                                }
                                else
                                {
                                    MessageBox.Show(message1_list);
                                }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
       //������ "�� ��������"
        private void dislike_btn_Click(object sender, EventArgs e)
        {
            logger.Info("������ ������ '�� ��������'");
            using (var db = new DBcontext())
            {
                try
                {
                    var performer = db.Performers.Where(p => p.ID.ToString() == this.listofrecs_dgv1.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
                    if (performer != null)
                    {
                        if (db.DislikedPerformers.Any(u => u.PerformerID == performer.ID))
                        {
                            MessageBox.Show(message1disliked_list);
                        }
                        else
                        {
                            if (!db.DislikedPerformers.Any(u => u.PerformerID == performer.ID))
                            {
                                workingwithDB.AddDislike(clientID, performer.ID);
                                logger.Info("��������� ������� �������� � '�������'");
                                MessageBox.Show(message2disliked_list);
                            }
                            var u = db.LikedPerformers.FirstOrDefault(u => u.PerformerID == performer.ID);
                                if (u != null)
                                {
                                    db.LikedPerformers.Remove(u);
                                    logger.Info("��������� ������� ����� �� ������ '���������'");
                                    db.SaveChanges();
                                }
                                else
                                {
                                    MessageBox.Show(message1_list);
                                }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //�����������
        private void UpdateLocalization(object sender, EventArgs e)
        {
            this.Text = Localization.GetLocalizedString("ListOfRecomendations");
            pname_list.HeaderText = Localization.GetLocalizedString("pname_list");
            pspecialisation_list.HeaderText = Localization.GetLocalizedString("pspecialisation_list");
            ptime_list.HeaderText = Localization.GetLocalizedString("ptime_list");
            planguage_list.HeaderText = Localization.GetLocalizedString("planguage_list");
            pExperience_list.HeaderText = Localization.GetLocalizedString("pExperience_list");
            pproduct_list.HeaderText = Localization.GetLocalizedString("pproduct_list");
            like = Localization.GetLocalizedString("like");
            dislike = Localization.GetLocalizedString("dislike");
            liked = Localization.GetLocalizedString("liked");
            settings = Localization.GetLocalizedString("settings");
            message1_list = Localization.GetLocalizedString("message1_list");
            message2_list = Localization.GetLocalizedString("message2_list");
            message1liked_list = Localization.GetLocalizedString("message1liked_list");
            message2liked_list = Localization.GetLocalizedString("message2liked_list");
            message1disliked_list = Localization.GetLocalizedString("message1disliked_list");
            message2disliked_list = Localization.GetLocalizedString("message2disliked_list");
        }
        private void rus_change_btn_Click(object sender, EventArgs e)
        {
            Localization.LoadLocalizationDictionary(this, "newLocalization");
            file = "newLocalization";
            profile = new ClientProfile(userID, file);
            likedPerformers = new Likedperformers(clientID, file);
            card = new PerformerCard(clientID, file);
            rus_change_btn.Visible = false;
            tat_change_btn.Visible = true;
        }
        private void tat_change_btn_Click(object sender, EventArgs e)
        {
            Localization.LoadLocalizationDictionary(this, "Localization");
            file = "Localization";
            profile = new ClientProfile(userID, file);
            likedPerformers = new Likedperformers(clientID, file);
            card = new PerformerCard(clientID, file);
            tat_change_btn.Visible = false;
            rus_change_btn.Visible = true;
        }
        //������ "���������"
        private void settings_btn_Click(object sender, EventArgs e)
        {
            profile = new ClientProfile(clientID, file);
            profile.Show();
        }
        //������ "���������"
        private void likedlist_btn_Click(object sender, EventArgs e)
        {
            likedPerformers = new Likedperformers(clientID, file);
            likedPerformers.Show();
        }
        //�������� ������ ��������������� ��� ���������
        private void settings_btn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show(settings, settings_btn, 0, 40, 800);
        }
        private void settings_btn_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Hide((Control)sender);
        }
        private void likedlist_btn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show(liked, likedlist_btn, 0, 40, 800);
        }
        private void likedlist_btn_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Hide((Control)sender);
        }
        private void like_btn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show(like, like_btn, 0, 60, 800);
        }
        private void like_btn_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Hide((Control)sender);
        }
        private void dislike_btn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show(dislike, dislike_btn, 0, 60, 800);
        }
        private void dislike_btn_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Hide((Control)sender);
        }

    }
}

