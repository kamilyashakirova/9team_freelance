using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet;
using freelance.forms;
namespace freelance
{
    public partial class EnterWithVKForm : Form
    {
        ListOfRecomendations? listOfrecs;
        private string file = String.Empty;
        public EnterWithVKForm(string loc)
        {
            InitializeComponent();
            file = loc;
            Localization.LanguageChanged += UpdateLocalization;
        }
        private void enterWithVK_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var api = new VkApi();
                api.Authorize(new ApiAuthParams
                {
                    ApplicationId = 51920629,
                    Login = VKlogin_txt.Text,
                    Password = VKpassword_txt.Text,
                    Settings = Settings.All
                });
                var res = api.Groups.Get(new GroupsGetParams());
                var client = api.Users.Get(new long[] { api.UserId.Value }).FirstOrDefault();
                if (client != null)
                {
                    using (var db = new DBcontext())
                    {
                        if (!db.Clients.Any(u => u.VkUserID == client.Id.ToString()))
                        {
                            db.Clients.Add(new Client
                            {
                                VkUserID = client.Id.ToString(),
                                ClientName = client.FirstName,
                                ClientSurname = client.LastName,
                                ClientPatronomic = String.Empty,
                                ClientPicture = String.Empty,
                                Email = String.Empty,
                                UserID = Guid.NewGuid()
                            }) ;
                            db.SaveChanges();
                            MessageBox.Show("Вы успешно вошли.");
                        }
                        listOfrecs = new ListOfRecomendations(client.Id.ToString(), file);
                        listOfrecs.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateLocalization(object sender, EventArgs e)
        {
            this.Text = Localization.GetLocalizedString("EnterWithVKForm");
            VKpassword_txt.PlaceholderText = Localization.GetLocalizedString("rpassword_txtb");
            VKlogin_txt.PlaceholderText = Localization.GetLocalizedString("VKlogin_txt");
        }
        private void EnterWithVKForm_Load(object sender, EventArgs e)
        {
            Localization.LoadLocalizationDictionary(this, file);
        }
    }
}
