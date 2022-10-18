using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class SockMerchantProblem
    {
        //https://www.hackerrank.com/challenges/one-month-preparation-kit-sock-merchant/problem

        public static int SockMerchant(int n, List<int> ar)
        {
            var sockCouples = new Dictionary<int, double>();            
            var couples = 0;

            foreach (var sock in ar)
            {
                if (!sockCouples.ContainsKey(sock))
                {
                    sockCouples.Add(sock, 0.5);
                    continue;
                }

                sockCouples[sock] += 0.5;

                if (sockCouples[sock] % 1 == 0)
                    couples++;
            }                        

            return couples;
        }
    }
}
