namespace freelance
{
    /// <summary>
    /// Класс, описывающий исполнителя, понравившегося пользователю
    /// </summary>
    public class LikedPerformers
    {
        /// <summary>
        /// ID фрилансера, понравившегося клиенту
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// ID клиента, которому понравился фрилансер
        /// </summary>
        public Guid ClientID { get; set; }
        /// <summary>
        /// ID понравившегося клиенту фрилансера в общей таблице фрилансеров
        /// </summary>
        public Guid PerformerID { get; set; }
        /// <summary>
        /// Понравившийся фрилансер в таблице заказчиков
        /// </summary>
        public virtual Client InClients { get; set; } = null!;
        /// <summary>
        /// Понравившийся фрилансер в таблице фрилансеров
        /// </summary>
        public virtual Performer InPerformers { get; set; } = null!;
    }
}
