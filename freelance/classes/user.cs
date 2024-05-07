namespace freelance
{
    /// <summary>
    /// Класс, поисывающий пользователя
    /// </summary>
    public class User
    {
        public Guid UId { get; set; }
        public string ULogin { get; set; } = null!;
        public string UPasswordHash { get; set; } = null!;
        public string Email { get; set; } = null!;
        public Client ClientsTable { get; set; } = null!;
    }
}
