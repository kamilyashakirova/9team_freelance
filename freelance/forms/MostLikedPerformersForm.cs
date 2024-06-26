﻿using NLog;
using System.Linq;

namespace freelance.forms
{
    public partial class MostLikedPerformersForm : Form
    {
        private Guid clientID;
        private string file;
        private string like = "Нравится";

        public static Logger logger = LogManager.GetCurrentClassLogger();
        public MostLikedPerformersForm(Guid clientID, string file)
        {
            InitializeComponent();
            this.clientID = clientID;
            this.file = file;
            Localization.LanguageChanged += UpdateLocalization;

            logger.Info("Успешно открылось форма 'MostLikedPerformersForm'.");
        }
        private void liked_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var card = new PerformerCard(clientID, file);
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
                    var performer = db.Performers.Where(p => p.ID == Guid.Parse(card.ID_Card_txt.Text)).FirstOrDefault();
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
        private void MostLikedPerformersForm_Load(object sender, EventArgs e)
        {
            Localization.LoadLocalizationDictionary(this, file);
            using (var db = new DBcontext())
            {
                try
                {
                    var liked = db.LikedPerformers.ToList();
                    if (liked != null)
                    {
                        foreach (var like in liked)
                        {
                            var mostlikedperformers = db.LikedPerformers.Where(u => u.PerformerID == like.PerformerID);
                            if (mostlikedperformers != null && mostlikedperformers.Count() > 5)
                            {
                                foreach(var mostlikedperformer in mostlikedperformers)
                                {
                                    var performer = db.Performers.FirstOrDefault(u => u.ID == mostlikedperformer.PerformerID);
                                    if (performer != null)
                                    {
                                        liked_dgv.Rows.Add(performer.ID, performer.PName, performer.PSpecialization,
                                                performer.PTime, performer.PLanguage, performer.PExperience, performer.PProduct);
                                    }
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        liked_dgv.Rows.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка.");
                }
            }
        }
        //Локализация
        private void UpdateLocalization(object sender, EventArgs e)
        {
            pname_liked.HeaderText = Localization.GetLocalizedString("pname_my");
            pspecialisation_liked.HeaderText = Localization.GetLocalizedString("pspecialisation_my");
            ptime_liked.HeaderText = Localization.GetLocalizedString("ptime_my");
            planguage_liked.HeaderText = Localization.GetLocalizedString("planguage_my");
            pExperience_liked.HeaderText = Localization.GetLocalizedString("pExperience_my");
            pproduct_liked.HeaderText = Localization.GetLocalizedString("pproduct_my");
        }
        private void like_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Нравится'");
            try
            {
                workingwithDB.AddLike(clientID, Guid.Parse(liked_dgv.CurrentRow.Cells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
