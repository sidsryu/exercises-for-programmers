using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the input stirng? ");
            string word = Console.ReadLine();

            string result = CharacterCounter.Count(word);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
