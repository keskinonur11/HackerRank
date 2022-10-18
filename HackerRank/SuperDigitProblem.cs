namespace HackerRank
{
    public static class SuperDigitProblem
    {
        //https://www.hackerrank.com/challenges/super-digit/problem

        public static int SuperDigit(string n, int k)
        {
            long sum = 0;

            if (n.Length == 1)
                return int.Parse(n);

            for (var i = 0; i < n.Length; i++)
            {
                sum += long.Parse(n[i].ToString()) * k;
            }

            if (sum.ToString().Length == 1)
                return int.Parse(sum.ToString());


            return SuperDigit(sum.ToString(), 1);
        }
    }
}
