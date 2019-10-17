using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenWeatherAPI
{
    /// <summary>
    /// This class represents weather data that is returned by the openweather api
    /// </summary>
    public class Weather
    {
        /// <summary>
        /// The weather condition id
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

        /// <summary>
        /// Group of weather parameters (e.g. "Clouds", "Snow", "Extreme", ...)
        /// </summary>
        [JsonProperty("main")]
        public string Main { get; set; }

        /// <summary>
        /// Weather condition within the group
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Weather icon id
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

    }
}
