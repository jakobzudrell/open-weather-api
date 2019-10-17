using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenWeatherAPI
{
    /// <summary>
    /// This is the base model for all api calls
    /// Data that is persistent over all api data is stored here
    /// </summary>
    public class BaseModel
    {
        #region Public Properties

        /// <summary>
        /// The status code that is returned by every call
        /// TODO add link to list describing all status codes
        /// </summary>
        [JsonProperty("cod")]
        public int StatusCode { get; set; }

        /// <summary>
        /// An optional message that is delivered with some api calls (e.g. describes an error...)
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        #endregion
    }
}
