namespace freelance
{
    /// <summary>
    /// Класс, описывающий пользователя
    /// </summary>
    public class User
    {
        /// <summary>
        /// ID пользователя
        /// </summary>
        public Guid UId { get; set; }
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string ULogin { get; set; } = null!;
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string UPasswordHash { get; set; } = null!;
        /// <summary>
        /// Email пользователя
        /// </summary>
        public string Email { get; set; } = null!;
        /// <summary>
        /// Пользователь в таблице заказчиков
        /// </summary>
        public Client ClientsTable { get; set; } = null!;
    }
}
