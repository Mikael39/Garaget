using Garaget.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.UI
{

    public class ConsoleUI : IUI
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
        public void Input(string message)
        { Console.Write(message); }

        public string GetInput()
        {
            return Console.ReadLine()!;
        }

        public void Clear()
        {
            Console.Clear();
        }

     
    }
}
