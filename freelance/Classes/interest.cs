using System;
namespace freelance
{
    /// <summary>
    /// Класс, описывающий интересы пользователя
    /// </summary>
    public class Interest
    {
        public Guid ID { get; set; }
        public Guid ClientID { get; set; }
        public string InterestSpecialization { get; set; } = String.Empty;
        public string InterestTime { get; set; } = String.Empty;
        public string InterestExperience { get; set; } = String.Empty;
        public string InterestLanguage { get; set; } = String.Empty;
        public string InterestProduct { get; set; }  = String.Empty;
        public virtual Client InClients { get; set; } = null!;
    }
}
