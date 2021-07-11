using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    internal class InternalHumidityData : HumidityData
    {
        InternalHumidityData(int Humidity)
        {
            this.Humidity = Humidity;
        }
    }
}
