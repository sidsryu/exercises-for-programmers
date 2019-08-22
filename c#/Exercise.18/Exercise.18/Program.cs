using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press C to convert from Fahrenheit to Celsius.");
            Console.WriteLine("Press F to convert from Celsius to Fahrenheit.");
            Console.Write("Your choice: ");
            string inputChoice = Console.ReadLine();


            string sourceUnit;
            string targetUnit;
            Func<double, double> convert;

            if (inputChoice.Equals("c", StringComparison.OrdinalIgnoreCase))
            {
                sourceUnit = "Fahrenheit";
                targetUnit = "Celsius";
                convert = TemperatureConverter.FahrenheitToCelsius;
            }
            else
            {
                sourceUnit = "Celsius";
                targetUnit = "Fahrenheit";
                convert = TemperatureConverter.CelsiusToFahrenheit;
            }


            Console.Write($"Please enter the temperature in {sourceUnit}: ");
            string inputSourceTemp = Console.ReadLine();

            double sourceTemp;
            double.TryParse(inputSourceTemp, out sourceTemp);


            double targetTemp = convert.Invoke(sourceTemp);
            Console.WriteLine($"The temperature in {targetUnit} is {targetTemp}.");
        }
    }
}
