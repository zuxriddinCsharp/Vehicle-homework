using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_homework
{
    class Tesla : Electric
    {
        public Tesla(int year, decimal price, int numberOfDoors, double battareyCapacitty)
        : base(year, price, numberOfDoors, battareyCapacitty)
        {

        }
    }
}
