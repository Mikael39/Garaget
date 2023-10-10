namespace Garaget.Garage.Test
{
    using Garaget.UI;
    using Garaget.Vehicles;
    public class GarageTest
    {
        [Fact]
        public void AddObjecToArrayAddToCounter()
        {
            // Arrange
         

            Garage<IVehicle> garage1 = new Garage<IVehicle>(15);
         
            garage1.Add(new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU112"));
            garage1.Add(new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU143"));
            garage1.Add(new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU154"));
            garage1.Add(new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU156"));
            garage1.Add(new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU157"));
            garage1.Add(new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU158"));
            garage1.Add(new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU159"));
            garage1.Add(new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU151"));
            garage1.Add(new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU152"));
        
           
            Car car3 = new Car(4, 1980, "Toyota", "Bumbum", "Red", "GBG12");
           
            int expected = 10;

            // Act
            garage1.Add(car3);

            // Assert
            Assert.Equal(expected, garage1.CurrentParked);
        }

        [Fact]
        public void RemoveObjectFromArraySubtractCounter()

        {
           // Arrange
            
            Garage<IVehicle> garage = new Garage<IVehicle>(10);
          
            garage.Add(new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU112"));
            garage.Add(new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU143"));
            garage.Add(new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU154"));
            garage.Add(new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU156"));
            Car car3 = new Car(4, 1950, "Toyota", "Prius", "Blue", "IOU156");
            garage.Add(car3);

            int expected = 4;

            // Act
            garage.CheckOut(car3);

            // Assert
            Assert.Equal(expected, garage.CurrentParked);
        }

        [Fact]
        public void Add_ShouldTrowIfNull()
        {
            var g = new Garage<Vehicle>(2);
            Assert.Throws<ArgumentNullException>(() => g.Add(null));
        }
        
        
        [Fact]
        public void Add_ShouldTrowIfNull2()
        {
            var g = new Garage<Vehicle>(2);
            g.Add(new Car(3, 4, "", "", "", ""));

            Assert.Equal(1, g.Count());
        }


    }
}