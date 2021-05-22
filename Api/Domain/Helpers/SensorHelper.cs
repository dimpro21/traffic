using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using System.Linq;

namespace Domain.Helpers
{
    /// <summary>
    /// Хелпер для работы с датчиками
    /// </summary>
    public static class SensorHelper
    {
        /// <summary>
        /// Добавление Датчика
        /// </summary>
        /// <param name="id"></param>
        public static void Add(int id)
        {
            using (var dc = new traffichookContext())
            {
                dc.Sensors.Add(new Sensor() { KeyExt = id});
                dc.SaveChanges();
            }
        }
    }
}
