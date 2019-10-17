using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenWeatherAPI
{
    /// <summary>
    /// This class represents the wind data that is returned by the api call
    /// </summary>
    public class Wind
    {
        /// <summary>
        /// Wind speed. Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour
        /// </summary>
        [JsonProperty("speed")]
        public double Speed { get; set; }

        /// <summary>
        /// Wind direction, degrees (meteorological)
        /// </summary>
        [JsonProperty("deg")]
        public double Direction { get; set; }
    }

}
