using System.Collections.Generic;

namespace DarkSkyWrapper.Model
{
    public class DailyData
    {
        public string Summary { get; set; }
        public string Icon { get; set; }
        public List<Data> Data { get; set; }

    }
}