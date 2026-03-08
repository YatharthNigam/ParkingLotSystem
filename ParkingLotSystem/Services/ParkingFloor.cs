using ParkingLotSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotSystem.Services
{
    internal class ParkingFloor
    {
        public int FloorNumber { get; set; }
        public List<ParkingSpot> ParkingSpots { get; set; }

        public ParkingFloor(int floorNumber, List<ParkingSpot> totalSpots) 
        {
            this.FloorNumber = floorNumber;
            this.ParkingSpots = totalSpots;
        }

        public bool CanPark(Vehicle vehicle)
        {
            return ParkingSpots.Any(spot => spot.IsAvailable && spot.VehicleType == vehicle.Type);
        }

        public bool ParkVehicle (Vehicle vehicle)
        {
            var parkingSpot = ParkingSpots.FirstOrDefault(spot => spot.IsAvailable);
            if (parkingSpot != null)
            {
                return parkingSpot.ParkVehicle(vehicle);
            }
            return false;
        }
         public bool UnparkVehicle(int spotNumber)
        {
            var parkingSpot = ParkingSpots.FirstOrDefault(spot => spot.SpotNumber == spotNumber);
            if (parkingSpot != null)
            {
                return parkingSpot.UnparkVehicle();
            }
            return false;
        }
    }
}
