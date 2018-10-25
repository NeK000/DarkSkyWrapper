using static DarkSkyWrapper.Assert.Assert;
namespace DarkSkyWrapper.Util
{
    public class Longitute
    {
        public float Lon { get; set; }
        public Longitute(float longitute)
        {
            NotNull(longitute, "Longitute cannot be null");
            LongitudeCheck(longitute, "Longitude value must be between 180 and -180");
            Lon = longitute;
        }
    }
}