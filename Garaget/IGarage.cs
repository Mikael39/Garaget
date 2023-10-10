using Garaget.Vehicles;
using System.Collections;

namespace Garaget
{
    public interface IGarage<T>: IEnumerable<T> where T : IVehicle
    {
        int CurrentParked { get; }
        bool IsEmpty { get; }
        bool IsFull { get; }

        void Add(T vehicle);
        void CheckOut(T found);
        void DisplayVehicles();
    }

    public class DataBaseGarage<T> : IGarage<T> where T : IVehicle
    {
        public int CurrentParked => throw new NotImplementedException();

        public bool IsEmpty => throw new NotImplementedException();

        public bool IsFull => throw new NotImplementedException();

        public void Add(T vehicle)
        {
            throw new NotImplementedException();
        }

        public void CheckOut(T found)
        {
            throw new NotImplementedException();
        }

        public void DisplayVehicles()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}