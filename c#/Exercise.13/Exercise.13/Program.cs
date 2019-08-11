using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the principal amount? ");
            string principalInput = Console.ReadLine();

            Console.Write("What is the rate: ");
            string rateInput = Console.ReadLine();

            Console.Write("What is the number of years: ");
            string yearsInput = Console.ReadLine();

            Console.WriteLine("What is the number of times the interest\n" + 
                "is compounded per years: ");
            string frequencyInput = Console.ReadLine();


            double principal;
            double.TryParse(principalInput, out principal);

            double interestPercent;
            double.TryParse(rateInput, out interestPercent);

            int years;
            int.TryParse(yearsInput, out years);

            int frequency;
            int.TryParse(frequencyInput, out frequency);


            var context = new CompoundInterestContext
            {
                Principal = principal,
                InterestPercent = interestPercent,
                InvestYears = years,
                CompoundingFrequency = frequency,
            };

            double sum = CompoundInterest.Calculate(context);

            Console.WriteLine(
                $"${principal} invested at {interestPercent}% for {years} years");
            Console.WriteLine(
                $"compounded {frequency} times per year is ${sum}");
        }
    }
}
