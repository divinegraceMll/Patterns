using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // Concrete Creator 2
    internal class MotorcycleFactory:IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Motorcycle();
        }
    }
}
