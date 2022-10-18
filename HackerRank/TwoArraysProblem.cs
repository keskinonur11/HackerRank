using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class TwoArraysProblem
    {
        //https://www.hackerrank.com/challenges/one-month-preparation-kit-two-arrays/problem

        public static string TwoArrays(int k, List<int> A, List<int> B)
        {
            A.Sort();
            B.Sort();
            var canPermute = true;

            foreach (var item in A)
            {
                var diff = k - item;

                var actualDiffElement = B.FirstOrDefault(x => x >= diff, -1);

                if (actualDiffElement == -1)
                {
                    canPermute = false;
                    break;
                }

                B.Remove(diff);
            }

            return canPermute ? "YES" : "NO";
        }
    }
}
