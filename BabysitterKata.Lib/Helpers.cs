using System;

namespace BabysitterKata.Lib
{
    public static class Helpers

    {
        public static int CheckValue(string hours)
        {
            var i = 0;
            var result = int.TryParse(hours, out i);
            if (!result) return 0;
                var local = changeToInt(hours);
                return local;
        }

        private static int changeToInt(string hours)
        {
            return Convert.ToInt32(hours);
        }
    }
}