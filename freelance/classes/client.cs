using System.Collections.Generic;
namespace freelance
{
    public partial class client
    {
        public int ID { get; set; }

        public int userID { get; set; }

        public string clientName { get; set; } = null!;

        public string clientSurname { get; set; } = null!;

        public string clientPatronomic { get; set; } = null!;
        public string email { get; set; } = null!;
        public virtual user NumberInUsersTable { get; set; } = null!;

    }
}
