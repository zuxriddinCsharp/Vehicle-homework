using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_homework
{
    class Helicopter : AirVehicle
    {
        public int NumberOfSeats { get; set; }

        public Helicopter(int year, decimal price, double fuelCapacity, bool hasBusinessClass, int numberOfSeats)
            : base(year, price, fuelCapacity)
        {
            NumberOfSeats = numberOfSeats;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of seats: {NumberOfSeats}");
        }
    }
}
