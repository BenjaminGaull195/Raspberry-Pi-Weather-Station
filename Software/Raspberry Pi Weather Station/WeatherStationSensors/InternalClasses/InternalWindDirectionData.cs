using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    internal class InternalWindDirectionData : WindDirectionData
    {
        public InternalWindDirectionData(string Direction)
        {
            this.Direction = Direction;
        }
    }
}
