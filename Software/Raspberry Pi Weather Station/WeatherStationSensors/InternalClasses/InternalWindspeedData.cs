using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    internal class InternalWindSpeedData : WindSpeedData
    {
        public InternalWindSpeedData(double Speed, string Units)
        {
            this.Speed = Speed;
            this.Units = Units;
        }
    }
}
