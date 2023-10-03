using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garaget.UI;
using Garaget.Vehicles;

namespace Garaget
{
    public class Garage<T> where T : IGarage, IEnumerable<T>
    {
        public static int totalParkingSlots;       
        public static int availableParkingSlots;
        private Vehicle[] garaget;
        


        public Garage(int parkingSlots)
        {
            TotalParkingSlots = parkingSlots; 
        }


        public Vehicle[] CreateGarage(int n)
        {

            Vehicle[] garaget = new Vehicle[n];

            return garaget;

        }
        public int TotalParkingSlots
        {
            get { return totalParkingSlots; }
            set { totalParkingSlots = value; }
        }

        public int AvailableParkingSlots
        {
            get { return availableParkingSlots; }
            set { availableParkingSlots = totalParkingSlots - GarageHandler.currentParked; }
        }

    }
}
