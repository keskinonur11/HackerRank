namespace HackerRank
{
    public static class DiagonalDiffrenceProblem
    {
        //https://www.hackerrank.com/challenges/one-month-preparation-kit-diagonal-difference/problem

        public static int DiagonalDifference(List<List<int>> arr)
        {
            var LeftToRightDiagonalIndex = 0;
            var RightToLeftDiagonalIndex = arr.Count - 1;

            var LeftToRightSum = 0;
            var RightToLeftSum = 0;

            foreach (var item in arr)
            {
                LeftToRightSum += item[LeftToRightDiagonalIndex];
                LeftToRightDiagonalIndex++;

                RightToLeftSum += item[RightToLeftDiagonalIndex];
                RightToLeftDiagonalIndex--;
            }

            var res = Math.Abs(LeftToRightSum - RightToLeftSum);
            
            return res;
        }
    }
}
