using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    public abstract class AirQualityData
    {
        public string ParticulateName { get; internal set; }
        public int Value { get; internal set; }
        public string Units { get; internal set; }
    }
}
