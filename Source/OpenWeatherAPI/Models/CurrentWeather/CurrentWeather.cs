using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenWeatherAPI
{
    /// <summary>
    /// Represents the current weather object that is represented by a 
    /// </summary>
    public class CurrentWeather : BaseModel
    {
        #region Public Properties

        /// <summary>
        /// Shift in seconds from UTC
        /// </summary>
        [JsonProperty("timezone")]
        public int Timezone { get; set; }

        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("id")]
        public int CityID { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [JsonProperty("name")]
        public string CityName { get; set; }

        /// <summary>
        /// The corrdinates of the current weather call
        /// </summary>
        [JsonProperty("coord")]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// The weather data of the current weather call
        /// </summary>
        [JsonProperty("weather")]
        public List<Weather> Weathers { get; set; }

        /// <summary>
        /// The main data of the current weather call (This includes Temperatures, Pressures, ...)
        /// </summary>
        [JsonProperty("main")]
        public Main Main { get; set; }

        /// <summary>
        /// The wind data of the current weather call
        /// </summary>
        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        /// <summary>
        /// The cloud data of the current weather call
        /// </summary>
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        /// <summary>
        /// The rain data of the current weather call
        /// </summary>
        [JsonProperty("rain")]
        public Rain Rain { get; set; }

        /// <summary>
        /// The snow data of the current weather call
        /// </summary>
        [JsonProperty("snow")]
        public Snow Snow { get; set; }

        #endregion        
    }
}
