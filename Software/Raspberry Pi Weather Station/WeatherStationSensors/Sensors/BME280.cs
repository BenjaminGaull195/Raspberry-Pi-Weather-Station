// <copyright file="BME280.cs" company="BenjaminGaull195">
// Copyright (c) BenjaminGaull195. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors.Sensors
{
    /// <summary>
    /// Sensor class representing the BME280 Temperature, Humidity, and Pressure sensor.
    /// </summary>
    public class BME280 : I2CSensor, ITemperatureSensor, IPressure, IHumiditySensor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BME280"/> class.
        /// </summary>
        /// <param name="i2CAddr">Address of the sensor.</param>
        public BME280(int i2CAddr)
            : base(i2CAddr)
        {
        }

        /// <summary>
        /// Gets the bitmask for the sensor type.
        /// </summary>
        public override SensorType SensorTypeMask => SensorType.Temperature | SensorType.Pressure | SensorType.Humidity;

        /// <summary>
        /// Gets the name of the sensor.
        /// </summary>
        public override string SensorName => "BME280";

        /// <summary>
        /// Gets the Humidity data from the sensor.
        /// </summary>
        /// <returns><see cref="HumidityData"/> containing relevant Humidity data.</returns>
        public HumidityData GetHumidity()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the Pressure data from the sensor.
        /// </summary>
        /// <returns><see cref="PressureData"/> containing relevant Pressure data.</returns>
        public PressureData GetPressure()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the Temperature data from the sensor.
        /// </summary>
        /// <returns><see cref="TemperatureData"/> containing relevant Tempurature data.</returns>
        public TemperatureData GetTemperature()
        {
            throw new NotImplementedException();
        }
    }
}
