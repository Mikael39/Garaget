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
                    year = value;
            }
        }



        public string Make
        {
            get { return make; }
            set
            {              
                    make = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {             
                    model = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
            }
        }
        public string LicencePlate
        {
            get { return licencePlate; }
            set
            {          
                    licencePlate = value;
            }
        }

        public Vehicle(int year, string make, string model, string color, string licencePlate)
        {
            this.year = year;
            this.make = make;
            this.model = model;
            this.color = color;
            this.licencePlate = licencePlate;
        }
    }

}
