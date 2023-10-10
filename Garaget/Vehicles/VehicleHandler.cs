using Garaget.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.Vehicles
{
    public class VehicleHandler
    {

        public VehicleHandler()
        {

            
        }
        public Boat CreateBoat(int horsePower, int year, string make, string model, string color, string licencePlate)
        {
            Boat output = new(horsePower, year, make, model, color, licencePlate);

            return output;
        }

        public Car CreateCar(int wheels, int year, string make, string model, string color, string licencePlate)
        {
            Car output = new(wheels, year, make, model, color, licencePlate);

            return output;
        }

        public AirPlane CreateAirPlane(int seats, int year, string make, string model, string color, string licencePlate)
        {
            AirPlane output = new(seats, year, make, model, color, licencePlate);

            return output;
        }


        public Bus CreateBus(int doors, int year, string make, string model, string color, string licencePlate)
        {
            Bus output = new(doors, year, make, model, color, licencePlate);
            return output;
        }

        public MotorCycle CreateMotorCycle(int numberOfTrafficViolations, int year, string make, string model, string color, string licencePlate)
        {
            MotorCycle output = new(numberOfTrafficViolations, year, make, model, color, licencePlate);
            return output;
        }
    }
    
}
