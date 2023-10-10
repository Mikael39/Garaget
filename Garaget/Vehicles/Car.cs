using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.Vehicles
{
    public class Car : Vehicle
    {
        private int numberOfWheels;

        public int NumberOfWheels

        { get { return numberOfWheels; }

            set
            {               
                    numberOfWheels = value;
            }
        
        }


        public Car(int numberOfWheels, int year, string make, string model, string color, string licencePlate) : base(year, make, model, color, licencePlate)
        {
          NumberOfWheels = numberOfWheels;
        }

        public override string ToString()

        {
            return "Car of Make: " + Make + " Model: " + Model + " Manufactured year: " + Year + " number of wheels: " + NumberOfWheels + " Color: " + Color + " Licenceplate: " + LicencePlate;
        }
    }
}
