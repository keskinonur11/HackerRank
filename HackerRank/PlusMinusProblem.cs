namespace HackerRank
{
    public static class PlusMinusProblem
    {
        //https://www.hackerrank.com/challenges/one-month-preparation-kit-plus-minus/problem

        public static void PlusMinus(List<int> arr)
        {         
            var positives = 0;
            var zeros = 0;
            var negatives = 0;

            foreach (var item in arr)
            {
                if (item > 0)
                    positives += 1;
                else if (item < 0)
                    negatives += 1;
                else
                    zeros += 1;
            }

            Console.WriteLine("{0:N6}", (decimal)positives / arr.Count);
            Console.WriteLine("{0:N6}", (decimal)negatives / arr.Count);
            Console.WriteLine("{0:N6}", (decimal)zeros/ arr.Count);
        }
    }
}
