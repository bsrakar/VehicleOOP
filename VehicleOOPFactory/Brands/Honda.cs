using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOPFactory
{
    public class Honda : Car, IMotorcycle
    {
        private Motorcycle _moto = new Motorcycle();
        
        public Honda()
        {
            Brand = "Honda";
        }

        string IMotorcycle.Move()
        {
            _moto.Brand = "Honda";
            return _moto.Move();
        }      
    }
}
