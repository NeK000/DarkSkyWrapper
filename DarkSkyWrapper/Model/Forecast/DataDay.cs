using System;
using System.Collections.Generic;
using System.Text;
using static DarkSkyWrapper.Util.DateLoader;
namespace DarkSkyWrapper.Model
{
    public class DataDay
    {
        private string time;
        private string Sunrise;
        private string Sunset;
        private string IntensityTime;
        private string THighTime;
        private string TLowTime;


        public string Time { get => CorrectDate(time); set => time = value; }
        public string Summary { get; set; }
        public string Icon { get; set; }
        public string SunriseTime { get => CorrectDate(Sunrise); set => Sunrise = value; }
        public string SunsetTime { get => CorrectDate(Sunset); set => Sunset = value; }
        public string MoonPhase { get; set; }
        public string PrecipIntensity { get; set; }
        public string PrecipIntensityMax { get; set; }
        public string PrecipIntensityMaxTime { get => CorrectDate(IntensityTime); set => IntensityTime = value; }
        public string PrecipProbability { get; set; }
        public string PrecipType { get; set; }
        public string TemperatureHigh { get; set; }
        public string TemperatureHighTime { get => CorrectDate(THighTime); set => THighTime = value; }
        public string TemperatureLow { get; set; }
        public string TemperatureLowTime { get => CorrectDate(TLowTime); set => TLowTime = value; }
        public string ApparentTemperatureHigh { get; set; }
        private string ATHighTime;
        public string ApparentTemperatureHighTime { get => CorrectDate(ATHighTime); set => ATHighTime = value; }
        public string ApparentTemperatureLow { get; set; }
        private string ATLowTime;
        public string ApparentTemperatureLowTime { get => CorrectDate(ATLowTime); set => ATLowTime = value; }
        public string DewPoint { get; set; }
        public string Humidity { get; set; }
        public string Pressure { get; set; }
        public string WindSpeed { get; set; }
        public string WindGust { get; set; }
        private string WGustTime;
        public string WindGustTime { get => CorrectDate(WGustTime); set => WGustTime = value; }
        public string WindBearing { get; set; }
        public string CloudCover { get; set; }
        public string UvIndex { get; set; }
        private string UIndexTime;
        public string UvIndexTime { get => CorrectDate(UIndexTime); set => UIndexTime = value; }
        public string Visibility { get; set; }
        public string Ozone { get; set; }
        public string TemperatureMin { get; set; }
        private string TMinTime;
        public string TemperatureMinTime { get => CorrectDate(TMinTime); set => TMinTime = value; }
        public string TemperatureMax { get; set; }
        private string TMaxTime;
        public string TemperatureMaxTime { get => CorrectDate(TMaxTime); set => TMaxTime = value; }
        public string ApparentTemperatureMin { get; set; }
        private string ATMinTime;
        public string ApparentTemperatureMinTime { get => CorrectDate(ATMinTime); set => ATMinTime = value; }
        public string ApparentTemperatureMax { get; set; }
        private string ATMaxTime;
        public string ApparentTemperatureMaxTime { get => CorrectDate(ATMaxTime); set => ATMaxTime = value; }


    }

}
