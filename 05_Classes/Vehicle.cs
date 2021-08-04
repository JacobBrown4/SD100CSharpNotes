using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car, Truck, Van, Spaceship, Plane}
    public class Vehicle
    {
        //1 Access modifier => Where can this be seen?
        //2 Type => Type of the property as a held value
        //3 Name => Name of the property method, Pascal case
        //4 Getters and Setters

        // 1     2     3    4
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
    }
}
