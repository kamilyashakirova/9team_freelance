﻿using NLog;
using System.Data;
using System.Drawing.Text;
namespace freelance.forms
{
    public partial class Dislikedperformers : Form
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        PrivateFontCollection fonts = new PrivateFontCollection();
        private int clientID;
        public Dislikedperformers(int clientID)
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
            disliked_lbl.Font = new Font(fonts.Families[0], 16);
            this.clientID = clientID;

            Localization.LanguageChanged += UpdateLocalization;

            logger.Info("Успешно открыта форма 'Dislikedperformers'");
        }

        //загрузка данных из БД в таблицу
        private void Dislikedperformers_Load_1(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                var disliked = db.DislikedPerformers.Where(u => u.ClientID == clientID);
                if (disliked != null)
                {
                    foreach (var dis in disliked)
                    {
                        var performer = db.Performers.FirstOrDefault(u => u.ID == dis.PerformerID);
                        if (performer != null)
                        {
                            disliked_dgv.Rows.Add(performer.ID, performer.PName, performer.PSpecialization,
                                performer.PTime, performer.PLanguage, performer.PExperience, performer.PProduct);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка.");
                    logger.Error("Ошибка в загрузке данных из БД для формы 'Dislikedperformers'.");
                }
            }
        }

        //Для карточки фрилансера
        private void disliked_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var card = new PerformerCard(clientID);
            if (!(this.disliked_dgv.CurrentRow is null))
            {

                card.ID_Card_txt.Text = this.disliked_dgv.CurrentRow.Cells[0].Value.ToString();
                card.pnameCard_txt.Text = this.disliked_dgv.CurrentRow.Cells[1].Value.ToString();
                card.pspecializationCard_txt.Text = this.disliked_dgv.CurrentRow.Cells[2].Value.ToString();
                card.ptimeCard_txt.Text = this.disliked_dgv.CurrentRow.Cells[3].Value.ToString();
                card.planguage_txt.Text = this.disliked_dgv.CurrentRow.Cells[4].Value.ToString();
                card.pExpipienceCard_txt.Text = this.disliked_dgv.CurrentRow.Cells[5].Value.ToString();
                card.pproduct_txt.Text = this.disliked_dgv.CurrentRow.Cells[6].Value.ToString();
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
                card.dislike_btn.Visible = false;
                card.Show();
            }
            else if ((this.disliked_dgv.CurrentRow is null))
            {
                MessageBox.Show("Нажмите необходимую строку в таблице.");
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
            this.Text = Localization.GetLocalizedString("Dislikedperformers");
            pname_disliked.HeaderText = Localization.GetLocalizedString("pname_my");
            pspecialisation_disliked.HeaderText = Localization.GetLocalizedString("pspecialisation_my");
            ptime_disliked.HeaderText = Localization.GetLocalizedString("ptime_my");
            planguage_disliked.HeaderText = Localization.GetLocalizedString("planguage_my");
            pExperience_disliked.HeaderText = Localization.GetLocalizedString("pExperience_my");
            pproduct_disliked.HeaderText = Localization.GetLocalizedString("pproduct_my");
            disliked_lbl.Text = Localization.GetLocalizedString("disliked_lbl");
        }
    }
}

