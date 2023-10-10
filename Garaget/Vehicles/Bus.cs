using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.Vehicles
{
    public class Bus : Vehicle
    {
        private int numberOfDoors;
        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set
            {
                
                    numberOfDoors = value;
            }
        }
        public Bus(int numberOfDoors, int year, string make, string model, string color, string licencePlate) : base(year, make, model, color, licencePlate)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override string ToString()

        {
            return "Bus of Make: " + Make + " Model: " + Model + " Manufactured year: " + Year + " number of Doors: " + NumberOfDoors + " Color: " + Color + " Licenceplate: " + LicencePlate;
        }
    }
}
