using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class BirthdayProblem
    {
        //https://www.hackerrank.com/challenges/one-month-preparation-kit-the-birthday-bar/problem

        public static int Birthday(List<int> s, int d, int m) // d = sum , m = digit
        {            
            var ways = 0;
            for (var i = 0; i < s.Count; i++)
            {
                if (i + m > s.Count)
                    break;

                var sum = s.GetRange(i, m).Sum();

                if (sum == d)
                    ways += 1;
            }

            return ways;
        }
    }
}
