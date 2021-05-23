using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Domain.Models;
using Domain.Interfaces;

namespace Domain.Repository
{
    public class SensorRepository : ISensorRepository
    {
        public List<Sensor> GetAllSensors()
        {
            using (var dc = new traffichookContext())
            {
                List<Sensor> result = dc.Sensors.ToList();
                return result;
            }
        }

        public Sensor GetSensorById(int key)
        {
            using (var dc = new traffichookContext())
            {
                Sensor result = dc.Sensors.Where(i => i.KeyExt == key).FirstOrDefault();
                return result;
            }
        }
    }
}
