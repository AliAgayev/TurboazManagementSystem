using System;
using System.Collections.Generic;
using System.Text;
using TurboazManagementSystem.Enums;

namespace TurboazManagementSystem.Models
{
   public abstract class Car
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public BanType BanType { get; set; }
        public FuelType FuelType { get; set; }
        public SpeedboxType SpeedBox { get; set; }
        public TransmissionType Transmission { get; set; }
        public int EngineCapacity { get; set; }
        public string Color { get; set; }
        public double Milleage { get; set; }
        public int Power { get; set; }
       
        public int ReleaseDate { get; set; }

    }
}
