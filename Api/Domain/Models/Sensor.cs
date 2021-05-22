using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class Sensor
    {
        public Sensor()
        {
            VehicleData = new HashSet<VehicleDatum>();
        }

        public int KeyExt { get; set; }

        public virtual ICollection<VehicleDatum> VehicleData { get; set; }
    }
}
