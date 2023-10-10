using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.Vehicles
{
    public class AirPlane : Vehicle
    {
        public int numberOfSeats;

        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set
            {
           
                    numberOfSeats = value;
            }
        }

        public AirPlane(int numberOfSeats, int year, string make, string model, string color, string licencePlate) : base(year, make, model, color, licencePlate)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()

        {
            return "AirPlane of Make: " + Make + " Model: " + Model + " Manufactured year: " + Year + " number of seats: " + NumberOfSeats + " Color: " + Color + " Licenceplate: " + LicencePlate;
        }
    }
}
