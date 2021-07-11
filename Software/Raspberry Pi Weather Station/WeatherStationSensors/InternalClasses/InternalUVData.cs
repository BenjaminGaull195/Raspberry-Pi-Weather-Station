using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    internal class InternalUVData : UVData
    {
        public InternalUVData(int UVIndex)
        {
            this.UVIndex = UVIndex;
        }
    }
}
