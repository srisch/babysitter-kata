using System;

namespace BabysitterKata.Lib
{
    public static class Time
    {
        public static int ParseTime(string date)
        {
            var split = date.Split(':');
            return Convert.ToInt32(split[0]);
        }
    }
}