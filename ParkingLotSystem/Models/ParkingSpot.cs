using ParkingLotSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotSystem.Models
{
    internal class ParkingSpot
    {
        public int SpotNumber { get; set; }
        public bool IsAvailable => ParkedVehicle == null; // Calculated property to determine availability
        public VehicleType SupportedType { get; set; }
        public Vehicle ParkedVehicle { get; set; }

        public ParkingSpot(int spotNumber, VehicleType supportedType)
        {
            SpotNumber = spotNumber;
            SupportedType = supportedType;
            ParkedVehicle = null;
        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            if(IsAvailable && vehicle.Type == SupportedType) {
                ParkedVehicle = vehicle;
                return true;
            }
            return false;
        }

        public bool UnparkVehicle() {
            if(!IsAvailable)
            {
                ParkedVehicle = null;
                return true;
            }
            return false;
        }
    }
}
