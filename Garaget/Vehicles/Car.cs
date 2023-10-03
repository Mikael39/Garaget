using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.Vehicles
{
    public class Car : Vehicle
    { 


        public Car(int year, string make, string model, string color, string licencePlate) : base(year, make, model, color, licencePlate)
        {
          
        }
    }
}
