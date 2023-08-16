using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_homework
{
    class AirVehicle : Vehicle
    {
        public double FuelCapacity { get; set; }
        public AirVehicle(int year, decimal price, double fuelCapacity)
           : base(year, price)
        {
            FuelCapacity = fuelCapacity;
        }
        public void Fly()
        {
            Console.WriteLine("Taking off!");
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"fuel tank capacity: {FuelCapacity} liters ");
        }
    }
}
