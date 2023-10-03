using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garaget.Vehicles;
using Garaget.UI;

namespace Garaget
{
    public class GarageHandler
    {
        // private List<Vehicle> Vehicles;
        public static int currentParked = 0;


        public GarageHandler()
        {

        }


        

        public void SeedGarage()
        {
           // var a1 = 
        }

   

        public void ParkVechicle(Vehicle[] garaget, Vehicle vehicle)
        {
            if (currentParked <= garaget.TotalParkingSlots)
        
            garaget[currentParked] = vehicle;
            currentParked++;
        }

        public void PickUpVechicle(Vehicle[] garaget, Vehicle vehicle)
        {
            var a1 = vehicle;
            bool contains = garaget.Any(p => p.LicencePlate == a1.LicencePlate);
            if (contains)
            {
                garaget.Where(p => p.LicencePlate != a1.LicencePlate).ToArray();
                currentParked--;
            }
            else
            {
                throw new ArgumentException("There is no Vehicle available in the Garage with that Licenceplate");
            }

            
        }

        //public IEnumerable<Employee> GetEmployees()
        //{
        //    //ToDo: Fix not good!
        //    return employees.ToArray();
        //}


    }
}
