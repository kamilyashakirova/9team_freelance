using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelance
{
    /// <summary>
    /// Класс, описывающий интересы пользователя
    /// </summary>
    public class Interest
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public string ISpecialization { get; set; } = String.Empty;
        public string ITime { get; set; } = String.Empty;
        public string IExperience { get; set; } = String.Empty;
        public string ILanguage { get; set; } = String.Empty;
        public string IProduct{ get; set; }  = String.Empty;
        public virtual Client InClients { get; set; } = null!;
    }
}
