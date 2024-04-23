﻿namespace freelance.forms
{
    public partial class ClientProfile : Form
    {
        private string selectedFile = String.Empty;
        private int clientID;
        public ClientProfile(int userID)
        {
            InitializeComponent();
            AddInfo(userID);

            Localization.LanguageChanged += UpdateLocalization;
        }
        //Загрузка данных о клиенте
        private void AddInfo(int userID) 
        {
            var client = workingwithDB.clientsloaddata(userID);
            if (client != null)
            {
                clientID = int.Parse(client[0]);
                id_txt.Text = client[0];
                cname_txt.Text = client[1];
                csurname_txt.Text = client[2];
                cpatronymic_txt.Text = client[3];
                cemail_txt.Text = client[4];
                if (client[5] != String.Empty)
                {
                    Bitmap image = new Bitmap(client[5]);
                    clientpicture.Image = image;
                }
                else
                {
                    clientpicture.Image = null;
                }
            }
        }
        //Загрузка фотографии
        private void fotodownload_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFile = fileDialog.FileName;
                    Image userImage = Image.FromFile(selectedFile);
                    string fileName = Guid.NewGuid().ToString() + ".jpg";
                    string filePath = Path.Combine("../../../images/", fileName);
                    userImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    using (var db = new DBcontext())
                    {
                        var client = db.Clients.FirstOrDefault(u => u.ID.ToString() == id_txt.Text);
                        if (client != null)
                        {
                            client.ClientPicture = Path.GetFullPath(filePath);
                            db.SaveChanges();
                            Bitmap image = new Bitmap(client.ClientPicture);
                            clientpicture.Image = image;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Кнопка "Скрытые профили"
        private void button3_Click(object sender, EventArgs e)
        {
            var dislikedperformers = new Dislikedperformers(clientID);
            dislikedperformers.Show();
        }
        //Кнопка "Редактировать предпочтения"
        private void button1_Click(object sender, EventArgs e)
        {
            var customizePreferences = new CustomizePreferences(clientID);
            customizePreferences.Show();
        }
        //Кнопка "Мои заказы"
        private void button2_Click(object sender, EventArgs e)
        {
            var myservices = new Myservices(clientID);
            myservices.Show();
        }
        //Кнопка "Назад"
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Локализация
        private void UpdateLocalization(object sender, EventArgs e)
        {
            this.Text = Localization.GetLocalizedString("ClientProfile");
            fotodownload_btn.Text = Localization.GetLocalizedString("fotodownload_btn");
            surname_lbl.Text = Localization.GetLocalizedString("surname_lbl");
            name_lbl.Text = Localization.GetLocalizedString("name_lbl");
            patronomyc_lbl.Text = Localization.GetLocalizedString("patronomyc_lbl");
            email_lbl.Text = Localization.GetLocalizedString("email_lbl");
            customize_btn.Text = Localization.GetLocalizedString("customize_btn"); ;
            my_btn.Text = Localization.GetLocalizedString("my_btn");
            disliked_btn.Text = Localization.GetLocalizedString("disliked_btn");
        }
    }
}
