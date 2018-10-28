using System;
using System.Collections.Generic;
using System.Text;

namespace DarkSkyWrapper.Util
{
    public class GeoCoords
    {
        public Latitude Lat { get; set; }
        public Longitute Lon { get; set; }
        public GeoCoords(Latitude latitude, Longitute longitute)
        {
            Lat = latitude;
            Lon = longitute;
        }
    }
}
