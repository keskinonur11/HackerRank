using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class PageCountProblem
    {
        //https://www.hackerrank.com/challenges/one-month-preparation-kit-drawing-book/problem

        public static int PageCount(int n, int p)
        {
            var noof = n / 2 + 1;
            var pl = p / 2 + 1;

            return Math.Min(pl - 1, noof - pl);

            //if (p == 0 || p == 1 || p == n - 1 || p == n)
            //    return 0;

            //var mid = n % 2 == 1 ? n / 2 : (n - 1) / 2;

            //var flipCount = 0;

            //if (p > mid)
            //{
            //    Math.Min()
            //    for(var i = n; i > mid; i -= 2)
            //    {
            //        if (i == p)
            //            break;

            //        flipCount++;
            //    }
            //}
            //else
            //{
            //    for (var i = 2; i <= p; i += 2)
            //    {
            //        if (i == p)
            //            break;

            //        flipCount++;
            //    }
            //}                     

            //return flipCount == 0 ? 1 : flipCount;
        }
    }
}
