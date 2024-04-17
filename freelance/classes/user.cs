namespace freelance
{
    public class User
    {
        public int UId { get; set; }
        public string ULogin { get; set; } = null!;
        public string UPasswordHash { get; set; } = null!;
        public string Email { get; set; } = null!;
        public Client ClientsTable { get; set; } = null!;
    }
}
