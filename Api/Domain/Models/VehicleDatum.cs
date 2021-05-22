using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class VehicleDatum
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public DateTime Date { get; set; }
        public decimal Speed { get; set; }
        public int SensorId { get; set; }
        public bool Processed { get; set; }

        public virtual Sensor Sensor { get; set; }
    }
}
