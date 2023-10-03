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
            ui.Print("--Welcome to Garage Check in--\n\n");
            ui.Print($"{MenyHelpers.Add}: Setup a Garage and Fill it with Vehicles");
            ui.Print($"{MenyHelpers.Print}: Add Garage");
            ui.Print($"{MenyHelpers.Quit}: Park a Vehicle");
            ui.Print($"{MenyHelpers.Quit}: Pickup Vehicle from Garage");
            ui.Print($"{MenyHelpers.Quit}: Search Functions");

        }


    }
}
