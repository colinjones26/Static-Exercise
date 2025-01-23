namespace StaticExercise
{
    using System;

    public static class TempConverter
    {
        // Method to convert Fahrenheit to Celsius
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        // Method to convert Celsius to Fahrenheit
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }

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
