using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_homework
{
    class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public Motorcycle(int year, decimal price, bool hasSideCar)
            : base(year, price)
        {
            HasSideCar = hasSideCar;
        }
        public void Wheelie()
        {
            Console.WriteLine("Performing a wheelie!");
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            if (HasSideCar == true)
            {
                Console.WriteLine("sidecar available");
            }
            else
            {
                Console.WriteLine("sidecar not available");
                Wheelie();
            }
        }
    }
}
