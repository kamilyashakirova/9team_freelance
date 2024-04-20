namespace freelance
{
    public class Performer
    {
        public int ClientID { get; set; }
        public int ID { get; set; }
        public string PName { get; set; } = null!;
        public string PSpecialization { get; set; } = String.Empty;
        public string PTime { get; set; } = String.Empty;    
        public string PLanguage { get; set; } = String.Empty;
        public string PExperience { get; set; } = String.Empty;
        public string PProduct { get; set; } = String.Empty;
        public string PPicture { get; set; } = String.Empty;
        public DislikedPerformers DislikedTable { get; set; }
        public LikedPerformers LikedTable { get; set; }
        public virtual Client InClients { get; set; }

    }
}
