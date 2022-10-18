namespace HR.Tests
{
    [TestFixture]
    public class PalindromeProblemTests
    {

        [Test]
        [TestCase(3, "aaab")]
        [TestCase(0, "baa")]
        [TestCase(-1, "aaa")]
        [TestCase(1, "quyjjdcgsvvsgcdjjyq")]
        [TestCase(8, "hgygsvlfwcwnswtuhmyaljkqlqjjqlqkjlaymhutwsnwcflvsgygh")]
        [TestCase(33, "fgnfnidynhxebxxxfmxixhsruldhsaobhlcggchboashdlurshxixmfxxxbexhnydinfngf")]
        [TestCase(23, "bsyhvwfuesumsehmytqioswvpcbxyolapfywdxeacyuruybhbwxjmrrmjxwbhbyuruycaexdwyfpaloyxbcpwsoiqtymhesmuseufwvhysb")]
        [TestCase(25, "fvyqxqxynewuebtcuqdwyetyqqisappmunmnldmkttkmdlnmnumppasiqyteywdquctbeuwenyxqxqyvf")]
        [TestCase(44, "mmbiefhflbeckaecprwfgmqlydfroxrblulpasumubqhhbvlqpixvvxipqlvbhqbumusaplulbrxorfdylqmgfwrpceakceblfhfeibmm")]
        [TestCase(20, "tpqknkmbgasitnwqrqasvolmevkasccsakvemlosaqrqwntisagbmknkqpt")]
        [TestCase(-1, "lhrxvssvxrhl")]
        [TestCase(14, "prcoitfiptvcxrvoalqmfpnqyhrubxspplrftomfehbbhefmotfrlppsxburhyqnpfmqlaorxcvtpiftiocrp")]
        [TestCase(-1, "kjowoemiduaaxasnqghxbxkiccikxbxhgqnsaxaaudimeowojk")]

        public void PalindromeIndexTest(int expected, string input)
        {
            Assert.That(PalindromeProblem.PalindromeIndex(input), Is.EqualTo(expected));            
        }
    }
}
