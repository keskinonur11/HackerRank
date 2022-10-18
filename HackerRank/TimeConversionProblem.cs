namespace HackerRank
{
    public static class TimeConversionProblem
    {
        //https://www.hackerrank.com/challenges/one-month-preparation-kit-time-conversion/problem

        public static string TimeConversion(string s)
        {            
            var isAM = s[8..].Equals("AM");
            s = s.Remove(8, 2);
            var timePieces = s.Split(':');

            if (isAM)
            {
                if (timePieces[0].Equals("12"))
                    timePieces[0] = "00";
            }
            else
            {               
                var hour = timePieces[0] switch
                {
                    "01" => "13",
                    "02" => "14",
                    "03" => "15",
                    "04" => "16",
                    "05" => "17",
                    "06" => "18",
                    "07" => "19",
                    "08" => "20",
                    "09" => "21",
                    "10" => "22",
                    "11" => "23",
                    "12" => "12",
                    _ => ""
                };

                timePieces[0] = hour;
            }

            return string.Join(":", timePieces);
        }
    }
}
