using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            string hello = SayingHello.Say(name);
            Console.WriteLine(hello);
        }
    }
}
