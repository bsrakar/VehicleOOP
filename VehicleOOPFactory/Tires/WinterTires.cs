using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOPFactory
{
    public class WinterTires : Tires
    {
        public float MinTemp { get; private set; }
        public float Thickness { get; private set; }

        public float GetPressure
        {
            get => Pressure;
        }

        public WinterTires(float pressure, float minTemp, float thickness)
        {
            this.Pressure = pressure;
            this.MinTemp = minTemp;
            this.Thickness = thickness;
        }

        public override string GetTiresInfo()
        {
            return $"Your winter tires consist of pressure {Pressure}, minimum temperature {MinTemp} and thickness {Thickness}";
        }
    }
}
