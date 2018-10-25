using System;
using System.Collections.Generic;
using System.Text;

namespace DarkSkyWrapper.Util
{
    public class DateLoader
    {
        public static string CorrectDate(string unix)
        {
            DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            date = date.AddSeconds(long.Parse(unix)).ToLocalTime();
            return date.ToString();
        }
    }
}
