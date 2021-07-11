// <copyright file="InternalPressureData.cs" company="BenjaminGaull195">
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
    internal class InternalPressureData : PressureData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalPressureData"/> class.
        /// </summary>
        /// <param name="pressure">Pressure value.</param>
        /// <param name="units">Units Used.</param>
        public InternalPressureData(double pressure, string units)
        {
            this.Pressure = pressure;
            this.Units = units;
        }
    }
}
