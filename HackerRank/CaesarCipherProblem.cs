namespace HackerRank
{
    //https://www.hackerrank.com/challenges/caesar-cipher-1/problem
    public static class CaesarCipherProblem
    {
        public static string CaesarCipher(string s, int k)
        {
            var resultStr = "";

            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            var strinArr = s.ToCharArray();

            foreach (var data in strinArr)
            {
                var isUpperCase = char.IsUpper(data);

                if (!char.IsLetter(data))
                {
                    resultStr += data;
                    continue;
                }

                var indexOfDataByAlphabet = Array.IndexOf(alphabet, char.ToLower(data));

                var cipherIndex = indexOfDataByAlphabet + k;

                if (cipherIndex > alphabet.Length - 1)
                {
                    var offset = cipherIndex % alphabet.Length;
                    resultStr += !isUpperCase ? alphabet[offset] : char.ToUpper(alphabet[offset]);
                    continue;
                }

                resultStr += !isUpperCase ? alphabet[cipherIndex] : char.ToUpper(alphabet[cipherIndex]);
            }

            return resultStr;
        }
    }
}
