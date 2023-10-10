using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garaget.UI;
using Garaget.Vehicles;

namespace Garaget
{
    public class Garage<T> : IGarage<T> where T : IVehicle
    {
        private int TotalParkingSlots { get; init; }
        public int CurrentParked { get; private set; } = 0;      
        private T[] garaget;
    

        public bool IsFull => TotalParkingSlots <= CurrentParked;
        public bool IsEmpty => CurrentParked == 0;

        public Garage(int parkingSlots)
        {
            garaget = new T[parkingSlots];
            TotalParkingSlots = parkingSlots;
        }
        public void Add(T vehicle)
               
        {
            ArgumentNullException.ThrowIfNull(vehicle, nameof(vehicle));

            garaget[CurrentParked] = vehicle;
            CurrentParked++;

        }
        public IEnumerator<T> GetEnumerator()
        {

            foreach (T vehicle in garaget)
            {
                if (vehicle != null)
                    yield return vehicle;
            }
        }
        public void CheckOut(T found)
        {

            int index = Array.IndexOf(garaget, found);

            for (int i = index + 1; i < CurrentParked; i++)
            {
                garaget[i - 1] = garaget[i];
            }
            garaget[CurrentParked - 1] = default!;
            CurrentParked--;
        }
        public void DisplayVehicles()
        {
            garaget.Where(p => p != null)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));

        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
