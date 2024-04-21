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
        public string ISpecialization { get; set; } = null!;
        public string ITime { get; set; } = null!;
        public string IExperience { get; set; } = null!;
        public string ILanguage { get; set; } = null!;
        public string IProduct{ get; set; } = null!;
        public virtual Client InClients { get; set; } = null!;
    }
}
