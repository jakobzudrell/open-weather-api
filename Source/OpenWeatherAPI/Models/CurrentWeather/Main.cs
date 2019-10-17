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
        #region Public Properties

        /// <summary>
        /// Temperature in Kelvin
        /// </summary>
        [JsonProperty("temp")]
        public Temperature Temperature { get; set; }

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

        #endregion
    }

    /// <summary>
    /// A temperature object
    /// </summary>
    public class Temperature
    {
        #region Public Properties

        /// <summary>
        /// The temperature in Kelvin
        /// </summary>
        public double Kelvin { get; set; }

        /// <summary>
        /// The temperature in Celsius
        /// </summary>
        public double Celsius { get; set; }

        /// <summary>
        /// The temperature in Fahrenheit
        /// </summary>
        public double Fahrenheit { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Temperature(double kelvin)
        {
            // Assign the properties
            Kelvin = kelvin;
            Celsius = kelvin.ToCelsius();
            Fahrenheit = kelvin.ToFahrenheit();
        }

        #endregion

    }
}
