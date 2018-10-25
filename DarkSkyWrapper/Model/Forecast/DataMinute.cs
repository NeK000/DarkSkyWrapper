using static DarkSkyWrapper.Util.DateLoader;
namespace DarkSkyWrapper.Model
{
    public class DataMinute
    {
        private string time;
        public string Time { get => CorrectDate(time); set => time = value; }
        public string PrecipIntensity { get; set; }
        public string PrecipProbability { get; set; }
    }
}