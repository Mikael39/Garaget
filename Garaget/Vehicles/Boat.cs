using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.Vehicles
{
    public class Boat : Vehicle
    {
        private int horsePower;

        public int HorsePower
        {
            get { return horsePower; }
            set
            {
              
                    horsePower = value;
            }
        }
        public Boat(int horsePower, int year, string make, string model, string color, string licencePlate) : base(year, make, model, color, licencePlate)
        {
            HorsePower = horsePower;
        }

        public override string ToString()

        {
            return "Boat of Make: " + Make + " Model: " + Model + " Manufactured year: " + Year + " Horsepower: " + HorsePower + " Color: " + Color + " Licenceplate: " + LicencePlate;
        }

    }
}
