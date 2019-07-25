using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._4
{
    public static class MadLibs
    {
        public static string Talk(PartsOfSpeech parts)
        {
            if (parts.IsValid())
            {
                return $"Do you {parts.Verb} your {parts.Adjective} {parts.Noun} " +
                    $"{parts.Adverb}? That's hilarious!";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
