namespace freelance
{
    /// <summary>
    /// Класс, описывающий исполнителя, не понравившегося пользователю
    /// </summary>
    public class LikedPerformers
    {
        public Guid ID { get; set; }
        public Guid ClientID { get; set; }
        public Guid PerformerID { get; set; }
        public virtual Client InClients { get; set; } = null!;
        public virtual Performer InPerformers { get; set; } = null!;
    }
}
