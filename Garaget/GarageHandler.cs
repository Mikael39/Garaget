using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garaget.Vehicles;
using Garaget.UI;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Reflection.Metadata;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using System.Collections;

namespace Garaget
{
   
    public class GarageHandler
    {
      
        private IGarage<IVehicle> garage;
        private IUI ui;
        VehicleHandler handler = new VehicleHandler();

        public GarageHandler(int parkingSlots, IUI ui)
        {
            this.ui = ui;
            garage = new Garage<IVehicle>(parkingSlots);
        }
        public void SeedGarage()
        
        {
            Bus bus = handler.CreateBus(4, 1950, "Toyota", "Prius", "Blue", "IOU154");
            ParkVechicle(bus);
            Bus bus1 = handler.CreateBus(6, 1988, "Volvo", "V90", "White", "15PO56");
            ParkVechicle(bus1);
            AirPlane airPlane = handler.CreateAirPlane(200, 1996, "Airbus", "V900", "White", "X170");
            ParkVechicle(airPlane);
            AirPlane airPlane1 = handler.CreateAirPlane(500, 2015, "Boeing", "797", "White", "A1709");
            ParkVechicle(airPlane1);
            Car car = handler.CreateCar(4, 2015, "Renault", "Frenchie", "Black", "LeBag");
            ParkVechicle(car);
            Car car1 = handler.CreateCar(3, 1970, "Fiat", "Pumpa", "Red", "1850PE");
            ParkVechicle(car1);
            Car car2 = handler.CreateCar(4, 1982, "Ferrari", "Testarosa", "White", "Vice");
            ParkVechicle(car2);
            MotorCycle mc = handler.CreateMotorCycle(9, 2015, "Mitsubishi", "Yappo", "Black", "Buzz157");
            ParkVechicle(mc);
            Boat boat = handler.CreateBoat(500, 2010, "Storebror", "U50", "White", "UMO567");
            ParkVechicle(boat);
        }

        public Garage<IVehicle> CreateGarage(int parkingSlots)
        {
            Garage<IVehicle> output = new Garage<IVehicle>(parkingSlots);
            return output;

        }
        public void ParkVechicle(IVehicle vehicle)
        {
            var found = garage.FirstOrDefault(v => v.LicencePlate == vehicle.LicencePlate);
            if (found == null)
            {
                garage.Add(vehicle);
                ui.Print("Vehicle has been successfully parked");
                Console.ReadLine();
            }
            else 
            {
                ui.Clear();
                ui.Print("There is already a vehicle with that licenceplate parked in the Garage");
                ui.GetInput();
            }
        }
        public void PickUpVechicle(string regNo)
        {
            var found = garage.FirstOrDefault(v => v.LicencePlate == regNo);
            if (found != null)
            {
                garage.CheckOut(found);
                ui.Print("Your Vehicle has been Extracted");
                ui.GetInput();
            }       
            else
            {
                ui.Print($"{regNo} does not belong to a vehicle parked here, or you typed in the wrong Licenceplate");
                ui.GetInput();
            }
        }
        public void SearchGarage(int yearSearch, string typeSearch, string makeSearch, string modelSearch, string colorSearch)
        {
            IEnumerable<IVehicle> res = garage;

            if (yearSearch != 1)
            {
                res = garage.Where(v => v.Year == yearSearch);
                                      
            }

            if (makeSearch != "x")
            {
                res = res.Where(v => v.Make.ToLower() == makeSearch.ToLower());
                              
            }
            if (typeSearch != "x")
            {
                res = res.Where(v => v.GetType().Name.ToLower() == typeSearch.ToLower());
            }
            
            if (modelSearch != "x")
            {
                res = res.Where(v => v.Model.ToLower() == modelSearch.ToLower());
                                  
            }
            if (colorSearch != "x")
            {
                res = res.Where(v => v.Color.ToLower() == colorSearch.ToLower());                          
            }
            ui.Clear();
            ui.Print("Search Results: \n");
            foreach (var v in res)              
            {
               Console.WriteLine(v.ToString());               
            }
            if (!res.Any())
            {
                ui.Clear();
                ui.Print("The Search did not return any results");
            }

            Console.ReadLine();
        }
        public void DisplayGarage()
        {
            if (garage.Count() > 0)
            {
                ui.Clear();
                ui.Print("Search Results: \n");
                garage.DisplayVehicles();
            }
            else
                    {
                        ui.Print("The garage is empty");
                    }
            Console.ReadLine();           
        }
    }
}
