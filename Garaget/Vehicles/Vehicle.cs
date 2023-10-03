using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.Vehicles
{
    public class Vehicle : IVehicle
    {

        private int year;
        private string make;
        private string model;
        private string color;
        private string licencePlate;


        public int Year
        {
            get { return year; }

            set
            {

                if (value < 1900 || value > 2023)

                    throw new ArgumentException("Year is out of bounds");
                else
                    year = value;
            }
        }



        public string Make
        {
            get { return make; }
            set
            {
                if (value.Length < 3 || value.Length > 10)

                    throw new ArgumentException("Make must be between 3 and 10 signs");
                else
                    make = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length < 2 || value.Length > 12)

                    throw new ArgumentException("Model must be between 2 and 12 signs");
                else
                    model = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                var colors = new List<string> { "black", "white", "brown", "green", "blue", "red", "grey", "beige", "yellow", "orange" };
                string x = value;
                bool contains = colors.Contains(x, StringComparer.OrdinalIgnoreCase);
                if (contains)
                    color = value;
                else
                    throw new ArgumentException("input a normal color");

            }
        }
        public string LicencePlate
        {
            get { return licencePlate; }
            set
            {
                if (value.Length < 2 || value.Length > 8)
                    throw new ArgumentException("Your sign must have mininumum two signs, at most seven signs");
                else
                    licencePlate = value;
            }
        }

        public Vehicle(int year, string make, string model, string color, string licencePlate)
        {
            Year = year;
            Make = make;
            Model = model;
            Color = color;
            LicencePlate = licencePlate;
        }
    }

}
