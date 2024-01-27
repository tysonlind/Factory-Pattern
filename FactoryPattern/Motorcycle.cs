using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public int CarryingWeightLimit { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string Type = "Motorcycle";

        public bool AWD { get; set; }

        public Motorcycle ()
        {

        }

    }
}
