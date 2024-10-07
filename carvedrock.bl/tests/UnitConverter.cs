using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.tests
{
    public static class UnitConverter
    {
        public static decimal KilometersToMiles(decimal kilometers)
        {
            if (kilometers < 0) throw new ArgumentException("Kilometers should be greater than 0");
            return Math.Round(kilometers * 0.621371M, 4);
        }

        public static decimal MilesToKilometers(decimal miles)
        {
            if (miles < 0) throw new ArgumentException("Miles should be greater than 0");
            return Math.Round(miles * 1.60934M, 4);
        }

        public static decimal CelsiusToFahrenheit(decimal celsius)
        {
            return (celsius * (9 / 5)) + 32;
        }

        public static decimal FahrenheitToCelsius(decimal fahrenheit)
        {
            return (fahrenheit - 32) * (5 / 9);
        }
    }
}
