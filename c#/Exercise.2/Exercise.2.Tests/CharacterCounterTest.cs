using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._2.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CharacterCounterTest
    {
        [TestCase("Homer", "Homer has 5 characters.")]
        [TestCase("Cat", "Cat has 3 characters.")]
        [TestCase("Elephant", "Elephant has 8 characters.")]
        public void Count_Word_ReturnWordAndCountMessage(string word, string expected)
        {
            string result = CharacterCounter.Count(word);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Count_Empty_ReturnNotCountingMessage()
        {
            string result = CharacterCounter.Count("");
            Assert.That(result, Is.EqualTo("No word."));
        }
    }
}
