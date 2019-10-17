using System.Net.Http;
using System.Net.Http.Headers;
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
        /// The base uri for the api
        /// </summary>
        private readonly string mBaseUri;

        /// <summary>
        /// The api key for this instance
        /// </summary>
        private readonly string mApiKey;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public OpenWeatherAPI(string baseUri, string apiKey)
        {
            // Assign the base uri
            mBaseUri = baseUri;

            // Assign the api key
            mApiKey = apiKey;

            // Create a new client instance
            mClient = new HttpClient();

            // Setup the client
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
        public async Task<CurrentWeather> GetCurrentWeatherData(int id)
        {
            return ProcessData<CurrentWeather>(await GetDataAsync($"weather?id={id}&APPID={mApiKey}"));
        }

        #endregion

        #region Private Methods
        
        /// <summary>
        /// Gets the data from the given url and returns the raw json data as string
        /// </summary>
        /// <param name="apiQuery">The specified api query</param>
        /// <returns></returns>
        private async Task<string> GetDataAsync(string apiQuery)
        {
            try
            {
                // Get the data
                var response = await mClient.GetAsync($"{mBaseUri}/{apiQuery}");

                // Ensure that the status code of the response is success
                response.EnsureSuccessStatusCode();

                // Read the response as string and return it
                return await response.Content.ReadAsStringAsync();
            }
            catch(HttpRequestException ex)
            {
                // TODO handle exception
                throw ex;
            }

        }

        /// <summary>
        /// Processes the given from a given type to its class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        private T ProcessData<T>(string data)
        {
            // Parse the response data to a current weather object
            return JsonConvert.DeserializeObject<T>(data);
        }

        #endregion
    }
}
