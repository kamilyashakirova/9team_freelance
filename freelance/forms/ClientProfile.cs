using Microsoft.VisualBasic.ApplicationServices;

namespace freelance.forms
{
    public partial class ClientProfile : Form
    {
        private bool ImageSelect = false;
        private string selectedFile = String.Empty;
        private int clientID;
        public ClientProfile(int userID)
        {
            InitializeComponent();
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

        private void clientpicture_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dislikedperformers dislikedperformers = new Dislikedperformers(clientID);
            dislikedperformers.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomizePreferences customizePreferences = new CustomizePreferences();
            customizePreferences.Show();
        }
    }
}
