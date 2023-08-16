using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_homework
{
    class BMW : Disel
    {
        public BMW(int year, decimal price, int numberOfDoors, double maxSpeed)
                   : base(year, price, numberOfDoors, maxSpeed)
        {

        }
    }
}
