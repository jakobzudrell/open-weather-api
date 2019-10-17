using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenWeatherAPI
{
    /// <summary>
    /// This class represents coordination data that is returned by the openweather api
    /// </summary>
    public class Coordinates
    {
        /// <summary>
        /// City geo location, longitude
        /// </summary>
        [JsonProperty("lon")]
        public double Longitude { get; set; }

        /// <summary>
        /// City geo location, latitude
        /// </summary>
        [JsonProperty("lat")]
        public double Latitude { get; set; }
    }

}
