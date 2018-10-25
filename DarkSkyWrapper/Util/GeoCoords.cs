using System;
using System.Collections.Generic;
using System.Text;

namespace DarkSkyWrapper.Util
{
    public class GeoCoords
    {
        public Latitude lat { get; set; }
        public Longitute lon { get; set; }
        public GeoCoords(Latitude latitude, Longitute longitute)
        {
            lat = latitude;
            lon = longitute;
        }
    }
}
