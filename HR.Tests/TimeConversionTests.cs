namespace HR.Tests
{
    [TestFixture]
    public class TimeConversionTests
    {
        [Test]
        [TestCase("19:05:45", "07:05:45PM")]
        [TestCase("00:40:22", "12:40:22AM")]
        [TestCase("12:45:54", "12:45:54PM")]        
        public void TimeConversionTest(string expected, string input)
        {
            Assert.That(TimeConversionProblem.TimeConversion(input), Is.EqualTo(expected));
        }
    }
}
