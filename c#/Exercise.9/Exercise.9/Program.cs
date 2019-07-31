using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the length of the ceiling in meter? ");
            string length = Console.ReadLine();

            Console.Write("What is the width of the ceiling in meter? ");
            string width = Console.ReadLine();


            int l;
            int w;
            int.TryParse(length, out l);
            int.TryParse(width, out w);


            int area = l * w;
            int liters = PaintCalculator.Calculate(area);

            Console.WriteLine($"You will need to purchase {liters} liters of");
            Console.WriteLine($"paint to cover {area} square meters.");
        }
    }
}
