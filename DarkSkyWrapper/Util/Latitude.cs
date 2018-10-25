using static DarkSkyWrapper.Assert.Assert;
namespace DarkSkyWrapper.Util
{
    public class Latitude
    {
        public float Lat { get; set; }

        public Latitude(float latitude)

        {
            NotNull(latitude, "Latitude cannot be null");
            LatitudeCheck(latitude, "Latitude value must be between 90 and -90");
            Lat = latitude;
        }
    }
}