using NLog;
using System.Data;
using System.Drawing.Text;
using System.Net.PeerToPeer;
namespace freelance.forms
{
    public partial class PerformerCard : Form
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        PrivateFontCollection fonts = new PrivateFontCollection();
        string dislike = "Не нравится";
        string like = "Нравится";
        private string message1liked = "Вы уже добавляли фрилансера в избранное";
        private string message2liked = "Добавлен в избранное";
        private string message1 = "Ошибка.";
        private string message1disliked = "Вы уже добавляли фрилансера в скрытое";
        private string message2disliked = "Добавлен в скрытое";
        private int clientID;
        public PerformerCard(int clientID)
        {
            this.clientID = clientID;
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | 
                ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
            this.Font = new Font(fonts.Families[0], 10);
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = new Font(fonts.Families[0], 10); ;
            }

            Localization.LanguageChanged += UpdateLocalization;

            logger.Info("Успешно открыта карточка фрилансера.");
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
            tooltip.Show(dislike, like_btn, 90, 60, 800);
        }
        private void dislike_btn_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Hide((Control)sender);
        }
        private void dislike_btn_Click(object sender, EventArgs e)
        {

            logger.Info("Нажата кнопка 'Не нравится'");
            using (var db = new DBcontext())
            {
                try
                {
                    var performer = db.Performers.Where(p => p.ID.ToString() == ID_Card_txt.Text).FirstOrDefault();
                    if (performer != null)
                    {
                        if (db.DislikedPerformers.Any(u => u.PerformerID == performer.ID))
                        {
                            MessageBox.Show(message1disliked);
                        }
                        else
                        {
                            if (!db.DislikedPerformers.Any(u => u.PerformerID == performer.ID))
                            {
                                workingwithDB.AddDislike(clientID, performer.ID);
                                logger.Info("Фрилансер успешно добавлен в 'Скрытое'");
                                MessageBox.Show(message2disliked);
                            }
                            var u = db.LikedPerformers.FirstOrDefault(u => u.PerformerID == performer.ID);
                                if (u != null)
                                {
                                    db.LikedPerformers.Remove(u);
                                    logger.Info("Фрилансер успешно удалён из списка 'Избранное'");
                                    db.SaveChanges();
                                }
                                else
                                {
                                    MessageBox.Show(message1);
                                }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    logger.Error(ex.ToString());
                }
            }
        }
        private void like_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Нравится'");
            using (var db = new DBcontext())
            {
                try
                {
                    var performer = db.Performers.Where(p => p.ID.ToString() == ID_Card_txt.Text).FirstOrDefault();
                    if (performer != null)
                    {
                        if (db.LikedPerformers.Any(u => u.PerformerID == performer.ID))
                        {
                            MessageBox.Show(message1liked);
                        }
                        else
                        {
                            if (!db.LikedPerformers.Any(u => u.PerformerID == performer.ID))
                            {
                                workingwithDB.AddLike(clientID, performer.ID);
                                logger.Info("Фрилансер успешно добавлен в 'Избранное'");
                                MessageBox.Show(message2liked);
                            }
                                var u = db.DislikedPerformers.FirstOrDefault(u => u.PerformerID == performer.ID);
                                if (u != null)
                                {
                                    db.DislikedPerformers.Remove(u);
                                    logger.Info("Фрилансер успешно удалён из списка 'Скрытое'");
                                    db.SaveChanges();
                                }
                                else
                                {
                                    MessageBox.Show(message1);
                                }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    logger.Error(ex.ToString());
                }

            }
        }
        //Локализация
        private void UpdateLocalization(object sender, EventArgs e)
        {
            this.Text = Localization.GetLocalizedString("PerformerCard");
            fio_lbl.Text = Localization.GetLocalizedString("fio_lbl");
            spec_lbl.Text = Localization.GetLocalizedString("spec_lbl");
            srtime_lbl.Text = Localization.GetLocalizedString("srtime_lbl");
            srprice_lbl.Text = Localization.GetLocalizedString("srprice_lbl");
            experiense_lbl.Text = Localization.GetLocalizedString("experiense_lbl");
            rating_lbl.Text = Localization.GetLocalizedString("rating_lbl");
            like = Localization.GetLocalizedString("like");
            dislike = Localization.GetLocalizedString("dislike");

            message1 = Localization.GetLocalizedString("message1_list");
            message1liked = Localization.GetLocalizedString("message1liked_list");
            message2liked = Localization.GetLocalizedString("message2liked_list");
            message1disliked = Localization.GetLocalizedString("message1disliked_list");
            message2disliked = Localization.GetLocalizedString("message2disliked_list");
        }
    }
}
