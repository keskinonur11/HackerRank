using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class PangramProblem
    {
        //https://www.hackerrank.com/challenges/one-month-preparation-kit-pangrams/problem

        public static string Pangrams(string s)
        {            
            var inputToCharArr = s.Replace(" ", "").ToLowerInvariant().OrderBy(x => x).GroupBy(x=>x).Select(x=>x).ToList();

            return inputToCharArr.Count == 26 ? "pangram" : "not pangram";
        }
    }
}
