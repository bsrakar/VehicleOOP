using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOPFactory
{
    public interface IMotorcycle : IVehicle
    {
        new string Move();
    }
}
