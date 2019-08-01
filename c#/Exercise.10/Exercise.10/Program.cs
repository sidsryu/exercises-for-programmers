using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._10
{
    class Program
    {
        static void Main(string[] args)
        {
            var checkout = new Checkout();

            for (int i = 0; i < 3; i++)
            {
                int round = i + 1;

                Console.Write($"Price of itme {round}: ");
                string price = Console.ReadLine();

                Console.Write($"Quantity of item {round}: ");
                string count = Console.ReadLine();


                double p;                
                double.TryParse(price, out p);

                int c;
                int.TryParse(count, out c);


                checkout.AddOrder(new OrderItem(p, c));
            }


            double subtotal = checkout.Subtotal();
            double tax = checkout.Tax();
            double total = checkout.Total();

            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            Console.WriteLine($"Tax: ${tax:F2}");
            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
