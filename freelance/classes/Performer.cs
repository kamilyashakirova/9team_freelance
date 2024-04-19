namespace freelance
{
    public class Performer
    {
        public int ID { get; set; }
        public string PName { get; set; } = null!;
        public string PSpecialization { get; set; } = null!;
        public string PTime { get; set; } = null!;    
        public string PPriceofwork { get; set; } = null!;
        public string PExperience { get; set; } = null !;
        public string PRating { get; set; } = null!;
        public string PPicture { get; set; } = null!;
        public DislikedPerformers DislikedTable { get; set; }
        public LikedPerformers LikedTable { get; set; }
    }
}
