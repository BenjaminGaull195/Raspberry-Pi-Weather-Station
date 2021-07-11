﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    public interface IAirQualitySensor
    {
        public int GetAirQuality();

        public IEnumerable<AirQualityData> GetAirQualityDetailed();
    }
}
