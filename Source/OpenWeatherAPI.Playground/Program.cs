using System;
using System.Threading.Tasks;

namespace OpenWeatherAPI.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the API client
            var openWeatherAPI = new OpenWeatherAPI("d83a046287643b8cb45524900cb0bb88");

            while (true)
            {

                // Ask for a city to get weather data from
                Console.Write("Please enter a valid city id: ");

                // Try to parse the input 
                // TODO here of course we should check if the id entered is valid (does this city even exist?)
                int.TryParse(Console.ReadLine(), out int id);

                // Process the data from the given API
               var currentWeather = openWeatherAPI.GetCurrentWeatherData(id).Result;

                // Output the temperature
                Console.WriteLine($"Current Temperature: {currentWeather.Main.Temperature.ToCelsius()} °C");
               
            }
        }
    }
}
