using System;

namespace BabysitterKata.Lib
{
    public static class Helpers

    {
        public static int CheckValue(string hours)
        {
            var result = int.TryParse(hours, out _);
            if (result)
            {
                return changeToInt(hours);
            }
            {
                return parseDouble(hours);
            }
                
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
    }
}