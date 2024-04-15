using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelance
{
    public partial class interest
    {
        public int ID { get; set; }
        public int clientID { get; set; }
        public string ispecialization { get; set; } = null!;
        public string itime { get; set; } = null!;
        public string ipriceofwork { get; set; } = null!;
        public string iExperience { get; set; } = null!;
        public string irating { get; set; } = null!;
        public virtual client InClients { get; set; } = null!;
    }
}
