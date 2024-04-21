namespace freelance
{
    public class Performer
    {
        public int ClientID { get; set; }
        public int ID { get; set; }
        public string PName { get; set; } = null!;
        public string PSpecialization { get; set; } = null!;
        public string PTime { get; set; } = null!;    
        public string PLanguage { get; set; } = null!;
        public string PExperience { get; set; } = null!;
        public string PProduct { get; set; } = null!;
        public string PPicture { get; set; } = null!;
        public DislikedPerformers DislikedTable { get; set; } = null!;
        public LikedPerformers LikedTable { get; set; } = null!;    
        public virtual Client InClients { get; set; } = null!;

    }
}
