using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using System.Linq;

namespace Domain.Helpers
{
    public static class VehicleDatumHelper
    {

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
