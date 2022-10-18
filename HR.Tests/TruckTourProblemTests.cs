namespace HR.Tests
{
    [TestFixture]
    public class TruckTourProblemTests
    {
        [Test]
        public void TruckTourTests()
        {
            Assert.That(TruckTourProblem.TruckTour(TruckTourProblem.TruckTourStops), Is.EqualTo(573));
        }

        
    }
}
