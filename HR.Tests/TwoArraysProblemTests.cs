namespace HR.Tests
{
    [TestFixture]
    public class TwoArraysProblemTests
    {
        [Test]
        [TestCase("YES", 4, new[] { 1, 3 }, new[] { 3, 1 })]
        [TestCase("NO", 5, new[] { 2, 3, 1, 1, 1 }, new[] { 1, 3, 4, 3, 3 })]
        [TestCase("NO", 9, new[] { 1, 5, 1, 4, 4, 2, 7, 1, 2, 2 }, new[] { 8, 7, 1, 7, 7, 4, 4, 3, 6, 7 })]
        [TestCase("YES", 9, new [] { 3, 6, 8, 5, 9, 9, 4, 8, 4, 7 }, new [] { 5, 1, 0, 1, 6, 4 ,1 ,7 ,4 ,3 } )]        
        [TestCase("YES", 4, new [] { 4, 4, 3, 2, 1, 4, 4, 3, 2, 4 }, new [] { 2, 3, 0, 1, 1, 3, 1, 0, 0, 2 })]
        public void TwoArrays(string expected, int permutationPoint, int[] input1, int[] input2)
        {
            Assert.That(TwoArraysProblem.TwoArrays(permutationPoint, input1.ToList(), input2.ToList()), Is.EqualTo(expected));         
        }
    }
}
