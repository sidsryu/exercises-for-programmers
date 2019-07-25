using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._2
{
    public static class CharacterCounter
    {
        public static string Count(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return "No word.";
            }
            else
            {
                return $"{word} has {word.Length} characters.";
            }
        }
    }
}
