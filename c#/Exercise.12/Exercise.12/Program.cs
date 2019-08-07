using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the principal: ");
            string principalInput = Console.ReadLine();

            Console.Write("Enter the rate of interest: ");
            string interestPercentInput = Console.ReadLine();

            Console.Write("Enter the number of years: ");
            string yearsInput = Console.ReadLine();


            double principal;
            double.TryParse(principalInput, out principal);

            double interestPercent;
            double.TryParse(interestPercentInput, out interestPercent);

            int years;
            int.TryParse(yearsInput, out years);


            double total = SimpleInterest.Calculate(principal, interestPercent, years);

            Console.WriteLine($"After {years} years at {interestPercent:F1}%, " +
                $"the investment will be worth ${total}");

            Console.ReadKey();
        }
    }
}
