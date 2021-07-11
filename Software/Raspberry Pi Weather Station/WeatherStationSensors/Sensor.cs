using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSensors
{
    public abstract class Sensor
    {
        public Sensor()
        {
        }

        public enum SensorType
        {
            /// <summary>
            /// No Sensor Type
            /// </summary>
            None = 0,

            /// <summary>
            /// Temperature Sensor
            /// </summary>
            Temperature = 1,

            /// <summary>
            /// Pressure Sensor
            /// </summary>
            Pressure = 2,

            /// <summary>
            /// Humidity Sensor
            /// </summary>
            Humidity = 4,

            /// <summary>
            /// Wind Vane Sensor
            /// </summary>
            WindVane = 8,

            /// <summary>
            /// Anemometer Sensor
            /// </summary>
            Anemometer = 16,

            /// <summary>
            /// UV Light Sensor
            /// </summary>
            UVSensor = 32,

            /// <summary>
            /// Air Quality Sensor
            /// </summary>
            AirQuality = 64,
        }

        /// <summary>
        /// Bitmask used to determine what functionallity a sensor provides
        /// </summary>
        public abstract int SensorTypeMask { get; }

        public abstract string SensorName { get; }
    }
}
