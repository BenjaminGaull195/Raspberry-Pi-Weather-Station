// <copyright file="HumidityData.cs" company="BenjaminGaull195">
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
    /// Contains humidity data.
    /// </summary>
    public abstract class HumidityData
    {
        /// <summary>
        /// Gets the Humidity percentage.
        /// </summary>
        public int Humidity { get; internal set; }
    }
}
