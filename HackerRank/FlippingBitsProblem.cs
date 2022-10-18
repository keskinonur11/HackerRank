namespace HackerRank
{
    public static class FlippingBitsProblem
    {
        //https://www.hackerrank.com/challenges/one-month-preparation-kit-flipping-bits/problem

        public static long FlippingBits(long n)
        {            
            var initialBinary = "00000000000000000000000000000000";

            var convertedNum = Convert.ToString(n, 2);

            initialBinary = initialBinary.Remove(initialBinary.Length - convertedNum.Length, convertedNum.Length);

            initialBinary += convertedNum;

            var flippedString = "";

            foreach (var item in initialBinary)
            {
                if (item.Equals('1'))
                    flippedString += "0";
                else
                    flippedString += "1";
            }

            long res = Convert.ToInt64(flippedString, 2);
            return res;
        }    
    }
}
