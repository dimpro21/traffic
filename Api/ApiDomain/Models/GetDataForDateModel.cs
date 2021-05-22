using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    /// <summary>
    /// Модель, которую принимает контроллер для 
    /// </summary>
    public class GetDataForDateModel
    {
        /// <summary>
        /// Нижняя граница даты
        /// </summary>
        public DateTime FirstDate { get; set; }

        /// <summary>
        /// Верхняя граница даты
        /// </summary>
        public DateTime SecondDate { get; set; }
    }
}
