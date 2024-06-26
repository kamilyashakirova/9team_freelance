using NLog;
using System.Data;
using System.Drawing.Text;
using System.Net.Mail;
using System.Net;
using System.Text;
namespace freelance.forms
{
    public partial class ListOfRecomendations : Form
    {
        private Guid userID;
        private Guid clientID;
        private ClientProfile? profile;
        private Likedperformers? likedPerformers;
        private PrivateFontCollection fonts = new PrivateFontCollection();
        private PerformerCard? card;
        private MostLikedPerformersForm? mostLikedPerformersForm;
        public static Logger logger = LogManager.GetCurrentClassLogger();
        private string file;

        private string dislike = "Не нравится";
        private string like = "Нравится";
        private string liked = "Избранное";
        private string settings = "Настройки";
        private string message2_list = "Выберите необходимую строку в таблице.";
        public ListOfRecomendations(Guid userID, string loc)
        {
            InitializeComponent();
            file = loc;
            this.userID = userID;
            using (var db = new DBcontext())
            {
                var client = db.Clients.FirstOrDefault(u => u.UserID == userID);
                if (client != null)
                {
                    clientID = client.ID;
                }
            }
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw 
                | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
            this.Font = new Font(fonts.Families[0], 10);
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = new Font(fonts.Families[0], 10); ;
            }
            Localization.LanguageChanged += UpdateLocalization;

            logger.Info("Успешно открылось форма 'ListOfRecomendations'.");
        }
        private string GetUserEmail(Guid userId)
        {
            using (var context = new DBcontext())
            {
                var client = context.Clients.FirstOrDefault(c => c.UserID == userId);
                return client.Email;
            }
        }
        private void SendEmailWith(string userEmail, DataGridView dataGridView)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.mail.ru");
            mail.From = new MailAddress("9teamfreelance@mail.ru", "freelance");
            mail.To.Add(userEmail);
            mail.Subject = "Список рекомендаций";
            mail.Body = "Список рекомендаций находится в прикрепленном файле";
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                for (int column = 1; column < dataGridView.Columns.Count; column++)
                {
                    sb.Append(row.Cells[column].Value.ToString() + " | ");
                }
                sb.Append("\n");
            }
            mail.Attachments.Add(new Attachment(new MemoryStream(Encoding.UTF8.GetBytes(sb.ToString())), "ListOfRecomendations.txt"));
            smtpServer.Port = 587;
            smtpServer.Credentials = new NetworkCredential("9teamfreelance@mail.ru", "BrbJHbFfsjS7SeGG8pNq");
            smtpServer.EnableSsl = true;
            try
            {
                smtpServer.Send(mail);
                logger.Info("Письмо было успешно отправлено пользователю на почту.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
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
        private void settings_btn_Click(object sender, EventArgs e)
        {
            profile = new ClientProfile(clientID, file);
            profile.Show();
        }
        private void likedlist_btn_Click(object sender, EventArgs e)
        {
            likedPerformers = new Likedperformers(clientID, file);
            likedPerformers.Show();
        }
        private void like_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Нравится'");
            try
            {
                workingwithDB.AddLike(clientID, Guid.Parse(listofrecs_dgv1.CurrentRow.Cells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dislike_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Не нравится'");
            using (var db = new DBcontext())
            {
                try
                {
                    workingwithDB.AddDislike(clientID, Guid.Parse(listofrecs_dgv1.CurrentRow.Cells[0].Value.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void listofrecs_dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            card = new PerformerCard(clientID, file);
            if (!(this.listofrecs_dgv1.CurrentRow.Cells[0] is null))
            {
                using (var db = new DBcontext())
                {
                    var performer = db.Performers.FirstOrDefault(p => p.ID == Guid.Parse(this.listofrecs_dgv1.CurrentRow.Cells[0].Value.ToString()));
                    if (performer != null)
                    {
                        card.ID_Card_txt.Text = performer.ID.ToString();
                        card.pnameCard_txt.Text = performer.PName;
                        card.pspecializationCard_txt.Text = performer.PSpecialization;
                        card.ptimeCard_txt.Text = performer.PTime;
                        card.planguage_txt.Text = performer.PLanguage;
                        card.pExpipienceCard_txt.Text = performer.PExperience;
                        card.pproduct_txt.Text = performer.PProduct;
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
            else
            {
                MessageBox.Show(message2_list);
            }
        }
        private void listOfRecomendations_Load(object sender, EventArgs e)
        {
            Localization.LoadLocalizationDictionary(this, file);
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
        public static void Updatelist(Guid clientID, DataGridView list)
        {
            using (var db = new DBcontext())
            {
                Showperformers(list);
                var interests = db.Interests.Where(u => u.ClientID == clientID);
                if (interests != null)
                {
                    foreach (var interest in interests)
                    {
                        if (interest.InterestExperience == String.Empty && interest.InterestSpecialization == String.Empty 
                            && interest.InterestTime == String.Empty && interest.InterestLanguage == String.Empty
                            && interest.InterestProduct == String.Empty)
                        {
                            list.Rows.Clear();
                            Showperformers(list);
                        }
                        else
                        {
                            list.Rows.Clear();
                            var performers = db.Performers.Where(p => p.PSpecialization == interest.InterestSpecialization |
                            p.PExperience == interest.InterestExperience |
                            p.PLanguage == interest.InterestLanguage |
                            p.PProduct == interest.InterestProduct | p.PTime == interest.InterestTime)
                            .OrderByDescending(p => (p.PSpecialization == interest.InterestSpecialization ? 1 : 0)
                                + (p.PTime == interest.InterestExperience ? 1 : 0)
                                + (p.PLanguage == interest.InterestLanguage ? 1 : 0)
                                + (p.PSpecialization == interest.InterestSpecialization ? 1 : 0)
                                + (p.PProduct == interest.InterestProduct ? 1 : 0))
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
        //Локализация
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
            message2_list = Localization.GetLocalizedString("message2_list");
        }
        private void rus_change_btn_Click(object sender, EventArgs e)
        {
            file = "newLocalization";
            Localization.LoadLocalizationDictionary(this, file);
            profile = new ClientProfile(clientID, file);
            likedPerformers = new Likedperformers(clientID, file);
            card = new PerformerCard(clientID, file);
            rus_change_btn.Visible = false;
            tat_change_btn.Visible = true;
        }

        private void tat_change_btn_Click(object sender, EventArgs e)
        {
            file = "Localization";
            Localization.LoadLocalizationDictionary(this, file);
            profile = new ClientProfile(userID, file);
            likedPerformers = new Likedperformers(clientID, file);
            card = new PerformerCard(clientID, file);
            tat_change_btn.Visible = false;
            rus_change_btn.Visible = true;
        }
        //Отправка письма на почту
        private void sendmessage_Click_1(object sender, EventArgs e)
        {
            string userEmail = GetUserEmail(userID);
            if (userEmail != null)
            {
                SendEmailWith(userEmail, listofrecs_dgv1); 
                MessageBox.Show("Письмо отправлено");
            }
            else
            {
                MessageBox.Show("Не получилось отправить письмо на почту.\r\n" +
                    "Возможно, не заполнено поле,где указана Ваша почта.\r\n" +
                    "Личную информацию можно редактировать в профиле");
            }
        }
       //Общая подборка
        private void mostLikedPerformers_pic_Click_1(object sender, EventArgs e)
        {
            mostLikedPerformersForm = new MostLikedPerformersForm(clientID, file);
            mostLikedPerformersForm.Show();
        }
    }
}

