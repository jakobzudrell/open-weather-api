using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenWeatherAPI
{
    /// <summary>
    /// The main class for the open weather API
    /// </summary>
    public class OpenWeatherAPI
    {
        #region Public Properties

        /// <summary>
        /// The http client for this api instance
        /// </summary>
        public HttpClient Client { get; }

        #endregion

        #region Private Members

        /// <summary>
        /// The http client for this api instance
        /// </summary>
        private readonly HttpClient mClient;

        /// <summary>
        /// The api key for this instance
        /// </summary>
        private readonly string mApiKey;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public OpenWeatherAPI(string defaultUri, string apiKey)
        {
            // Assign the api key
            mApiKey = apiKey;

            // Create a new client instance
            mClient = new HttpClient();

            // Setup the client
            mClient.BaseAddress = new Uri(defaultUri);
            mClient.DefaultRequestHeaders.Accept.Clear();
            mClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Reads and processes data from the setup API client
        /// </summary>
        /// <param name="id">The city id</param>
        /// <returns>A <see cref="CurrentWeather"/> object</returns>
        public async Task<CurrentWeather> ProcessCurrentWeatherData(int id)
        {
            // Await the client response
            string response = await mClient.GetStringAsync(GetCurrentWeatherData(id));

            // Parse the response data to a current weather object
            return JsonConvert.DeserializeObject<CurrentWeather>(response);
        }

        #endregion

        #region Private Methods

        private string GetCurrentWeatherData(int id)
        {
            return $@"{mClient.BaseAddress}/weather?id={id}&APPID={mApiKey}";
        }            


        #endregion
    }
}
