using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the order amount? ");
            string amountInput = Console.ReadLine();

            Console.Write("What is the state? ");
            string stateInput = Console.ReadLine();


            double amount;
            double.TryParse(amountInput, out amount);

            string state = stateInput;


            var (charged, total) = TaxCalculator.Calculate(amount, state);

            if (charged != 0.00)
            {
                Console.WriteLine($"The subtotal is ${amount:F2}");
                Console.WriteLine($"The tax is ${charged:F2}");                
            }

            Console.WriteLine($"The total is ${total:F2}");
        }
    }
}
