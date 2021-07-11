// <copyright file="InternalTemperatureData.cs" company="BenjaminGaull195">
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
    /// <inheritdoc/>
    /// </summary>
    internal class InternalTemperatureData : TemperatureData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTemperatureData"/> class.
        /// </summary>
        /// <param name="temperature">Tempurate value.</param>
        /// <param name="units">Units used.</param>
        public InternalTemperatureData(double temperature, string units)
        {
            this.Temperature = temperature;
            this.Units = units;
        }
    }
}
