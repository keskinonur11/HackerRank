namespace HackerRank
{
    public static class PalindromeProblem
    {
        //https://www.hackerrank.com/challenges/palindrome-index/problem
        public static int PalindromeIndex(string s)
        {
            var data = s.ToList();

            var lastIndex = data.Count - 1;
            var mid = lastIndex / 2;

            for (var i = 0; i < data.Count; i++)
            {
                if (data[i] == data[lastIndex])
                {
                    if (i == mid - 1 || data.Count == 2)
                        return -1;

                    lastIndex -= 1;
                    continue;
                }

                var dataCopy = s.ToList();
                dataCopy.RemoveAt(lastIndex);

                var control = PalindControl(dataCopy);

                if (control)
                    return lastIndex;

                dataCopy = s.ToList();
                dataCopy.RemoveAt(i);
                control = PalindControl(dataCopy);

                if (control)
                    return i;
            }

            return -1;
        }

        public static bool PalindControl(List<char> data)
        {
            if (data.Count == 2)
            {
                return data[0] == data[1];
            }

            var isOdd = data.Count % 2 == 1;

            var mid = isOdd ? data.Count / 2 : (data.Count - 1) / 2;
            var firshHalf = isOdd ? new string(data.ToArray()).Substring(0, mid) : new string(data.ToArray()).Substring(0, mid + 1);
            var secondHalf = isOdd ? new string(new string(data.ToArray()).Substring(mid + 1, mid).Reverse().ToArray()) : 
                new string(new string(data.ToArray()).Substring(mid + 1, mid + 1).Reverse().ToArray());

            return firshHalf == secondHalf;
        }
    }
}
