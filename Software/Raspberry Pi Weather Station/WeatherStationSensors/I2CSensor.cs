using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    public abstract class I2CSensor : Sensor
    {
        public I2CSensor(int I2CAddr) : base()
        {

        }
    }
}
