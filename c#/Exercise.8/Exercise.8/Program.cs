using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many people? ");
            string peopleCount = Console.ReadLine();

            Console.Write("How many pizzas do you have? ");
            string pizzaCount = Console.ReadLine();

            Console.WriteLine();
            Console.Write("How many pieces are in a pizza? ");
            string pizzaCuts = Console.ReadLine();


            int people;
            int pizzas;
            int cuts;

            int.TryParse(peopleCount, out people);
            int.TryParse(pizzaCount, out pizzas);
            int.TryParse(pizzaCuts, out cuts);


            var (distribution, leftover) = PizzaDistributor.Distribute(people, pizzas, 
                cuts);

            Console.WriteLine($"{people} people with {pizzas} pizzas");
            Console.WriteLine($"Each person gets {distribution} pieces of pizza.");
            Console.WriteLine($"There are {leftover} leftover pieces.");
        }
    }
}
