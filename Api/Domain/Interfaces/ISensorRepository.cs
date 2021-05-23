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

        /// <summary>
        /// Получить список сенсора по идентификатору
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Sensor GetSensorById(int key);
    }
}
