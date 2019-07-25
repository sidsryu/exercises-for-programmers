using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._4.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class PartsOfSpeechTests
    {
        [Test]
        public void Valid_SettedFullParts_ReturnTrue()
        {
            var parts = new PartsOfSpeech()
            {
                Noun = "dog",
                Verb = "walk",
                Adjective = "blue",
                Adverb = "quickly"
            };

            bool valid = parts.IsValid();

            Assert.That(valid, Is.True);
        }

        [Test]
        public void Valid_DefaultParts_ReturnFalse()
        {
            var parts = new PartsOfSpeech();

            bool valid = parts.IsValid();

            Assert.That(valid, Is.False);
        }

        [Test]
        public void Valid_NoNoun_ReturnFalse()
        {
            var parts = new PartsOfSpeech()
            {
                Verb = "walk",
                Adjective = "blue",
                Adverb = "quickly"
            };

            bool valid = parts.IsValid();

            Assert.That(valid, Is.False);
        }

        [Test]
        public void Valid_NoVerb_ReturnFalse()
        {
            var parts = new PartsOfSpeech()
            {
                Noun = "dog",
                Adjective = "blue",
                Adverb = "quickly"
            };

            bool valid = parts.IsValid();

            Assert.That(valid, Is.False);
        }

        [Test]
        public void Valid_NoAdjective_ReturnFalse()
        {
            var parts = new PartsOfSpeech()
            {
                Noun = "dog",
                Verb = "walk",                
                Adverb = "quickly"
            };

            bool valid = parts.IsValid();

            Assert.That(valid, Is.False);
        }

        [Test]
        public void Valid_NoAdverb_ReturnFalse()
        {
            var parts = new PartsOfSpeech()
            {
                Noun = "dog",
                Verb = "walk",
                Adjective = "blue"
            };

            bool valid = parts.IsValid();

            Assert.That(valid, Is.False);
        }
    }
}
