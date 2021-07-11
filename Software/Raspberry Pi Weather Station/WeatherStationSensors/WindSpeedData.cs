using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    public abstract class WindSpeedData
    {
        public double Speed { get; internal set; }
        public string Units { get; internal set; }
    }
}
