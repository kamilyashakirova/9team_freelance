namespace freelance
{
    /// <summary>
    /// Класс, описывающий исполнителя, не понравившегося пользователю
    /// </summary>
    public class DislikedPerformers
    {
        /// <summary>
        /// ID фрилансера, не понравившегося клиенту
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// ID клиента, которому не понравился фрилансер
        /// </summary>
        public Guid ClientID { get; set; }
        /// <summary>
        /// ID не понравившегося клиенту фрилансера в общей таблице фрилансеров
        /// </summary>
        public Guid PerformerID { get; set; }
        /// <summary>
        /// Не понравившийся фрилансер в таблице заказчиков
        /// </summary>
        public virtual Client InClients { get; set; } = null!;
        /// <summary>
        /// Не понравившийся фрилансер в таблице фрилансеров
        /// </summary>
        public virtual Performer InPerformers { get; set;} = null!;
    }
}
