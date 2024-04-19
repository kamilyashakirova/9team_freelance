namespace freelance
{
    public class DislikedPerformers
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int PerformerID { get; set; }
        public virtual Client InClients { get; set; } = null!;
        public virtual Performer InPerformers { get; set;} = null!;
    }
}
