using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FactoryPattern
{
    public class Truck : IVehicle
    {
        public bool OwnedByTruckEnthusiast { get; set; }
        public int CarryingWeightLimit { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public double StockPrice { get; set; }
        public bool AWD { get; set; }

        public string Type = "Truck";

        public Truck ()
        {

        }
    }
}
