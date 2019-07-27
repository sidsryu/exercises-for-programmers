using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your current age? ");
            string age = Console.ReadLine();

            Console.Write("At what age would you like to retire? ");
            string retire = Console.ReadLine();


            int a;
            int r;

            int.TryParse(age, out a);
            int.TryParse(retire, out r);


            var reporter = new RetireReporter();

            int leftRetireYears = r - a;
            string result = reporter.Report(leftRetireYears);

            Console.WriteLine(result);
        }
    }
}
