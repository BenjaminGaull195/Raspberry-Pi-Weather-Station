// <copyright file="WeatherStation.cs" company="BenjaminGaull195">
// Copyright (c) BenjaminGaull195. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO;

namespace WeatherStationLibrary
{
    /// <summary>
    /// Weather station interface.
    /// </summary>
    public partial class WeatherStation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherStation"/> class.
        /// </summary>
        public WeatherStation()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherStation"/> class.
        /// </summary>
        /// <param name="output">Collection of <see cref="Stream"/>'s for data output.</param>
        public WeatherStation(ref IEnumerable<Stream> output)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherStation"/> class.
        /// </summary>
        /// <param name="output">Collection of <see cref="Stream"/>'s for data output.</param>
        /// <param name="configFilePath">Filepath to the JSON config file.</param>
        public WeatherStation(ref IEnumerable<Stream> output, string configFilePath)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherStation"/> class.
        /// </summary>
        /// <param name="output">Collection of <see cref="Stream"/>'s for data output.</param>
        /// <param name="config">Config object for the WeatherStation.</param>
        public WeatherStation(ref IEnumerable<Stream> output, WeatherStationConfig config)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Starts the <see cref="WeatherStation"/>'s data collection and recording functionality.
        /// </summary>
        public void Start()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Stops the <see cref="WeatherStation"/>'s data collection and recording functionality.
        /// </summary>
        public void Stop()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the current weather conditions.
        /// </summary>
        /// <returns><see cref="WeatherData"/> containing the current data from available sensors.</returns>
        public WeatherData GetCurrentWeatherData()
        {
            throw new NotImplementedException();
        }
    }
}
