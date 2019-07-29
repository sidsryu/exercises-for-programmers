using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the length of the room in feet? ");
            string length = Console.ReadLine();

            Console.Write("What is the width of the room in feet? ");
            string width = Console.ReadLine();


            int l;
            int w;
            int.TryParse(length, out l);
            int.TryParse(width, out w);


            double sqft = l * w;
            double sqm = ConvertArea.SquareFeetToSquareMeter(sqft);

            Console.WriteLine($"The area is\n{sqft} square feet\n{sqm:F3} square meters");
        }
    }
}
