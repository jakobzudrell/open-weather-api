using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenWeatherAPI
{
    /// <summary>
    /// This class represents the rain data that is returned by the api call
    /// </summary>
    public class Rain
    {
        /// <summary>
        /// Rain volume for the last 1 hour, mm
        /// </summary>
        [JsonProperty("1h")]
        public double VolumeLastHour { get; set; }

        /// <summary>
        /// Rain volume for the last 3 hours, mm
        /// </summary>
        [JsonProperty("3h")]
        public double VolumeLastThreeHours { get; set; }
    }
}
