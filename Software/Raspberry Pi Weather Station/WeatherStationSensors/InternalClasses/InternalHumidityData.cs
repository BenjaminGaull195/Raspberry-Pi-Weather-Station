// <copyright file="InternalHumidityData.cs" company="BenjaminGaull195">
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
    internal class InternalHumidityData : HumidityData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalHumidityData"/> class.
        /// </summary>
        /// <param name="humidity">Humidity percentage.</param>
        public InternalHumidityData(int humidity)
        {
            this.Humidity = humidity;
        }
    }
}
