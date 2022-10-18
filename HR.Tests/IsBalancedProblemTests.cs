namespace HR.Tests
{
    [TestFixture]
    public class IsBalancedProblemTests
    {
        [Test]
        [TestCase("YES", "{[()]}")]
        [TestCase("NO", "{[(])}")]
        [TestCase("YES", "{{[[(())]]}}")]
        [TestCase("YES", "{}")]
        [TestCase("NO", "}([[{)[]))]{){}[")]
        [TestCase("NO", "{]]{()}{])")]
        [TestCase("YES", "(){}")]
        [TestCase("YES", "{}{()}{{}}")]
        [TestCase("NO", "}][}}(}][))]")]
        [TestCase("NO", "{)[](}]}]}))}(())(")]
        public void IsBalanced(string expedtedResult, string input)
        {
            Assert.That(IsBalancedProblem.IsBalanced(input), Is.EqualTo(expedtedResult));
        }
    }
}
