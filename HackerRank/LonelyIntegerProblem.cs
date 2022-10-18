namespace HackerRank
{
    public static class LonelyIntegerProblem
    {
        //https://www.hackerrank.com/challenges/one-month-preparation-kit-lonely-integer/problem

        public static int LonelyInteger(List<int> a)
        {
            var groupedInts = a.GroupBy(x=>x).OrderBy(x=>x.Count()).Select(x=>x.Key).ToList();

            return groupedInts.First();
        }
    }
}
