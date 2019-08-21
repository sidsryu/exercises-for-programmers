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


            bool shallToCelsius = inputChoice.Equals("c",
                StringComparison.InvariantCultureIgnoreCase);


            var cnv = new Conversion();
            if (shallToCelsius)
            {
                cnv.SourceUnit = "Fahrenheit";
                cnv.TargetUnit = "Celsius";
            }
            else
            {
                cnv.SourceUnit = "Celsius";
                cnv.TargetUnit = "Fahrenheit";
            }


            Console.Write($"Please enter the temperature in {cnv.SourceUnit}: ");
            string inputTemperature = Console.ReadLine();

            double.TryParse(inputTemperature, out cnv.SourceTemperature);


            if (shallToCelsius)
            {
                cnv.TargetTemperature = TemperatureConverter.FahrenheitToCelsius(
                    cnv.SourceTemperature);
            }
            else
            {
                cnv.TargetTemperature = TemperatureConverter.CelsiusToFahrenheit(
                    cnv.SourceTemperature);
            }


            Console.WriteLine($"The temperature in {cnv.TargetUnit} is " +
                $"{cnv.TargetTemperature}.");
        }

        private struct Conversion
        {
            public double SourceTemperature;
            public double TargetTemperature;
            public string SourceUnit { get; set; }
            public string TargetUnit { get; set; }
        }
    }
}
