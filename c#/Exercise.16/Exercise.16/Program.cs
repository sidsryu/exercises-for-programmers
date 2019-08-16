using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            string inputAge = Console.ReadLine();


            int age;
            int.TryParse(inputAge, out age);


            string msg = LegalDriving.IsLegalAge(age) ?
                "You are old enogh to legally drive." :
                "You are not old enough to legally drive.";

            Console.WriteLine(msg);
        }
    }
}
