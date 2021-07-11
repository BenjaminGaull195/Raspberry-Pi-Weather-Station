using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    internal class InternalPressureData : PressureData
    {
        public InternalPressureData(double Pressure, string Units)
        {
            this.Pressure = Pressure;
            this.Units = Units;
        }
    }
}
