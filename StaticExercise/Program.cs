using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("What is the temperature in F you want to convert");
            double fahTemp = Convert.ToDouble(Console.ReadLine());
            double convertToCel = TempConverter.FahrenheitToCelsius(fahTemp);

            Console.WriteLine($"That equals {convertToCel} degrees Celsius");

            Console.WriteLine("What is the temperature in C you want to convert");
            double CelTemp = Convert.ToDouble(Console.ReadLine());
            double convertToFah = TempConverter.FahrenheitToCelsius(CelTemp);

        }
    }
}
