﻿using Microsoft.VisualBasic.ApplicationServices;

namespace freelance.forms
{
    public partial class ClientProfile : Form
    {
        private bool ImageSelect = false;
        private string selectedFile = String.Empty;
        public ClientProfile(int clientID)
        {
            InitializeComponent();
            var client = workingwithDB.clientsloaddata(clientID);
            if (client != null)
            {
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
        private void fotodownload_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageSelect = true;
                    selectedFile = fileDialog.FileName;
                    using (var db = new DBcontext())
                    {
                        var client = db.Clients.FirstOrDefault(u => u.ID.ToString() == id_txt.Text);
                        if (client != null)
                        {
                            client.ClientPicture = selectedFile;
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

        private void clientpicture_Click(object sender, EventArgs e)
        {

        }
    }
}
