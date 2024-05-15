using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet;
using freelance.forms;
using NLog;
namespace freelance
{
    public partial class EnterWithVKForm : Form
    {
        private ListOfRecomendations? listOfrecs;
        private string file = String.Empty;

        public static Logger logger = LogManager.GetCurrentClassLogger();
        public EnterWithVKForm(string loc)
        {
            InitializeComponent();
            file = loc;
            Localization.LanguageChanged += UpdateLocalization;

            logger.Info("Успешно открыта форма 'EnterWithVKForm'");
        }
        private void enterWithVK_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var api = new VkApi();
                api.Authorize(new ApiAuthParams
                {
                    ApplicationId = 51924644,
                    Login = VKlogin_txt.Text,
                    Password = VKpassword_txt.Text,
                    Settings = Settings.All
                });
                var res = api.Groups.Get(new GroupsGetParams());
                var clientVK = api.Users.Get(new long[] { api.UserId.Value }).FirstOrDefault();
                try
                {
                    if (clientVK != null)
                    {
                        using (var db = new DBcontext())
                        {
                            if (!db.Clients.Any(u => u.VkUserID == clientVK.Id.ToString()))
                            {
                                var client = new Client
                                {
                                    VkUserID = clientVK.Id.ToString(),
                                    ClientName = clientVK.FirstName,
                                    ClientSurname = clientVK.LastName,
                                    ClientPatronomic = String.Empty,
                                    ClientPicture = String.Empty,
                                    Email = String.Empty,
                                    UserID = Guid.NewGuid()
                                };
                                db.Clients.Add(client);
                                db.SaveChanges();
                                listOfrecs = new ListOfRecomendations(client.ID, file);
                                listOfrecs.Show();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при авторизации через Вконтакте");
                    logger.Info($"Ошибка при авторизации через Вконтакте. {ex}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Info(ex);
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

        private void VKpassword_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_pic_Click(object sender, EventArgs e)
        {
            VKpassword_txt.PasswordChar = '\0';
            hide_picb.Visible = true;
            show_pic.Visible = false;
        }

        private void hide_picb_Click(object sender, EventArgs e)
        {
            VKpassword_txt.PasswordChar = '*';
            hide_picb.Visible = false;
            show_pic.Visible = true;
        }
    }
}
