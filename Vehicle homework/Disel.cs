using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_homework
{
    class Disel : Car
    {
        public double MaxSpeed { get; set; }
        public Disel(int year, decimal price, int numberOfDoors, double maxSpeed)
            : base(year, price, numberOfDoors)
        {
            MaxSpeed = maxSpeed;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Maximum speed:  {MaxSpeed} km/h");
        }
    }
}
