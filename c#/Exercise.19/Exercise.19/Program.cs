using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your height(inches)? ");
            string inputHeight = Console.ReadLine();

            Console.Write("What is your weight(pounds)? ");
            string inputWeight = Console.ReadLine();


            double heightInInches;
            double weightInPounds;
            double.TryParse(inputHeight, out heightInInches);
            double.TryParse(inputWeight, out weightInPounds);


            double bmi = BmiCalculator.Calculate(heightInInches, weightInPounds);
            bool isNormalWeight = BmiCalculator.IsNormalWeightByBmi(bmi);


            Console.WriteLine($"Your MBI is {bmi}.");
            if (isNormalWeight)
            {
                Console.WriteLine("You are within the ideal weight range.");
            }
            else
            {
                Console.WriteLine("You are overweight. You should see your doctor.");
            }
        }
    }
}
