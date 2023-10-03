using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.Vehicles
{
    internal class AirPlane : Vehicle
    {
        public int numberOfSeats;

        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set
            {
                if (value < 2 || value > 500)
                    throw new ArgumentException("An airplane has a minimum of 2 seats and a maxiumum of 500 seats");
                else
                    numberOfSeats = value;
            }
        }

        public AirPlane(int year, string make, string model, string color, string licencePlate, int numberOfSeats) : base(year, make, model, color, licencePlate)
        {
            NumberOfSeats = numberOfSeats;
        }
    }
}
