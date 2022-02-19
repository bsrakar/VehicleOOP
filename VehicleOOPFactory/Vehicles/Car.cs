using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOPFactory
{
    public class Car : ICar
    {
        public Tires CarTires { get; set; } = new SummerTires((float)2.5, 50);
        public string Brand { get ; set ; }

        public string Move()
        {
            return "You are driving a car from " + Brand;
        }
    }
}
