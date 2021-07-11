using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    public abstract class PressureData
    {
        public double Pressure { get; internal set; }
        public string Units { get; internal set; }
    }
}
