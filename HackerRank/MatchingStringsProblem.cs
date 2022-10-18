namespace HackerRank
{
    public static class MatchingStringsProblem
    {
        //https://www.hackerrank.com/challenges/one-month-preparation-kit-sparse-arrays/problem

        public static List<int> MatchingStrings(List<string> strings, List<string> queries)
        {
            var result = new List<int>();

            foreach (var query in queries)
            {
                result.Add(strings.Where(x => x.Equals(query)).Count());
            }

            return result;
        }
    }
}
