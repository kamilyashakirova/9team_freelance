namespace freelance.forms
{
    public partial class AddSevices : Form
    {
        private int clientID;
        private string fotofile = String.Empty;
        private string fotofilepath = String.Empty;
        private string selectedSpecialization = String.Empty;
        private string selectedExperience = String.Empty;
        private string selectedLanguage = String.Empty;
        private string selectedTime = String.Empty;
        private string selectedProduct = String.Empty;
        public AddSevices(int clientID)
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
        private void create_btn_Click(object sender, EventArgs e)
        {
            try
            {
                GetSelectedSpecialization();
                using (var db = new DBcontext())
                {
                    GetSelectedSpecialization();
                    workingwithDB.AddPerformer(clientID, name_txt.Text, selectedSpecialization, selectedTime,
                        selectedExperience, selectedLanguage, selectedProduct, fotofilepath);
                    MessageBox.Show("Вы успешно создали объявление.");
                }
            }
            catch
            {
                MessageBox.Show("Не удалось создать объявление.");
            }

        }
        private void addfoto_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fotofile = fileDialog.FileName;
                    Image userImage = Image.FromFile(fotofile);
                    string fileName = Guid.NewGuid().ToString() + ".jpg";
                    string filePath = Path.Combine("../../../images/", fileName);
                    userImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fotofilepath = fileName;
                    Bitmap image = new Bitmap(Path.GetFullPath(filePath));
                    foto_pic.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
