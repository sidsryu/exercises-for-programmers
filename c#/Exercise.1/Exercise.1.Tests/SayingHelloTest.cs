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
        public void Say_Default_ReturnHello()
        {
            string hello = SayingHello.Say();
            Assert.That(hello, Is.EqualTo("hello"));
        }
    }
}
