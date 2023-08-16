using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_homework
{
    class Electric : Car
    {
        public double BattareyCapacity { get; set; }
        public Electric(int year, decimal price, int numberOfDoors, double battareyCapacitty)
            : base(year, price, numberOfDoors)
        {
            BattareyCapacity = battareyCapacitty;
        }
        public void ChargeBattarey()
        {
            Console.WriteLine("Charging the battery.");
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Gross battery capacity: {BattareyCapacity} kWh");
        }
    }
}
