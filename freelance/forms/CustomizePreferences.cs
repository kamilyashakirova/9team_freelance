using NLog;
using System.Windows.Forms;

namespace freelance.forms
{
    public partial class CustomizePreferences : Form
    {
        private int clientID;
        private string selectedSpecialization = null!;
        private string selectedExperience = null!;
        private string selectedLanguage = null!;
        private string selectedTime = null!;
        private string selectedProduct = null!;

        public static Logger logger = LogManager.GetCurrentClassLogger();
        public CustomizePreferences(int clientID)
        {
            this.clientID = clientID;
            InitializeComponent();

            Localization.LanguageChanged += UpdateLocalization;

            logger.Info("Успешно открылось форма 'CustomizePreferences'.");
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
                        clientInterest.IExperience = selectedExperience;
                        clientInterest.IProduct = selectedProduct;
                        clientInterest.ILanguage = selectedLanguage;
                        clientInterest.ITime = selectedTime;
                        clientInterest.ISpecialization = selectedSpecialization;
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
                    logger.Error("Ошибка в редактировании предпочтений пользователя.");
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
            button1.Text = Localization.GetLocalizedString("button1");
            button4.Text = Localization.GetLocalizedString("button4");
            button3.Text = Localization.GetLocalizedString("button3");
            button5.Text = Localization.GetLocalizedString("button5");
            button2.Text = Localization.GetLocalizedString("button2");
            Sweb_design_check.Text = Localization.GetLocalizedString("Sweb_design_check");
            Stext_check.Text = Localization.GetLocalizedString("Stext_check");
            Sgraphic_design_check.Text = Localization.GetLocalizedString("Sgraphic_design_check");
            Sadvertisement_check.Text = Localization.GetLocalizedString("Sadvertisement_check");
            Pwebsite_check.Text = Localization.GetLocalizedString("Pwebsite_check");
            Padvertisement_check.Text = Localization.GetLocalizedString("Padvertisement_check");
            Preport_check.Text = Localization.GetLocalizedString("Preport_check");
            Ptranselate_check.Text = Localization.GetLocalizedString("Ptranselate_check");
            Plogo_check.Text = Localization.GetLocalizedString("Plogo_check");
            Leng_check.Text = Localization.GetLocalizedString("Leng_check");
            Ldeu_check.Text = Localization.GetLocalizedString("Ldeu_check");
            Lchineese_check.Text = Localization.GetLocalizedString("Lchineese_check");
            Tday_.Text = Localization.GetLocalizedString("Tday_");
            Tthreedays_check.Text = Localization.GetLocalizedString("Tthreedays_check");
            Tweek_check.Text = Localization.GetLocalizedString("Tweek_check");
            Tmonth_check.Text = Localization.GetLocalizedString("Tmonth_check");
            Enone_check.Text = Localization.GetLocalizedString("Enone_check");
            Eyear_check.Text = Localization.GetLocalizedString("Eyear_check");
            Eonethreeyears_check.Text = Localization.GetLocalizedString("Eonethreeyears_check");
            Emore_check.Text = Localization.GetLocalizedString("Emore_check");
            savechanges_btn.Text = Localization.GetLocalizedString("savechanges_btn");
        }
    }
}
