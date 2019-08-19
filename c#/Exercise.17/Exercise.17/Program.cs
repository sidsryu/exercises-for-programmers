using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skip console input
            var ctx = new BloodAlcoholContext()
            {
                AlcoholConsumedOz = 5.0,
                BodyWeightLb = 190.0,
                TargetSex = BloodAlcoholContext.Sex.Male,
                HoursSinceTheLastDrink = 1.0,
            };


            double bac = BloodAlcoholCalculator.CalcBac(ctx);
            bool isLegalDrive = BloodAlcoholCalculator.IsLegalDrive(bac);


            Console.WriteLine($"Your BAC is {bac}");

            if (isLegalDrive)
            {
                Console.WriteLine("It is legal for you to drive");
            }
            else
            {
                Console.WriteLine("It is not legal for you to drive");
            }
        }
    }
}
