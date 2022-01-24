using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(18);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(18);

            Console.WriteLine(celsius + "c");
            Console.WriteLine(fahrenheit + "f");  

        }
    }


}
