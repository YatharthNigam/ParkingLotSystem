using ParkingLotSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotSystem.Models
{
    internal class Vehicle
    {
        public string LicenseNumber { get; set; }
        public VehicleType Type { get; set; }
    }
}
