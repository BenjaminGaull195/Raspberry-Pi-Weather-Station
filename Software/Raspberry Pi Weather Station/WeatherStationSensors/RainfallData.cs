// <copyright file="RainfallData.cs" company="BenjaminGaull195">
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
    /// Contains rainfall data.
    /// </summary>
    public abstract class RainfallData
    {
        /// <summary>
        /// Gets the rainfall value.
        /// </summary>
        public double Value { get; internal set; }

        /// <summary>
        /// Gets the units of measurements.
        /// </summary>
        public string Units { get; internal set; }
    }
}
