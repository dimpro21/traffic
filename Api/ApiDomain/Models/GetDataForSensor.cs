using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    /// <summary>
    /// Модель для получения данных по определнному сенсору
    /// </summary>
    public class GetDataForSensor
    {
        /// <summary>
        /// Ключ сенсора
        /// </summary>
        public int key { get; set; }

        /// <summary>
        /// Нижняя граница даты
        /// </summary>
        public DateTime firstDate { get; set; }

        /// <summary>
        /// Верхняя граница даты
        /// </summary>
        public DateTime secondDate { get; set; }
    }
}
