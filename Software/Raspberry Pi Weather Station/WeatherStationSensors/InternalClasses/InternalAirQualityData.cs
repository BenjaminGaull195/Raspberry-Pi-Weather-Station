// <copyright file="InternalAirQualityData.cs" company="BenjaminGaull195">
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
    internal class InternalAirQualityData : AirQualityData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalAirQualityData"/> class.
        /// </summary>
        /// <param name="particulateName">Name of the particulate.</param>
        /// <param name="value">Ammount of the particulate.</param>
        /// <param name="units">Units used.</param>
        public InternalAirQualityData(string particulateName, int value, string units)
        {
            this.ParticulateName = particulateName;
            this.Value = value;
            this.Units = units;
        }
    }
}
