namespace freelance.forms
{
    public partial class CustomizePreferences : Form
    {
        private int clientID;
        private string selectedSpecialization = String.Empty;
        private string selectedExperience = String.Empty;
        private string selectedLanguage = String.Empty;
        private string selectedTime = String.Empty;
        private string selectedProduct = String.Empty;
        public CustomizePreferences(int clientID)
        {
            this.clientID = clientID;
            InitializeComponent();
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
                selectedProduct = "Сайт";
            if (Padvertisement_check.Checked)
                selectedProduct = "Реклама";
            if (Preport_check.Checked)
                selectedProduct = "Статья";
            if (Ptranselate_check.Checked)
                selectedProduct = "Перевод";
            if (Plogo_check.Checked)
                selectedProduct = "Дизайн логотипа";
            if (Leng_check.Checked)
                selectedLanguage = "Английский";
            if (Ldeu_check.Checked)
                selectedLanguage = "Немецкий";
            if (Lchineese_check.Checked)
                selectedLanguage = "Китайский";
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
                }
                else
                {
                    var client = db.Clients.FirstOrDefault(u => u.ID == clientID);
                    if (client != null)
                    {
                        workingwithDB.AddInterest(clientID, selectedSpecialization, selectedExperience, selectedTime,
                            selectedLanguage, selectedProduct);
                    }
                }
            }
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
