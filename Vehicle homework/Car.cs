using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_homework
{
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public Car(int year, decimal price, int numberOfDoors)
            : base(year, price)
        {
            NumberOfDoors = numberOfDoors;
        }
        public void StartEngine()
        {
            Console.WriteLine("Engine started:");
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of doors: {NumberOfDoors}");
        }
    }
}
