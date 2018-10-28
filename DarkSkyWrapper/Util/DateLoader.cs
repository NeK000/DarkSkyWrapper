using System;
using System.Collections.Generic;
using System.Text;

namespace DarkSkyWrapper.Util
{
    public class DateLoader
    {
        public static string CorrectDate(string UnixStamp)
        {
            DateTime Date = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            Date = Date.AddSeconds(long.Parse(UnixStamp)).ToLocalTime();
            return Date.ToString();
        }
    }
}
