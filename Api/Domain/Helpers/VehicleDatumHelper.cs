using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using System.Linq;

namespace Domain.Helpers
{
    public static class VehicleDatumHelper
    {
        /// <summary>
        /// Добавление новых даннах о проезде автомобиля    
        /// </summary>
        /// <param name="model"></param>
        public static void Add(VehicleDatum model)
        {
            using (var dc = new traffichookContext())
            {
                dc.VehicleData.Add(model);
                dc.SaveChanges();
            }
        }
    }
}
