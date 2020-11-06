using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double Fahrenheit)
        {
            var result = (Fahrenheit - 32) / 1.8;

                return result;
        }

        public static double CelsiusToFareinheight(double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }
    }
}
