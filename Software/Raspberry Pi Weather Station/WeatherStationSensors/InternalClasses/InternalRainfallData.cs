// <copyright file="InternalRainfallData.cs" company="BenjaminGaull195">
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
    internal class InternalRainfallData : RainfallData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalRainfallData"/> class.
        /// </summary>
        /// <param name="value">Rainfall value.</param>
        /// <param name="units">Units used.</param>
        public InternalRainfallData(double value, string units)
        {
            this.Value = value;
            this.Units = units;
        }
    }
}
