// <copyright file="AirQualityData.cs" company="BenjaminGaull195">
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
    /// Contains the air quality details of a particular particulate.
    /// </summary>
    public abstract class AirQualityData
    {
        /// <summary>
        /// Gets the name of the particulate.
        /// </summary>
        public string ParticulateName { get; internal set; }

        /// <summary>
        /// Gets the ammout of the particulate.
        /// </summary>
        public int Value { get; internal set; }

        /// <summary>
        /// Gets the units of measurement.
        /// </summary>
        public string Units { get; internal set; }
    }
}
