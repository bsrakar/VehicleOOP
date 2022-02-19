using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOPFactory
{
    public class Motorcycle : IMotorcycle
    {
        public string Brand { get; set; }

        public string Move()
        {
            return "You are driving a motorcycle from " + Brand;
        }
    }
}
