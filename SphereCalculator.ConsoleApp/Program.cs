using SphereCalculator.Library;
using System;

namespace SphereCalculator.ConsoleApp
{
    class Program
    {
        private static Calculator _sphere = new Calculator();

        static void Main(string[] args)
        {
            _sphere.Calculate(628.3185307179587, CalculatorEnum.Circumference);
            PrintResults();
        }

        static void PrintResults()
        {
            Console.WriteLine($"Radius: {_sphere.Radius}");
            Console.WriteLine($"Diameter: {_sphere.Diameter}");
            Console.WriteLine($"Circumference: {_sphere.Circumference}");
            Console.WriteLine($"Surface Area: {_sphere.SurfaceArea}");
            Console.WriteLine($"Volume: {_sphere.Volume}");
        }
    }
}
