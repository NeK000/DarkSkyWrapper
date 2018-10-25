using System.Collections.Generic;

namespace DarkSkyWrapper.Model
{
    public class MinutelyData
    {
        public string Summary { get; set; }
        public string Icon { get; set; }
        public List<DataMinute> Data { get; set; }
    }
}