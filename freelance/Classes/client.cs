namespace freelance
{
    public class Client
    {
        public Guid ID { get; set; }

        public Guid UserID { get; set; }
        public string VkUserID {  get; set; } = null!;
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
