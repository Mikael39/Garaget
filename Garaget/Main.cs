using Garaget.Helpers;
using Garaget.UI;
using Garaget.Vehicles;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    public class Main
    {

        private readonly IUI ui;
        


        public Main(IUI ui)
        {
            this.ui = ui;
            
        }

        public void Run()
        {
            bool res;
            int n;
            do
            {
                ui.Print($"Welcome, initialize a new Garage by entering Max capacity with numbers: ");
                ui.Input("Input: ");
                res = int.TryParse(ui.GetInput(), out n);
             
            } while (res == false);
            var gHandler = new GarageHandler(n, ui);
            var vHandler = new VehicleHandler();
            Garage<IVehicle> garaget = gHandler.CreateGarage(n);                       
            Menus.ShowMainMeny(ui);

            try
            {
                do
                {
                    Console.Clear();
                    Menus.ShowMainMeny(ui);
                    string input = ui.GetInput().ToUpper();
                   
                    switch (input)
                    {
                        case MenyHelpers.Park:
                            if (garaget.IsFull)
                            {
                                ui.Print("The Garage is full, please come back again some other time");
                                ui.GetInput();
                                break;
                            }
                            else                                                         
                            Menus.TypeOfVehicle(ui);                           
                            int p = UserInteraction.SpecifyType(ui);
                            int year = UserInteraction.Year(ui);
                            string make = UserInteraction.Make(ui);
                            string model = UserInteraction.Model(ui);
                            string color = UserInteraction.Color(ui);
                            string licencePlate = UserInteraction.LicencePlate(ui);
                            
                            switch (p)
                            {
                                case 1:
                                    int wheels = UserInteraction.NumberOfWheels(ui);
                                    Car car = vHandler.CreateCar(wheels, year, make, model, color, licencePlate);
                                    gHandler.ParkVechicle(car);
                                    break;
                                case 2:
                                    int tickets = UserInteraction.NumberOfTrafficViolations(ui);
                                    MotorCycle mc = vHandler.CreateMotorCycle(tickets, year, make, model, color, licencePlate);
                                    gHandler.ParkVechicle(mc);
                                    break;
                                case 3:
                                    int horsePower = UserInteraction.HorsePower(ui);
                                    Boat boat = vHandler.CreateBoat(horsePower, year, make, model, color, licencePlate);
                                    gHandler.ParkVechicle(boat);
                                    break;
                                case 4:
                                    int seats = UserInteraction.NumberOfSeats(ui);
                                    AirPlane airPlane = vHandler.CreateAirPlane(seats, year, make, model, color, licencePlate);
                                    gHandler.ParkVechicle(airPlane); 
                                    break;
                                case 5:
                                    int doors = UserInteraction.NumberOfDoors(ui);
                                    Bus bus = vHandler.CreateBus(doors, year, make, model, color, licencePlate);
                                    gHandler.ParkVechicle(bus);
                                    break;
                                default:

                                break;
                            }

                            break;
                        case MenyHelpers.Pickup:
                            string licence = UserInteraction.LicencePlate(ui);
                            gHandler.PickUpVechicle(licence);
                            break;
                        case MenyHelpers.SeedGarage:
                            gHandler.SeedGarage();
                            break;
                        case MenyHelpers.SearchGarage:
                            //if (garaget.IsEmpty) { ui.Print("The Garage is Empty"); ui.GetInput(); break; }
                            //else
                            //{
                                var yearSearch = UserInteraction.YearSearch(ui);
                                string typeSearch = UserInteraction.TypeSearch(ui);
                                string makeSearch = UserInteraction.MakeSearch(ui);
                                string modelSearch = UserInteraction.ModelSearch(ui);
                                string colorSearch = UserInteraction.ColorSearch(ui);

                                gHandler.SearchGarage(yearSearch, typeSearch, makeSearch, modelSearch, colorSearch);
                           // }
                            break;
                        case MenyHelpers.DisplayEntities:
                            gHandler.DisplayGarage();
                            break;
                        case MenyHelpers.Quit:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                  
                
                } while (true);
             

            }
            catch (ArgumentException ex)
            {
                ui.Print(ex.Message);
                Console.ReadLine();
            }
        }

    }


}

