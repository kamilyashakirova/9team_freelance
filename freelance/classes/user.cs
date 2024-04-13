namespace freelance
{
    public partial class user
        {
            public int uId { get; set; }
            public string uLogin { get; set; } = null!;
            public string uPasswordHash { get; set; } = null!;
        public string email { get; set; } = null!;
        public client clientsTable { get; set; } = null!;

    }
}
