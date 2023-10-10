using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.Vehicles
{
    public class MotorCycle : Vehicle
    {
        private int numberOfTrafficViolations;  
        
            public int NumberOfTrafficViolations
            { 
                get { return numberOfTrafficViolations; }

                set
                {
            
                    numberOfTrafficViolations = value;
                }
        
            }
        public MotorCycle(int numberOfTrafficViolations, int year, string make, string model, string color, string licencePlate) : base(year, make, model, color, licencePlate)
        {
            NumberOfTrafficViolations = numberOfTrafficViolations;
        }

        public override string ToString()

        {
            return "MC of Make: " + Make + " Model: " + Model + " Manufactured year: " + Year + " Traffic violations: " + NumberOfTrafficViolations + " Color: " + Color + " Licenceplate: " + LicencePlate;
        }

    }
}
