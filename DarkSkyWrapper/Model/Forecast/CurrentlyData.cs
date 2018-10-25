namespace DarkSkyWrapper.Model
{
    public class CurrentlyData
    {
        public string Time { get; set; }
        public string Summary { get; set; }
        public string Icon { get; set; }
        public string NearestStormDistance { get; set; }
        public string NearestStormBearing { get; set; }
        public string PrecipIntensity { get; set; }
        public string PrecipProbability { get; set; }
        public string Temperature { get; set; }
        public string ApparentTemperature { get; set; }
        public string DewPoint { get; set; }
        public string Humidity { get; set; }
        public string Pressure { get; set; }
        public string WindSpeed { get; set; }
        public string WindGust { get; set; }
        public string WindBearing { get; set; }
        public string CloudCover { get; set; }
        public string UvIndex { get; set; }
        public string Visibility { get; set; }
        public string Ozone { get; set; }
    }
}