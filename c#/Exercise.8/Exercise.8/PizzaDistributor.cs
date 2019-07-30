using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._8
{
    public static class PizzaDistributor
    {
        public static (int, int) Distribute(int peopleCount, int pizzaCount,
            int pizzaCuts)
        {
            if (IsOdd(pizzaCuts))
            {
                throw new ArgumentException("Must even number of cuts.", 
                    nameof(pizzaCuts));
            }

            int distribution = pizzaCount * pizzaCuts / peopleCount;
            int leftover = pizzaCount * pizzaCuts % peopleCount;

            return (distribution, leftover);
        }

        private static bool IsOdd(int n)
        {
            return !IsEven(n);
        }

        private static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
