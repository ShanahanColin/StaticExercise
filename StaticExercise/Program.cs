using System;

namespace StaticExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           var Celsius = TempConverter.FahrenheitToCelsius(68);
           
            Console.WriteLine($"Celsius = {Celsius} degrees");

            var Fahrenheight = TempConverter.CelsiusToFareinheight(20);

            Console.WriteLine($"Fahrenheight = {Fahrenheight} degrees");
        }
    }
}
