using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var parts = new PartsOfSpeech();

            Console.Write("Enter a noun: ");
            parts.Noun = Console.ReadLine();

            Console.Write("Enter a verb: ");
            parts.Verb = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            parts.Adjective = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            parts.Adverb = Console.ReadLine();


            string result = MadLibs.Talk(parts);
            Console.WriteLine(result);
        }
    }
}
