using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWeather
{
    /// <summary>
    /// This represents the model for the current weather retreived by the <see cref="OpenWeatherAPI"/>
    /// </summary>
    public class CurrentWeatherModel
    {
        #region Public Properties

        public double Temperature
        {
            get
            {
                return Temperature;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public CurrentWeatherModel()
        {

        }

        #endregion
    }
}
