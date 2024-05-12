namespace freelance
{
    /// <summary>
    /// класс, описывающий заказчика
    /// </summary>
    public class Client
    {
        /// <summary>
        /// ID заказчика
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// ID пользователя в таблице заказчиков
        /// </summary>
        public Guid UserID { get; set; }
        /// <summary>
        /// ID заказчика в Вконтакте
        /// </summary>
        public string VkUserID {  get; set; } = null!;
        /// <summary>
        /// Имя заказчика
        /// </summary>
        public string ClientName { get; set; } = null!;
        /// <summary>
        /// Фамилия заказчика
        /// </summary>
        public string ClientSurname { get; set; } = null!;
        /// <summary>
        /// Отчество заказчика
        /// </summary>
        public string ClientPatronomic { get; set; } = null!;
        /// <summary>
        /// Email заказчика
        /// </summary>
        public string Email { get; set; } = null!;
        /// <summary>
        /// Фотография заказчика
        /// </summary>
        public string ClientPicture { get; set; } = null!;
        /// <summary>
        /// Заказчик в таблице пользователей
        /// </summary>
        public virtual User InUsers { get; set; } = null!;
        /// <summary>
        /// Предпочтения заказчика
        /// </summary>
        public Interest InterestsTable { get; set; } = null!;
        /// <summary>
        /// Фрилансеры, не понравившиеся заказчику
        /// </summary>
        public DislikedPerformers DislikedTable { get; set; } = null!;
        /// <summary>
        /// Фрилансеры, понравившиеся заказчику
        /// </summary>
        public LikedPerformers LikedTable { get; set; } = null!;
        /// <summary>
        /// Объявления заказчика
        /// </summary>
        public Performer Myservices { get; set; } = null!;

    }
}
