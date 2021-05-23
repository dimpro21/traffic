using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IVehicleDatumRepository
    {
        /// <summary>
        /// Получить всю информацию о передвижениях транспортных средств
        /// </summary>
        /// <returns></returns>
        public List<VehicleDatum> GetAllVhicleDataWithDate(DateTime firstDate, DateTime secondDate);

        /// <summary>
        /// Получить всю информацию о передвижениях транспортных средств для определенного сенсора по ключу
        /// </summary>
        /// <returns></returns>
        public List<VehicleDatum> GetAllVhicleDataForSensor(int key, DateTime firstDate, DateTime secondDate);
        public List<VehicleDatum> GetAllVhicleData();
    }
}
