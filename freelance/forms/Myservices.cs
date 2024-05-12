using NLog;
using System.Data;
namespace freelance.forms
{
    public partial class Myservices : Form
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        private Guid clientID;
        private string message_my = "У Вас пока нет своих объявлений";
        private string file = String.Empty;
        private PerformerCard? card;
        public Myservices(Guid clientID, string file)
        {
            this.clientID = clientID;
            InitializeComponent();
            Localization.LanguageChanged += UpdateLocalization;
            logger.Info("Успешно открыта форма 'Myservices'");
            this.file = file;
        }
        private void Myservices_Load(object sender, EventArgs e)
        {
            Localization.LoadLocalizationDictionary(this, file);
            Update(clientID, myservices_dgv);
        }
        private void Update(Guid clientID, DataGridView mylist)
        {
            using (var db = new DBcontext())
            {
                if (db.Performers.Any(u => u.ClientID == clientID))
                {
                    var performers = db.Performers.Where(u => u.ClientID == clientID);
                    foreach (var performer in performers)
                    {
                        mylist.Rows.Add(performer.ID, performer.PName, performer.PSpecialization,
                                            performer.PTime, performer.PLanguage, performer.PExperience, performer.PProduct);
                    }
                }
                else
                {
                    MessageBox.Show(message_my);
                    mylist.Rows.Clear();
                }
            }
        }
        private void addservice_btn_Click(object sender, EventArgs e)
        {
            var add = new AddSevices(clientID, file);
            add.Show();
        }

        private void myservices_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            card = new PerformerCard(clientID, file);
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
                card.Show();
            }
        }

        private void updatedgv_pic_Click(object sender, EventArgs e)
        {
            myservices_dgv.Rows.Clear();
            Update(clientID, myservices_dgv);
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Назад'");
            this.Close();
        }
        //Локализация
        private void UpdateLocalization(object sender, EventArgs e)
        {
            this.Text = Localization.GetLocalizedString("Myservices");
            pname_my.HeaderText = Localization.GetLocalizedString("pname_my");
            pspecialisation_my.HeaderText = Localization.GetLocalizedString("pspecialisation_my");
            ptime_my.HeaderText = Localization.GetLocalizedString("ptime_my");
            planguage_my.HeaderText = Localization.GetLocalizedString("planguage_my");
            pExperience_my.HeaderText = Localization.GetLocalizedString("pExperience_my");
            pproduct_my.HeaderText = Localization.GetLocalizedString("pproduct_my");
            message_my = Localization.GetLocalizedString("message_my");
        }
    }
}
