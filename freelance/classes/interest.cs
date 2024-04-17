using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelance
{
    public class Interest
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public string IName { get; set; } = null!;
        public string IsLiked { get; set; } = null!;
        public virtual Client InClients { get; set; } = null!;
    }
}
