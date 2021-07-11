using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    internal class InternalRainfallData : RainfallData
    {
        public InternalRainfallData(double Value, string Units)
        {
            this.Value = Value;
            this.Units = Units;
        }
    }
}
