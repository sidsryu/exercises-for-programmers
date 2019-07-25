using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._4.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class MadLibsTests
    {
        [Test]
        public void Talk_FullParts_ReturnStoryUsedAllParts()
        {
            var parts = new PartsOfSpeech()
            {
                Noun = "dog",
                Verb = "walk",
                Adjective = "blue",
                Adverb = "quickly"
            };

            string result = MadLibs.Talk(parts);

            Assert.That(result, Is.EqualTo("Do you walk your blue dog quickly? That's hilarious!"));
        }

        [Test]
        public void Talk_AnotherFullParts_ReturnStoryUsedAllParts()
        {
            var parts = new PartsOfSpeech()
            {
                Noun = "apple",
                Verb = "throw",
                Adjective = "cute",
                Adverb = "perfectly"
            };

            string result = MadLibs.Talk(parts);

            Assert.That(result, Is.EqualTo("Do you throw your cute apple perfectly? That's hilarious!"));
        }

        [Test]
        public void Talk_NotEnoughParts_ReturnEmptyString()
        {
            var parts = new PartsOfSpeech();

            string result = MadLibs.Talk(parts);

            Assert.That(result, Is.Empty);
        }
    }
}
