using System;

namespace BabysitterKata.Lib
{
    public static class Helpers

    {
        public static bool AfterMidnightAnswer;
        public static int CheckValue(string hours)
        {
            var result = int.TryParse(hours, out _);
            return result ? changeToInt(hours) : parseDouble(hours);
        }

        private static int changeToInt(string hours)
        {
            return Convert.ToInt32(hours);
        }

        private static int parseDouble(string hours)
        {
            double.TryParse(hours, out var x);
            var local = Math.Floor(x);
            return Convert.ToInt32(local);
        }

        public static void questionHandler(string question)
        {
            if (question == "Yes")
            {
                AfterMidnightAnswer = true;
            }
            else
            {
               AfterMidnightAnswer = false;
            }
            
        }
    }
}