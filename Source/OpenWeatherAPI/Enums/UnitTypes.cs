using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherAPI
{
    public enum UnitType
    {
        /// <summary>
        /// Non retard units such as Celsius, meter/sec
        /// </summary>
        NonRetard,

        /// <summary>
        /// Retard units such as Fahrenheit, miles/hour
        /// </summary>
        Retard
    }
}
