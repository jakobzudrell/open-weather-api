using System;

namespace OpenWeatherAPI
{
    /// <summary>
    /// Extension methods for the <see cref="OpenWeatherAPI"/> library
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Converts a Kelvin value to Celsius 
        /// </summary>
        /// <param name="kelvin">The given value in Kelvin</param>
        /// <returns>A <see cref="double"/></returns>
        public static double ToCelsius(this double x)
        {
            // The formula to convert kelvin to celsius
            return Math.Round(x - 273.15, 2);
        }

        /// <summary>
        /// Converts a Kelvin value to Fahrenheit 
        /// </summary>
        /// <param name="kelvin">The given value in Kelvin</param>
        /// <returns>A <see cref="double"/></returns>
        public static double ToFahrenheit(this double x)
        {
            // The formula to convert kelvin to fahrenheit
            return Math.Round((9 / (5 * (x - 273.15))) + 32, 2);
        }
    }
}
