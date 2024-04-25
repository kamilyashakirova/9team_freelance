using NLog;
using System.Data;
using System.Drawing.Text;
namespace freelance.forms
{
    public partial class Likedperformers : Form
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        PrivateFontCollection fonts = new PrivateFontCollection();
        private int clientID;
        public Likedperformers(int clientID)
        {
            this.clientID = clientID;
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
            this.Font = new Font(fonts.Families[0], 10);
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = new Font(fonts.Families[0], 10); ;
            }
            liked_lbl.Font = new Font(fonts.Families[0], 16);

            Localization.LanguageChanged += UpdateLocalization;

            logger.Info("Успешно открыта форма 'Likedperformers'");
        }

        //загрузка данных из БД в таблицу
        private void likedperformers_Load(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                try
                    {
                    var liked = db.LikedPerformers.Where(u => u.ClientID == clientID);
                    if (liked != null)
                    {
                        foreach (var like in liked)
                        {
                            var performer = db.Performers.FirstOrDefault(u => u.ID == like.PerformerID);
                            if (performer != null)
                            {
                                liked_dgv.Rows.Add(performer.ID, performer.PName, performer.PSpecialization,
                                    performer.PTime, performer.PLanguage, performer.PExperience, performer.PProduct);
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка.");
                    logger.Error($"Ошибка в загрузке данных из БД для формы 'Likedperformers'.{ex.ToString}");
                }
            }
        }
        //Для карточки фрилансера
        private void liked_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var card = new PerformerCard(clientID);
            if (!(this.liked_dgv.CurrentRow is null))
            {
                card.ID_Card_txt.Text = this.liked_dgv.CurrentRow.Cells[0].Value.ToString();
                card.pnameCard_txt.Text = this.liked_dgv.CurrentRow.Cells[1].Value.ToString();
                card.pspecializationCard_txt.Text = this.liked_dgv.CurrentRow.Cells[2].Value.ToString();
                card.ptimeCard_txt.Text = this.liked_dgv.CurrentRow.Cells[3].Value.ToString();
                card.planguage_txt.Text = this.liked_dgv.CurrentRow.Cells[4].Value.ToString();
                card.pExpipienceCard_txt.Text = this.liked_dgv.CurrentRow.Cells[5].Value.ToString();
                card.pproduct_txt.Text = this.liked_dgv.CurrentRow.Cells[6].Value.ToString();
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
                card.like_btn.Visible = false;
                card.Show();
            }
            else if ((this.liked_dgv.CurrentRow is null))
            {
                MessageBox.Show("Выберите необходимую строку в таблице.");
            }
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Назад'");
            this.Close();
        }
        //Локализация
        private void UpdateLocalization(object sender, EventArgs e)
        {
            this.Text = Localization.GetLocalizedString("Likedperformers");
            liked_lbl.Text = Localization.GetLocalizedString("liked_lbl");
            pname_liked.HeaderText = Localization.GetLocalizedString("pname_my");
            pspecialisation_liked.HeaderText = Localization.GetLocalizedString("pspecialisation_my");
            ptime_liked.HeaderText = Localization.GetLocalizedString("ptime_my");
            planguage_liked.HeaderText = Localization.GetLocalizedString("planguage_my");
            pExperience_liked.HeaderText = Localization.GetLocalizedString("pExperience_my");
            pproduct_liked.HeaderText = Localization.GetLocalizedString("pproduct_my");
        }
    }
}
