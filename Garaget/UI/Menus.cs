using Garaget.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.UI
{
    public class Menus
    {
        private readonly IUI ui;

        public Menus(IUI ui)
        { this.ui = ui; }
        public static void ShowMainMeny(IUI ui)
        {
            ui.Print("--Welcome to Garage Check in--\n");
            ui.Print($"{MenyHelpers.Park}: Park a Vehicle");
            ui.Print($"{MenyHelpers.Pickup}: Pickup a Vehicle");
            ui.Print($"{MenyHelpers.SeedGarage}: Seed a Garage");
            ui.Print($"{MenyHelpers.SearchGarage}: Search the Garage");
            ui.Print($"{MenyHelpers.DisplayEntities}: Show current parked");
            ui.Print($"{MenyHelpers.Quit}: Quit");
            ui.Input("Input: ");

        }

        public static void TypeOfVehicle(IUI ui)
        {
            ui.Print("--Which type of Vehicle would you like to check in--\n");
            ui.Print($"{Choice.Car}: Car");
            ui.Print($"{Choice.MotorCycle}: MotorCycle");
            ui.Print($"{Choice.Boat}: Boat");
            ui.Print($"{Choice.AirPlane}: AirPlane");
            ui.Print($"{Choice.Bus}: Bus");
            ui.Input("Input: ");

        }


    }
}
