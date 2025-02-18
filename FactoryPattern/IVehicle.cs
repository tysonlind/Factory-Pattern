﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public bool AWD { get; set; }

    }
}
