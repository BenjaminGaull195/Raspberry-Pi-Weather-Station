// <copyright file="TemperatureData.cs" company="BenjaminGaull195">
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
    /// Contains Tempuratue data.
    /// </summary>
    public abstract class TemperatureData
    {
        /// <summary>
        /// Gets the Tempurate value.
        /// </summary>
        public double Temperature { get; internal set; }

        /// <summary>
        /// Gets the units of measurement.
        /// </summary>
        public string Units { get; internal set; }
    }
}
