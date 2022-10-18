namespace HackerRank
{
    public static class CountingSortProblem
    {
        //https://www.hackerrank.com/challenges/one-month-preparation-kit-countingsort1/problem

        //0,1,5,4,7,4,2,6   n = 8   0,1,1,0,2,1,1,1 .... n -1  > 1 2 4 4 5 6 7

        public static List<int> CountingSort(this List<int> arr)
        {
            var frequencsyArr = new int[100];

            for (var i = 0; i <= arr.Count - 1; i++) // O(n)
            {
                var arrayNumber = arr[i]; // O(n)

                frequencsyArr[arrayNumber] += 1; // O(n)
            }

            return frequencsyArr.ToList();
        }
    }
}
