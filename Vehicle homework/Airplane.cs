﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_homework
{
    class Airplane : AirVehicle
    {
        public bool HasBusinessClass { get; set; }

        public Airplane(int year, decimal price, double fuelCapacity, bool hasBusinessClass)
            : base(year, price, fuelCapacity)
        {
            HasBusinessClass = hasBusinessClass;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();

            if (HasBusinessClass == true)
            {
                Console.WriteLine("There is a business class");
            }
            else
            {
                Console.WriteLine("Тo business class");
            }
        }
    }
}
