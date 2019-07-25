using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._1.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class SayingHelloTest
    {
        [Test]
        public void Say_PersonName_ReturnHelloMessage()
        {
            string name = "Brian";
            string hello = SayingHello.Say(name);

            Assert.That(hello, Is.EqualTo("Hello, Brian, nice to meet you!"));
        }

        [Test]
        public void Say_AnotherName_ReturnHelloMessage()
        {
            string name = "Mary";
            string hello = SayingHello.Say(name);

            Assert.That(hello, Is.EqualTo("Hello, Mary, nice to meet you!"));
        }

        [Test]
        public void Say_EmptyName_ReturnJustHelloMessageWithoutName()
        {
            string hello = SayingHello.Say(string.Empty);

            Assert.That(hello, Is.EqualTo("Hello, nice to meet you!"));
        }
    }
}
