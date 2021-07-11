// <copyright file="InternalWindDirectionData.cs" company="BenjaminGaull195">
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
    internal class InternalWindDirectionData : WindDirectionData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalWindDirectionData"/> class.
        /// </summary>
        /// <param name="direction">Direction of the wind.</param>
        public InternalWindDirectionData(string direction)
        {
            this.Direction = direction;
        }
    }
}
