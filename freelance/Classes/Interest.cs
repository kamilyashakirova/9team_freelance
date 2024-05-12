using System;
namespace freelance
{
    /// <summary>
    /// Класс, описывающий интересы пользователя
    /// </summary>
    public class Interest
    {
        /// <summary>
        /// ID предпочтения заказчика
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// ID заказчика
        /// </summary>
        public Guid ClientID { get; set; }
        /// <summary>
        /// Специализация, интересующие заказчика
        /// </summary>
        public string InterestSpecialization { get; set; } = String.Empty;
        /// <summary>
        /// Сроки, интересующие заказчика
        /// </summary>
        public string InterestTime { get; set; } = String.Empty;
        /// <summary>
        /// Опыт, интересующий заказчика
        /// </summary>
        public string InterestExperience { get; set; } = String.Empty;
        /// <summary>
        /// Языки, интересующие заказчика
        /// </summary>
        public string InterestLanguage { get; set; } = String.Empty;
        /// <summary>
        /// Продукт, интересующие заказчика
        /// </summary>
        public string InterestProduct { get; set; }  = String.Empty;
        /// <summary>
        /// Заказчик в таблице предпочтений
        /// </summary>
        public virtual Client InClients { get; set; } = null!;
    }
}
