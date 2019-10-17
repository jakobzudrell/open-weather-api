using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenWeatherAPI
{
    /// <summary>
    /// The main data from the current weather call
    /// </summary>
    public class Main
    {
        /// <summary>
        /// Temperature. Default unit: Kelvin, Metric: Celsius, Imperial: Farenheit
        /// </summary>
        [JsonProperty("temp")]
        public double Tempterature { get; set; }

        /// <summary>
        /// Atmospheric pressure (on the sea level, if there is no sea_level or grnd_level data), hPa
        /// </summary>
        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        /// <summary>
        /// Humidity, %
        /// </summary>
        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        /// <summary>
        /// Minimum temperature at the moment. 
        /// This is deviation from current temp that is possible for large cities and megalopolises 
        /// geographically expanded (use these parameter optionally). 
        /// Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit
        /// </summary>
        [JsonProperty("temp_min")]
        public double MinTemperature { get; set; }

        /// <summary>
        /// Maxmimum temperature at the moment. 
        /// This is deviation from current temp that is possible for large cities and megalopolises 
        /// geographically expanded (use these parameter optionally). 
        /// Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit    
        /// </summary>
        [JsonProperty("temp_max")]
        public double MaxTemperature { get; set; }

        /// <summary>
        /// Atmospheric pressure on the sea level, hPa
        /// </summary>
        [JsonProperty("sea_level")]
        public double SeaLevelPressure { get; set; }

        /// <summary>    
        /// Atmospheric pressure on the ground level, hPa
        /// </summary>
        [JsonProperty("grnd_level")]
        public double GroundLevelPressure { get; set; }
    }
}
