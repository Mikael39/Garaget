using Garaget.Helpers;
using Garaget.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    public class Main
    {

        private readonly IUI ui;
        //Main main = new Main(ui);


        public Main(IUI ui)
        {
            this.ui = ui;
            
        }

        public void Run()
        {
          

            do
            {
                Menus.ShowMainMeny();
                string input = ui.GetInput().ToUpper();
                int n = 5;

                GarageHandler handler = new GarageHandler();
                handler.

                //switch (input)
                //{
                //    case MenyHelpers.Add:
                //        AddEmployee();
                //        break;
                //    case MenyHelpers.Print:
                //        PrintEmployees();
                //        break;
                //    case MenyHelpers.Quit:
                //        Environment.Exit(0);
                //        break;
                //    default:
                //        break;
                //}


            } while (true);
        }

        //private void AddEmployee()
        //{
        //    string name = Util.AskForString("Name", ui);
        //    uint salary = Util.AskForUInt("Salary", ui);

        //    garage.AddEmployee(name, salary);
        //}

        //private void PrintEmployees()
        //{
        //    IEnumerable<Employee> employees = payRoll.GetEmployees();

        //    foreach (Employee employee in employees)
        //    {
        //        ui.Print(employee.ToString());
        //        // Console.WriteLine("Name: " + employee.Name + "Salary: " + employee.Salary);
        //    }
        //}





        //private void SeedData()
        //{
        //    payRoll.AddEmployee("Anna", 30000);
        //    payRoll.AddEmployee("Bengt", 50000);
        //    payRoll.AddEmployee("Pelle", 60000);
        //    payRoll.AddEmployee("Sara", 70000);
        //}
    }


}

