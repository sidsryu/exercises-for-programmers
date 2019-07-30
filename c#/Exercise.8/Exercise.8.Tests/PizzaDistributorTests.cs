using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._8.Tests
{
    using NUnit.Framework;
    using NUnit.Framework.Constraints;

    [TestFixture]
    public class PizzaDistributorTests
    {
        [Test]
        public void Distribute_Valid_ReturnDistributionAndLeftover()
        {
            int peopleCount = 8;
            int pizzaCount = 2;
            int pizzaCuts = 8;            

            var result = PizzaDistributor.Distribute(peopleCount, pizzaCount,
                pizzaCuts);

            Assert.That(result, Is.EqualTo((2, 0)));
        }

        [Test]
        public void Distibute_OddCuts_ThrowsException()
        {
            int peopleCount = 8;
            int pizzaCount = 2;
            int pizzaCuts = 7;            

            ActualValueDelegate<object> del = 
                () => PizzaDistributor.Distribute(peopleCount, pizzaCount, pizzaCuts);

            Assert.That(del, Throws.ArgumentException);
        }
    }
}
