using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.test
{
    public static class UnitConverter
    {
        public static decimal KilometersToMiles(decimal kilometers)
        {
            if (kilometers < 0) throw new ArgumentException("Kilometers should be greater than 0");
            return kilometers * 0.621371M;
        }

        public static decimal MilesToKilometers(decimal miles)
        {
            if (miles < 0) throw new ArgumentException("Miles should be greater than 0");
            return miles * 1.60934M;
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
