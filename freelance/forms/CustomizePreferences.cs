using NLog;
namespace freelance.forms
{
    public partial class CustomizePreferences : Form
    {
        private Guid clientID;
        private string selectedSpecialization = String.Empty;
        private string selectedExperience = String.Empty;
        private string selectedLanguage = String.Empty;
        private string selectedTime = String.Empty;
        private string selectedProduct = String.Empty;

        public static Logger logger = LogManager.GetCurrentClassLogger();
        private string file = String.Empty;
        public CustomizePreferences(Guid clientID, string file)
        {
            this.file = file;
            this.clientID = clientID;
            InitializeComponent();
            logger.Info("Успешно открылось форма 'CustomizePreferences'.");
            Localization.LanguageChanged += UpdateLocalization;
        }
        private void GetSelectedSpecialization()
        {
            if (Sweb_design_check.Checked)
                selectedSpecialization = "Веб-разработка";
            if (Sgraphic_design_check.Checked)
                selectedSpecialization = "Графический дизайн";
            if (Stext_check.Checked)
                selectedSpecialization = "Копирайтинг";
            if (Sadvertisement_check.Checked)
                selectedSpecialization = "Интернет продвижение и реклама";
            if (Pwebsite_check.Checked)
                selectedProduct += ";Сайт";
            if (Padvertisement_check.Checked)
                selectedProduct += ";Реклама";
            if (Preport_check.Checked)
                selectedProduct += ";Статья";
            if (Ptranselate_check.Checked)
                selectedProduct += ";Перевод";
            if (Plogo_check.Checked)
                selectedProduct += ";Дизайн логотипа";
            if (Leng_check.Checked)
            {
                if (selectedLanguage != null)
                {
                    selectedLanguage += ";Английский";
                }
                else
                {
                    selectedLanguage = "Английский";
                }
            }
            if (Ldeu_check.Checked)
            {
                if (selectedLanguage != null)
                {
                    selectedLanguage += ";Немецкий";
                }
                else
                {
                    selectedLanguage = "Немецкий";
                }
            }
            if (Lchineese_check.Checked)
            {
                if (selectedLanguage != null)
                {
                    selectedLanguage += ";Китайский";
                }
                else
                {
                    selectedLanguage = "Китайский";
                }
            }
            if (Tday_.Checked)
                selectedTime = "1 день";
            if (Tthreedays_check.Checked)
                selectedTime = "до 3х дней";
            if (Tweek_check.Checked)
                selectedTime = "До недели";
            if (Tmonth_check.Checked)
                selectedTime = "До месяца";
            if (Eonethreeyears_check.Checked)
                selectedExperience = "1-3 года";
            if (Eyear_check.Checked)
                selectedExperience = "До 1 года";
            if (Emore_check.Checked)
                selectedExperience = "От 3х лет";
            if (Enone_check.Checked)
                selectedExperience = "Без опыта";
        }
        private void savechanges_btn_Click(object sender, EventArgs e)
        {
            using (var db = new DBcontext())
            {
                try
                {
                    if (db.Interests.Any(u => u.ClientID == clientID))
                    {
                        GetSelectedSpecialization();
                        var clientInterest = db.Interests.FirstOrDefault(u => u.ClientID == clientID);
                        clientInterest.InterestExperience = selectedExperience;
                        clientInterest.InterestProduct = selectedProduct;
                        clientInterest.InterestLanguage = selectedLanguage;
                        clientInterest.InterestTime = selectedTime;
                        clientInterest.InterestSpecialization = selectedSpecialization;
                        db.SaveChanges();
                        MessageBox.Show("Ваши предпочтения успешно изменены");
                        logger.Info("Успешно изменились предпочтения пользователя.");
                    }
                    else
                    {
                        var client = db.Clients.FirstOrDefault(u => u.ID == clientID);
                        if (client != null)
                        {
                            workingwithDB.AddInterest(clientID, selectedSpecialization, selectedExperience, selectedTime,
                                selectedLanguage, selectedProduct);
                            MessageBox.Show("Ваши предпочтения успешно изменены");
                            logger.Info("Успешно изменились предпочтения пользователя.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    logger.Error($"Ошибка в редактировании предпочтений пользователя.{ex.ToString}");
                }
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
            this.Text = Localization.GetLocalizedString("CustomizePreferences");
        }
        private void CustomizePreferences_Load(object sender, EventArgs e)
        {
            Localization.LoadLocalizationDictionary(this, file);
        }
    }
}
