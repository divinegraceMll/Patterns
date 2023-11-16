using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // Concrete Creator 1
    internal class CarFactory:IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
