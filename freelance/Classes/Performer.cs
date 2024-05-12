namespace freelance
{
    /// <summary>
    /// Класс, описывающий исполнителя (фрилансера)
    /// </summary>
    public class Performer
    {
        /// <summary>
        /// ID заказчика
        /// </summary>
        public Guid ClientID { get; set; }
        /// <summary>
        /// ID фрилансера
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// Имя фрилансера
        /// </summary>
        public string PName { get; set; } = String.Empty;
        /// <summary>
        /// Специализация фрилансера
        /// </summary>
        public string PSpecialization { get; set; } = String.Empty;
        /// <summary>
        /// Среднее время выполнения заказа фрилансера
        /// </summary>
        public string PTime { get; set; } = String.Empty;    
        /// <summary>
        /// Языки, которые знает фрилансер
        /// </summary>
        public string PLanguage { get; set; } = String.Empty;
        /// <summary>
        /// Опыт работы фрилансера
        /// </summary>
        public string PExperience { get; set; } = String.Empty;
        /// <summary>
        /// Продукт фрилансера
        /// </summary>
        public string PProduct { get; set; } = String.Empty;
        /// <summary>
        /// Фотография фрилансера
        /// </summary>
        public string PPicture { get; set; } = String.Empty;
        /// <summary>
        /// Фрилансер в таблице непонравившихся фрилансеров
        /// </summary>
        public DislikedPerformers DislikedTable { get; set; } = null!;
        /// <summary>
        /// Фрилансер в таблице понравившихся фрилансеров 
        /// </summary>
        public LikedPerformers LikedTable { get; set; } = null!;    
        /// <summary>
        /// Фрилансер в таблице заказчиков
        /// </summary>
        public virtual Client InClients { get; set; } = null!;

    }
}
