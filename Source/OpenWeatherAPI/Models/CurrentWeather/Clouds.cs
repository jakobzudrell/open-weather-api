using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenWeatherAPI
{
    /// <summary>
    /// This class represents the cloud data that is returned by the api call
    /// </summary>
    public class Clouds
    {
        /// <summary>
        /// Cloudiness, %
        /// </summary>
        [JsonProperty("all")]
        public double Cloudiness { get; set; }

    }
}
