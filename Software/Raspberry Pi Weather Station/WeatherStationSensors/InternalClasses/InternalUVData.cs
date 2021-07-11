// <copyright file="InternalUVData.cs" company="BenjaminGaull195">
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
    internal class InternalUVData : UVData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalUVData"/> class.
        /// </summary>
        /// <param name="uVIndex">UV Index.</param>
        public InternalUVData(int uVIndex)
        {
            this.UVIndex = uVIndex;
        }
    }
}
