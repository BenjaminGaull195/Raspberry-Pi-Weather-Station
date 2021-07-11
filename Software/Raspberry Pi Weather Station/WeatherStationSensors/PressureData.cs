// <copyright file="PressureData.cs" company="BenjaminGaull195">
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
    /// Contains pressure data.
    /// </summary>
    public abstract class PressureData
    {
        /// <summary>
        /// Gets the Pressure value.
        /// </summary>
        public double Pressure { get; internal set; }

        /// <summary>
        /// Gets the units of measurement.
        /// </summary>
        public string Units { get; internal set; }
    }
}
