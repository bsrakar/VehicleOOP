using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOPFactory
{
    public class SummerTires : Tires
    {
        public float MaxTemp { get; private set; }

        public float GetPressure
        {
            get => Pressure;
        }

        public SummerTires(float pressure, float maxTemp)
        {
            this.Pressure = pressure;
            this.MaxTemp = maxTemp;
        }

        public override string GetTiresInfo()
        {          
            return $"Your summer tires consist of pressure {Pressure}, maximum temperature {MaxTemp}";
        }
    }
}
