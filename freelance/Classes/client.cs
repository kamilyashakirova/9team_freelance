namespace freelance
{
    /// <summary>
    /// Класс, описывающий "клиента"
    /// </summary>
    public class Client
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public string ClientName { get; set; } = null!;

        public string ClientSurname { get; set; } = null!;

        public string ClientPatronomic { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ClientPicture { get; set; } = null!;
        public virtual User InUsers { get; set; } = null!;
        public Interest InterestsTable { get; set; } = null!;
        public DislikedPerformers DislikedTable { get; set; } = null!;
        public LikedPerformers LikedTable { get; set; } = null!;
        public Performer Myservices { get; set; } = null!;

    }
}
