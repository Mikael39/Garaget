using Garaget.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.UI
{
    public interface IGarage
    {
        void ParkVehicle(Vehicle vehicle);      
        void RemoveVehicle(Vehicle vehicle);
        

    }
}
