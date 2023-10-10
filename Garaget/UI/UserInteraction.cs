using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garaget.Vehicles;
using Garaget.Helpers;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Garaget.UI
{
    public class UserInteraction 
    {             
        private IUI ui;       
        public UserInteraction(IUI ui)
        {
            this.ui = ui;
        }

        public static int SpecifyType(IUI ui)
        {                    
            do
            {
                int pick;
                string input = ui.GetInput().ToUpper();
                switch (input)
                {
                    case Choice.Boat:
                        pick = 3;
                        return pick;
                    case Choice.AirPlane:
                        pick = 4;
                        return pick;
                    case Choice.Car:
                        pick = 1;
                        return pick;
                    case Choice.MotorCycle:
                        pick = 2;
                        return pick;
                    case Choice.Bus:
                        pick = 5;
                        return pick;
                    default:
                        ui.Print("Please enter some valid input (1, 2, 3, 4 or 5)");
                        break;
                        
                }
                
            } while (true);
            


        }

        public static string Color(IUI ui)
        {
            bool run;
            string returnValue;
            do
            {
                run = true;
                ui.Print("Please enter the color of the vehicle that you would like to Park");
                ui.Input("Input: ");
                returnValue = ui.GetInput();
                var colors = new List<string> { "black", "white", "brown", "green", "blue", "red", "grey", "beige", "yellow", "orange" };
                bool contains = colors.Contains(returnValue, StringComparer.OrdinalIgnoreCase);
                if (!contains)
                {
                    ui.Clear();
                    ui.Print("input a normal color");
                    run = false;
                }

            } while (run == false);
            return returnValue;
            
                
        }
        public static string LicencePlate(IUI ui)
        {
            bool run;
            string licencePlate;
            do
            {
                run = true;
                ui.Print("Please enter the Licenceplate of the vehicle that you would like to Park");
                ui.Input("Input: ");
                licencePlate = ui.GetInput();
                if (licencePlate.Length < 2 || licencePlate.Length > 8)
                {
                    ui.Clear();
                    ui.Print("Your sign must have mininumum two signs, at most seven signs");
                    run = false;
                }
            } while (run == false);
            
                return licencePlate;
        }

        public static int Year(IUI ui)
        {
            bool run;
            bool res;
            int year;
            do
            {
                run = true;
                ui.Print("Please enter the manufactured year of the vehicle that you would like to Park");
                ui.Input("Input: ");
                res = int.TryParse(ui.GetInput(), out year);
                if (year < 1900 || year > 2023)
                {
                    ui.Clear();
                    ui.Print("Use correct year input, your vehicle needs to be manufactured after 1900 or before 2024");
                    run = false;
                }
                
            } while (run == false || res == false);
            
                return year;
        }
        public static string Make(IUI ui)
        {
            bool run;
            string make;
            do
            {
                run = true;
                ui.Print("Please enter the make of the vehicle that you would like to Park");
                ui.Input("Input: ");
                make = ui.GetInput();
                if (make.Length < 3 || make.Length > 10)
                {
                    ui.Clear();
                    ui.Print("Make must be between 3 and 10 signs");
                    run = false;
                }
                
            } while (run == false);
                return make;
        }
        public static string Model(IUI ui)
        {
            string model;
            bool run;
            do
            {
                run = true;
                ui.Print("Please enter the model of the vehicle that you would like to Park");
                ui.Input("Input: ");
                model = ui.GetInput();
                if (model.Length < 2 || model.Length > 12)
                {
                    ui.Clear();
                    ui.Print("Model must be between 2 and 12 signs");
                    run = false;
                }

            }while(run == false);
                return model;
        }


         public static int NumberOfTrafficViolations(IUI ui) 
        {
            bool run;
            bool res;
            int numberOfTrafficViolations;
            do
            {
                run = true;
                ui.Print("Please enter the number of traffic violations you have commited with your Motorcycle");
                ui.Input("Input: ");
                res = int.TryParse(ui.GetInput(), out numberOfTrafficViolations);
                if (numberOfTrafficViolations > 10)
                {
                    ui.Clear();
                    ui.Print("Sorry our insurance does not cover your MotorCycle");
                    run = false;
                }
                
                    
            }while(run == false || res == false);

            return numberOfTrafficViolations;
        }
        public static int NumberOfSeats(IUI ui)
        {
            bool run;
            bool res;
            int seats;
            do
            {
                run = true;
                ui.Print("Please enter the number of seats of the airplane that you would like to Park");
                ui.Input("Input: ");
                res = int.TryParse(ui.GetInput(), out seats);
                if (seats < 2 || seats > 500)
                {
                    ui.Clear();
                    ui.Print("An airplane has a minimum of 2 seats and a maxiumum of 500 seats");
                    ui.Input("Input: ");
                    run = false;
                }
            } while (run == false || res == false);
            return seats;
        }

        public static int HorsePower(IUI ui)
        {
            bool run;
            bool res;
            int hp;
            do
            {
                run = true;
                ui.Print("Please enter the total horsepower of the boat that you would like to Park");
                ui.Input("Input: ");
                res = int.TryParse(ui.GetInput(), out hp);
                if (hp < 5 || hp > 1000)
                {
                    ui.Clear();
                    ui.Print("We dont park Rowboats or ships ");
                    run = false;
                } 
            } while (run == false || res == false);
            return hp;
        }

        public static int NumberOfDoors(IUI ui)
        {
            bool run;
            bool res;
            int doors;
            do
            {
                run = true;
                ui.Print("Please enter the number of doors of the bus that you would like to Park");
                ui.Input("Input: ");
                res = int.TryParse(ui.GetInput(), out doors);
                if (doors < 2 || doors > 4)
                {
                    ui.Clear();
                    ui.Print("A Bus tends to have no less than 2 doors and no more than 4 doors ");
                    run = false;
                }
            } while (run == false || res == false);
            return doors;
        }

        public static int NumberOfWheels(IUI ui)
        {
            bool run;
            bool res;
            int wheels;
            do
            {
                run = true;
                ui.Print("Please enter the number of wheels of the car that you would like to Park");
                ui.Input("Input: ");
                res = int.TryParse(ui.GetInput(), out wheels);
                if (wheels < 3 || wheels > 4)
                {
                    ui.Clear();
                    ui.Print("A car tends to have 4 wheels, sometimes 3 but no more, no less");
                    res = false;
                }
            } while (run == false || res == false);
            return wheels;
        }

        public static int YearSearch(IUI ui)
        {
           

            bool run;
            bool res;
            int year;
            do
            {
                
                run = true;
                ui.Print("-- If you do not want to search for year of the Vehicle ENTER a 1--\n");
                ui.Print("-- Otherwise enter the manufactured year of the vehicle that you would like to search for--");
                ui.Input("Input: ");
                res = int.TryParse(ui.GetInput(), out year);
                if (year == 1)
                {
                    return year;
                }

                if (year < 1900 || year > 2023)
                {
                    ui.Clear();
                    ui.Print("Use correct year input, Either enter 1 to skip or select a year between 1900 and 2024");
                    ui.Input("Input: ");
                    run = false;
                }

            } while (run == false || res == false);

            return year;
        }

        public static string TypeSearch(IUI ui)
        {

            string type;
            bool run;
            do
            {
                
                ui.Print("-- If you do not want to search for type of Vehicle just enter: X --");
                ui.Print("   Otherwise enter the type ofvehicle that you would like to search for");
                ui.Input("Input: ");
                type = ui.GetInput().ToLower();
                if (type == "airplane" || type == "bus" || type == "car" || type == "boat" || type == "motorcycle" || type == "x")
                {
                    return type;
                }
                else
                    ui.Clear();
                    ui.Print("We only park Airplane, Bus, Car, Boat or Motorcycle type of Vehicles here");
                
                run = false;
                
            
            } while (run == false);

            return type;
        }

        public static string MakeSearch(IUI ui)
        {
            string make;
            bool run;

            do
            {
                run = true;
                ui.Print("-- If you do not want to search for Make of Vehicle just enter: X --");
                ui.Print("    Otherwise enter the make of the vehicle that you would like to search for");
                ui.Input("Input: ");
                make = ui.GetInput();
                if (make == "x")
                    return make;
                if (make.Length < 3 || make.Length > 10)
                {
                    ui.Print("Make must be between 3 and 10 signs");
                    run = false;
                }
            } while (run == false);
            
                return make;
        }

        public static string ModelSearch(IUI ui)
        {
            string model;
            bool run;

            do
            {
                run = true;
                ui.Print("-- If you do not want to search for Model of Vehicle just enter: X --");
                ui.Print("    Otherwise enter the model of the vehicle that you would like to search for");
                ui.Input("Input: ");
                model = ui.GetInput();
                if (model == "x")
                    return model;
                if (model.Length < 2 || model.Length > 12)
                {

                    ui.Print("Model must be between 2 and 12 signs");
                    run = false;
                }
            }while(run == false);   
                    return model;
        }

        public static string ColorSearch(IUI ui)
        {

            bool run;
            string returnValue;
            do
            {
                run = true;
                ui.Print("-- If you do not want to search for Color of the Vehicle just enter: X --");
                ui.Print("    Otherwise Please enter the color of the vehicle that you would like search for");
                ui.Input("Input: ");
                returnValue = ui.GetInput();
                var colors = new List<string> { "x", "black", "white", "brown", "green", "blue", "red", "grey", "beige", "yellow", "orange" };
                bool contains = colors.Contains(returnValue, StringComparer.OrdinalIgnoreCase);
                if (!contains)
                {
                    ui.Print("input a normal color");
                    run = false;
                }

            } while (run == false);
                return returnValue;
            
        }
    }
}
