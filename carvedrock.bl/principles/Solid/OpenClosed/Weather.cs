using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.Solid.OpenClosed
{
    public class Weather
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string? Description { get; set; }
        public decimal TemperatureC { get; set; }
        public decimal TemperatureF
        {
            get { return TemperatureC * 9 / 5 + 32; }
        }
        public float Humidity { get; set; }
        public float Wind { get; set; }
    }
}
