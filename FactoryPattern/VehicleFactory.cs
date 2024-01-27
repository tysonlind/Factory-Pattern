using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class VehicleFactory
    {
        public VehicleFactory() { }

        public static IVehicle GetVehicle( int numWheels, bool awd)
        {

            if (awd)
            {
                return new Truck();
            } else if (numWheels == 4)
            {
                return new Car();
            } else if (numWheels == 2)
            {
                return new Motorcycle();
            } else
            {
                throw new Exception("invalid input");
            }
        }
    }
}
