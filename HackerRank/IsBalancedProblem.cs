namespace HackerRank
{
    public static class IsBalancedProblem
    {
        //https://www.hackerrank.com/challenges/balanced-brackets/problem

        public static string IsBalanced(string s)
        {
            var originalCharList = s.ToList();           
            var result = new List<char>();            

            for (var i = 0; i < originalCharList.Count(); i++)
            {
                var initialChar = originalCharList[i];

                if (result.Count > 0)
                {
                    var lastChar = result[result.Count - 1];

                    var charToMatchInitial = initialChar switch
                    {
                        ')' => '(',
                        '}' => '{',
                        ']' => '[',
                        _ => ' '
                    };

                    if (lastChar.Equals(charToMatchInitial))
                    {
                        result.RemoveAt(result.Count - 1);
                        continue;
                    }
                }

                result.Add(initialChar);                                       
            }

            Console.WriteLine(result.Count == 0 ? "YES" : "NO");
            return result.Count == 0 ? "YES" : "NO";
        }
    }
}
