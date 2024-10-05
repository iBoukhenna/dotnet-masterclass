using System;
using System.Text.Json;

namespace carvedrock.bl.principles.Solid.OpenClosed
{
    public class OpenClosed
    {
        public void Demo()
        {
            // This is what we receive from the API

            // Option A: The API does not change the old variables
            string ourWeatherApi = @"{
                ""Latitude"":10.0731,
                ""Longitude"":84.3123,
                ""Description"":""Clouds and sun"",
                ""TemperatureC"":25,
                ""Humidity"":74,
                ""Wind"":16
            }";

            Weather? weatherToday = JsonSerializer.Deserialize<Weather>(ourWeatherApi);

            if (weatherToday != null)
                Console.WriteLine(weatherToday.TemperatureC);

            // Option B: The API change the old variables (WRONG!)
            string ourWeatherApiWRONG = @"{
                ""Lat"":10.0731,
                ""Lon"":84.3123,
                ""Descr"":""Clouds and sun"",
                ""TemperatureCelsius"":25,
                ""Humidity"":74,
                ""Wind"":16
            }";

            Weather? weatherTodayWRONG = JsonSerializer.Deserialize<Weather>(ourWeatherApiWRONG);

            if (weatherTodayWRONG != null)
                Console.WriteLine(weatherTodayWRONG.TemperatureC);

        }
    }
}

