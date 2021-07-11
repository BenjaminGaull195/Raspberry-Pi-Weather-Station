using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    public interface IHumiditySensor
    {
        public HumidityData GetHumidity();
    }
}
