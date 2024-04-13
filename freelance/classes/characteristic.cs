namespace freelance
{
    public partial class characteristic
    {
        public int Id { get; set; }

        public int performerID { get; set; }
        public string characterName { get; set; } = null!;
        public virtual ICollection<performer> performerCharacteristicsTable { get; set; } = new List<performer>();
    }
}
