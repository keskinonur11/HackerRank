using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Tests
{
    [TestFixture]
    public class FlippingBitsProblemTests
    {
        [Test]
        [TestCase(0, 4294967295)]
        [TestCase(1, 4294967294)]        
        [TestCase(4, 4294967291)]
        [TestCase(123456, 4294843839)]
        [TestCase(2147483647, 2147483648)]
        [TestCase(802743475, 3492223820)]
        [TestCase(35601423, 4259365872)]
        public void FlippingBits(long input, long expected)
        {
            Assert.That(FlippingBitsProblem.FlippingBits(input), Is.EqualTo(expected));
        }

    }
}
