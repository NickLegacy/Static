using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius (double Fahrenheit)
        {
            var result = (Fahrenheit - 32) / 1.8;
            return result;
        }

        public static double CelsiusToFahrenheit (double Celsius)
        {
            var result = (Celsius * 1.8) + 32;
            return result;
        }





    }
}
