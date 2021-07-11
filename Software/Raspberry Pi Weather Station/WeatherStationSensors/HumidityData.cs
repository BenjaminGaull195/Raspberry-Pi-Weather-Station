using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    public abstract class HumidityData
    {
        public int Humidity { get; internal set; }
    }
}
