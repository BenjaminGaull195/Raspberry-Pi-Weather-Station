using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    internal class InternalAirQualityData : AirQualityData
    {
        InternalAirQualityData(string ParticulateName, int Value, string Units)
        {
            this.ParticulateName = ParticulateName;
            this.Value = Value;
            this.Units = Units;
        }
    }
}
