using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._15
{
    class Program
    {
        static void Main(string[] args)
        {
            var auth = new Authentication();
            auth.SignUp("testuser", "abc$123");


            Console.Write("What is the username: ");
            string username = Console.ReadLine();

            Console.Write("What is the password: ");
            string password = Console.ReadLine();


            bool isSignedIn = auth.SignIn(username, password);
            if (isSignedIn)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("That password is incorrect.");
            }
        }
    }
}
