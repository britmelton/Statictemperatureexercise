using System;

namespace StaticExercise
{
    internal class Program
    {
        #region Exercise Instructions
        /*Create a new console app called StaticExercise.
         * Now create a static class called TempConverter.
         * The class should have at least 2 methods:
         * 1.one called FahrenheitToCelsius that will require a double as a parameter and return a double
         * 2.the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.
         * Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!*/

        #endregion
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(18);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(18);

            Console.WriteLine(celsius + "c");
            Console.WriteLine(fahrenheit + "f");  
        }
    }
}
