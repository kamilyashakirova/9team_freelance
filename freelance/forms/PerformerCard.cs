using NLog;
using System.Data;
using System.Drawing.Text;
using System.Net.PeerToPeer;
namespace freelance.forms
{
    public partial class PerformerCard : Form
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        PrivateFontCollection fonts = new PrivateFontCollection();
        string dislike = "Не нравится";
        string like = "Нравится";
        private Guid clientID;
        private string file = String.Empty;
        public PerformerCard(Guid clientID, string file)
        {
            this.file = file;
            this.clientID = clientID;
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            fonts.AddFontFile("../../../fonts/DidactGothic-Regular.ttf");
            this.Font = new Font(fonts.Families[0], 10);
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = new Font(fonts.Families[0], 10); ;
            }
            Localization.LanguageChanged += UpdateLocalization;
            logger.Info("Успешно открыта карточка фрилансера.");
        }
        private void like_btn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show(like, like_btn, 0, 60, 800);
        }
        private void like_btn_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Hide((Control)sender);
        }
        private void dislike_btn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show(dislike, like_btn, 90, 60, 800);
        }
        private void dislike_btn_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Hide((Control)sender);
        }
        private void dislike_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Не нравится'");
            try
            {
                workingwithDB.AddDislike(clientID, Guid.Parse(ID_Card_txt.Text.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void like_btn_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Нравится'");
            try
            {
                workingwithDB.AddLike(clientID, Guid.Parse(ID_Card_txt.Text.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Локализация
        private void UpdateLocalization(object sender, EventArgs e)
        {
            this.Text = Localization.GetLocalizedString("PerformerCard");
            fio_lbl.Text = Localization.GetLocalizedString("fio_lbl");
            spec_lbl.Text = Localization.GetLocalizedString("spec_lbl");
            srtime_lbl.Text = Localization.GetLocalizedString("srtime_lbl");
            srprice_lbl.Text = Localization.GetLocalizedString("srprice_lbl");
            experiense_lbl.Text = Localization.GetLocalizedString("experiense_lbl");
            rating_lbl.Text = Localization.GetLocalizedString("rating_lbl");
            like = Localization.GetLocalizedString("like");
            dislike = Localization.GetLocalizedString("dislike");
        }
        private void PerformerCard_Load(object sender, EventArgs e)
        {
            Localization.LoadLocalizationDictionary(this, file);
        }

        private void pspecializationCard_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
