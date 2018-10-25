using System;
using System.Collections.Generic;
using System.Text;

namespace DarkSkyWrapper.Model
{
    public class Forecast
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public string TimeZone { get; set; }

        public CurrentlyData Currently { get; set; }

        public MinutelyData Minutely { get; set; }
        public HourlyData Hourly { get; set; }
        public DailyData Daily { get; set; }
        public FlagsData Flags { get; set; }
        public string Offset { get; set; }
    }
}
