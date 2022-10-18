namespace HackerRank
{
    //https://www.hackerrank.com/challenges/grid-challenge/problem

    public static class GridProblem
    {
        public static string GridChallenge(List<string> grid)
        {
            var result = true;

            var matrixRowColumnValue = grid[0].Length;

            var sortedGrid = new List<string>();

            foreach (var row in grid)
            {
                sortedGrid.Add(new string(row.OrderBy(c => c).ToArray()));
            }

            var sortedGridToCharArr = string.Join("", sortedGrid).ToCharArray();

            for (var i = 0; i < sortedGridToCharArr.Length - matrixRowColumnValue; i++)
            {
                if (sortedGridToCharArr[i] <= sortedGridToCharArr[i + matrixRowColumnValue])
                    continue;

                result = false;
                break;
            }

            return result ? "YES" : "NO";
        }
    }
}
