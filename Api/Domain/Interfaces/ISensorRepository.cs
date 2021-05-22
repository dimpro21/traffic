using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface ISensorRepository
    {
        /// <summary>
        /// Получить список всех сенсоров
        /// </summary>
        /// <returns></returns>
        public List<Sensor> GetAllSensors();
    }
}
