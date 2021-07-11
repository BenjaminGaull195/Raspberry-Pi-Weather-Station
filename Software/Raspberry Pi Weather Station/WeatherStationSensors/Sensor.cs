// <copyright file="Sensor.cs" company="BenjaminGaull195">
// Copyright (c) BenjaminGaull195. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    /// <summary>
    /// Abstract base class for a sensor.
    /// </summary>
    public abstract class Sensor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sensor"/> class.
        /// </summary>
        public Sensor()
        {
        }

        /// <summary>
        /// Bitmask enum values for supported sensor types.
        /// </summary>
        public enum SensorType
        {
            /// <summary>
            /// No Sensor Type
            /// </summary>
            None = 0,

            /// <summary>
            /// Temperature Sensor
            /// </summary>
            Temperature = 1,

            /// <summary>
            /// Pressure Sensor
            /// </summary>
            Pressure = 2,

            /// <summary>
            /// Humidity Sensor
            /// </summary>
            Humidity = 4,

            /// <summary>
            /// Wind Vane Sensor
            /// </summary>
            WindVane = 8,

            /// <summary>
            /// Anemometer Sensor
            /// </summary>
            Anemometer = 16,

            /// <summary>
            /// UV Light Sensor
            /// </summary>
            UVSensor = 32,

            /// <summary>
            /// Air Quality Sensor
            /// </summary>
            AirQuality = 64,
        }

        /// <summary>
        /// Gets the bitmask used to determine what functionallity a sensor provides.
        /// </summary>
        public abstract SensorType SensorTypeMask { get; }

        /// <summary>
        /// Gets the name of the sensor.
        /// </summary>
        public abstract string SensorName { get; }
    }
}
