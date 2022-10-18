namespace HackerRank
{
    public static class MiniMaxSumProblem
    {
        //https://www.hackerrank.com/challenges/one-month-preparation-kit-mini-max-sum/problem

        public static void MiniMaxSum(List<int> arr)
        {
            arr.Sort();
            long minSum = arr.Sum(s => (long)s) - arr.Last();
            long maxSum = arr.Sum(s => (long)s) - arr.First();

            Console.WriteLine($"{minSum} {maxSum}");
        }

    }
}
