using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Domain.Interfaces;
using Domain.Models;

namespace Domain.Repository
{
    public class VehicleDatumRepository : IVehicleDatumRepository
    {
        public List<VehicleDatum> GetAllVhicleDataForSensor(int key, DateTime firstDate, DateTime secondDate)
        {
            if (key == 0) throw new Exception("Не заполнен ключ датчика");

            using (var dc = new traffichookContext())
            {
                List<VehicleDatum> result = null;
                if (firstDate == null || secondDate == null)
                {
                    result = dc.VehicleData.Where(i => i.SensorId == key).ToList();
                }
                else
                {
                    result = dc.VehicleData.Where(i => i.Date >= firstDate && i.Date <= secondDate && i.SensorId == key).ToList();
                }
                return result;
            }                
        }

        public List<VehicleDatum> GetAllVhicleDataWithDate(DateTime firstDate, DateTime secondDate)
        {
            if (firstDate == null) throw new Exception("Не введена нижняя граница даты"); 
            if (secondDate == null) throw new Exception("Не введена верхняя граница даты");

            using (var dc = new traffichookContext())
            {
                var result = dc.VehicleData.Where(i => i.Date >= firstDate && i.Date <= secondDate).ToList();
                return result;
            }
        }
    }
}
