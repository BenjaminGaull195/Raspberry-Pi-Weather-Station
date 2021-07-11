// <copyright file="WindSpeedData.cs" company="BenjaminGaull195">
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
    /// Contains the wind speed data.
    /// </summary>
    public abstract class WindSpeedData
    {
        /// <summary>
        /// Gets the speed of the wind.
        /// </summary>
        public double Speed { get; internal set; }

        /// <summary>
        /// Gets the units used.
        /// </summary>
        public string Units { get; internal set; }
    }
}
