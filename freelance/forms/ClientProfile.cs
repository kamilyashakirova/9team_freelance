﻿using Microsoft.VisualBasic.ApplicationServices;
<<<<<<< HEAD
using Newtonsoft.Json.Linq;
=======
using NLog;
>>>>>>> 625cc8a5e8236093a8226b8af0dff7a627a4b398
using System.Data.Entity.Core.EntityClient;
namespace freelance.forms
{
    public partial class ClientProfile : Form
    {
        private string selectedFile = String.Empty;
<<<<<<< HEAD
        private static Guid clientID;
        private static string loc = String.Empty;
        private Guid userID;
        private static string file = String.Empty ;
        CustomizePreferences customizePreferences = new CustomizePreferences(clientID, file);
        Dislikedperformers dislikedperformers = new Dislikedperformers(clientID, file);
        public ClientProfile(Guid userID, string file)
=======
        private int clientID;
        private int userID;
        private static string loc = String.Empty;
        CustomizePreferences? customizePreferences;
        Dislikedperformers? dislikedperformers;
        public ClientProfile(int clientID, string file)
>>>>>>> 625cc8a5e8236093a8226b8af0dff7a627a4b398
        {
            loc = file;
            this.clientID = clientID;
            InitializeComponent();
            Localization.LanguageChanged += UpdateLocalization;
        }
        //Загрузка данных о клиенте
        private void AddInfo(Guid userID)
        {
            using (var db = new DBcontext()) 
            {
<<<<<<< HEAD
                var client = db.Clients.FirstOrDefault(u => u.UserID == userID);
=======
                var client = db.Clients.Where(u => u.ID == clientID).FirstOrDefault();
>>>>>>> 625cc8a5e8236093a8226b8af0dff7a627a4b398
                if (client != null)
                {
                    userID = client.UserID;
                    clientID = client.ID;
                    id_txt.Text = client.ID.ToString();
                    cname_txt.Text = client.ClientName;
                    csurname_txt.Text = client.ClientSurname;
                    cpatronymic_txt.Text = client.ClientPatronomic;
                    cemail_txt.Text = client.Email;
                    if (client.ClientPicture != String.Empty)
                    {
                        Bitmap image = new Bitmap(client.ClientPicture);
                        clientpicture.Image = image;
                    }
                    else
                    {
                        clientpicture.Image = null;
                    }
<<<<<<< HEAD

=======
                }
            }
            AddInfo(userID);
        }
        //Загрузка данных о клиенте
        private void AddInfo(int userID)
        {
            var client = workingwithDB.clientsloaddata(userID);
            if (client != null)
            {
                id_txt.Text = client[0];
                cname_txt.Text = client[1];
                csurname_txt.Text = client[2];
                cpatronymic_txt.Text = client[3];
                cemail_txt.Text = client[4];
                try
                {
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
>>>>>>> 625cc8a5e8236093a8226b8af0dff7a627a4b398
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
                        var client = db.Clients.FirstOrDefault(u => u.ID == Guid.Parse(id_txt.Text));
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
            dislikedperformers = new Dislikedperformers(clientID, loc);
            dislikedperformers.Show();
        }
        //Кнопка "Редактировать предпочтения"
        private void button1_Click(object sender, EventArgs e)
        {
            customizePreferences = new CustomizePreferences(clientID, loc);
            customizePreferences.Show();
        }
        //Кнопка "Мои заказы"
        private void button2_Click(object sender, EventArgs e)
        {
            var myservices = new Myservices(clientID, loc);
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
        }
        private void ClientProfile_Load(object sender, EventArgs e)
        {
            Localization.LoadLocalizationDictionary(this, loc);
            using (var db = new DBcontext())
            {
                var client = db.Clients.Where(u => u.UserID == userID).FirstOrDefault();
                if (client != null)
                {
                    clientID = client.ID;
                    id_txt.Text = client.ID.ToString();
                    cname_txt.Text = client.ClientName;
                    csurname_txt.Text = client.ClientSurname;
                    cpatronymic_txt.Text = client.ClientPatronomic;
                    cemail_txt.Text = client.Email;
                    if (client.ClientPicture != String.Empty)
                    {
                        Bitmap image = new Bitmap(client.ClientPicture);
                        clientpicture.Image = image;
                    }
                    else
                    {
                        clientpicture.Image = null;
                    }
                    if (client.VkUserID != String.Empty)
                    {
                        vkIcon_pic.Visible = true;
                    }
                    else 
                    {
                        vkIcon_pic.Visible = false;
                    }
                }
            }
        }
    }
}
