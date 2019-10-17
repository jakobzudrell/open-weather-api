using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenWeatherAPI
{
    /// <summary>
    /// This class represents the Snow data that is returned by the api call
    /// </summary>
    public class Snow
    {
        /// <summary>
        /// Snow volume for the last 1 hour, mm
        /// </summary>
        [JsonProperty("1h")]
        public double VolumeLastHour { get; set; }

        /// <summary>
        /// Snow volume for the last 3 hours, mm
        /// </summary>
        [JsonProperty("3h")]
        public double VolumeLastThreeHours { get; set; }
    }
}
