namespace StaticExercise
{
    using System;

    class Program
    {
        static void Main()
        {
            // Test Fahrenheit to Celsius conversion
            double fahrenheit = 100;
            double celsiusFromFahrenheit = TempConverter.FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit}°F is equal to {celsiusFromFahrenheit}°C");

            // Test Celsius to Fahrenheit conversion
            double celsius = 37.78;
            double fahrenheitFromCelsius = TempConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C is equal to {fahrenheitFromCelsius}°F");
        }
    }

}
