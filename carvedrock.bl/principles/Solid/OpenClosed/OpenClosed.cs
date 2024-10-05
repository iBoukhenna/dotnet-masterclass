using System;
using System.Text.Json;

namespace carvedrock.bl.principles.Solid.OpenClosed
{
    public class OpenClosed
    {
        public void Demo()
        {
            // This is what we receive from the API
            string ourWeatherApi = @"{
                ""Latitude"":10.0731,
                ""Longitude"":84.3123,
                ""Description"":""Clouds and sun"",
                ""TemperatureC"":25
            }";


            Weather? weatherToday = JsonSerializer.Deserialize<Weather>(ourWeatherApi);

            if (weatherToday != null)
            {
                Console.WriteLine(weatherToday.TemperatureC);
            }
        }
    }
}
