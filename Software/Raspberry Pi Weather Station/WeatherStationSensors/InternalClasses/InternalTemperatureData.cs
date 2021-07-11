using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    internal class InternalTemperatureData : TemperatureData
    {
        public InternalTemperatureData(double Temperature, string Units)
        {
            this.Temperature = Temperature;
            this.Units = Units;
        }
    }
}
