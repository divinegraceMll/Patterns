using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // Concrete Product 1
    internal class Car:IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }
}
