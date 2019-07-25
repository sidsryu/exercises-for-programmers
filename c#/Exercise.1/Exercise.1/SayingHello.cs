using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise._1
{
    public class SayingHello
    {
        public static string Say(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return $"Hello, nice to meet you!";
            }
            else
            {
                return $"Hello, {name}, nice to meet you!";
            }            
        }
    }
}
