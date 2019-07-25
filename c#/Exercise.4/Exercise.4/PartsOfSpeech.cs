using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._4
{
    public struct PartsOfSpeech
    {
        public string Noun { get; set; }
        public string Verb { get; set; }
        public string Adjective { get; set; }
        public string Adverb { get; set; }

        public bool IsValid()
        {
            return !IsInvalid();
        }

        private bool IsInvalid()
        {
            return string.IsNullOrEmpty(Noun) ||
                string.IsNullOrEmpty(Verb) ||
                string.IsNullOrEmpty(Adjective) ||
                string.IsNullOrEmpty(Adverb);
        }
    }
}
