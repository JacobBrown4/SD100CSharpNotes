using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void PropertiesTest()
        {
            Vehicle firstVehicle = new Vehicle();

            firstVehicle.Make = "Nissan";

            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Skyline";
            firstVehicle.Mileage = 20000;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine($"My car is a {firstVehicle.Make} {firstVehicle.Model} with {firstVehicle.Mileage} miles on it.");

        }
    }
}
