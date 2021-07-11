// <copyright file="InternalWindspeedData.cs" company="BenjaminGaull195">
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
    internal class InternalWindSpeedData : WindSpeedData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalWindSpeedData"/> class.
        /// </summary>
        /// <param name="speed">Speed of the wind.</param>
        /// <param name="units">Units used.</param>
        public InternalWindSpeedData(double speed, string units)
        {
            this.Speed = speed;
            this.Units = units;
        }
    }
}
