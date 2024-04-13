namespace freelance
{
    public partial class performer
    {
        public int performerID { get; set; }

        public int userID{ get; set; }

        public string performerName { get; set; } = null!;

        public string performerSurname { get; set; } = null!;

        public string performerPatronymic { get; set; } = null!;

        public virtual user NumberInUsersTable { get; set; } = null!;

        public virtual ICollection<bookmark> clientsBookmarksTable { get; set; } = new List<bookmark>();
        public virtual ICollection<characteristic> performerCharacteristicsTable { get; set; } = new List<characteristic>();
    }
}
