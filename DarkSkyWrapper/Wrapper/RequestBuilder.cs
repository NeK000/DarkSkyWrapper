using DarkSkyWrapper.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace DarkSkyWrapper.Wrapper
{
    public enum Unit { None, Auto, Ca, Uk2, Us, Si };
    public enum Language { None, English, Danish };
    public enum Exclude { None, Currently, Minutely, Hourly, Daily, Alerts, Flags };

    public class RequestBuilder
    {
        private string APIKey;
        private float Latitude;
        private float Longitude;
        private Unit Unit;
        private DateTime DateTime;
        private Language Language;
        private List<Exclude> Excludes;
        private bool Extend;
        private bool QuestionMark;
        public RequestBuilder(APIKey Key, GeoCoords coordinates, Unit unit, DateTime dateTime, Language language, List<Exclude> exclude, bool extendHourly)
        {
            QuestionMark = false;
            APIKey = Key.APIKeyValue;
            Latitude = coordinates.lat.Lat;
            Longitude = coordinates.lon.Lon;
            this.DateTime = dateTime;
            this.Unit = unit;
            this.Language = language;
            this.Excludes = exclude;
            this.Extend = extendHourly;
        }

        public string Build()
        {
            StringBuilder call = new StringBuilder();
            call.Append("https://api.darksky.net/forecast/");
            call.Append(this.APIKey).Append("/");
            call.Append(this.Latitude.ToString()).Append(",").Append(this.Longitude.ToString());
            call.Append(GetData(this.DateTime));
            call.Append(GetUnit(this.Unit));
            call.Append(GetLang(this.Language));
            call.Append(GetExclude(this.Excludes));
            if (this.Extend) call.Append("&extend=hourly");
            return call.ToString();
        }
        private string GetUnit(Unit unit)
        {
            string unitsAPI;
            string Default;
            if (QuestionMark)
            {
                unitsAPI = "&units=";
                Default = unitsAPI + "auto";
            }
            else
            {
                QuestionMark = true;
                unitsAPI = "?units=";
                Default = unitsAPI + "auto";
            }
            switch (unit)
            {
                case Unit.None:
                    return Default;
                case Unit.Auto:
                    return Default;
                case Unit.Ca:
                    return unitsAPI + "ca";
                case Unit.Uk2:
                    return unitsAPI + "uk2";
                case Unit.Us:
                    return unitsAPI + "us";
                case Unit.Si:
                    return unitsAPI + "si";
                default:
                    return Default;

            }
        }
        private string GetData(DateTime date)
        {
            if (date == null) return "";
            else
            {
                return "," + ((DateTimeOffset)date).ToUnixTimeSeconds().ToString();
            }
        }
        private string GetLang(Language language)
        {
            string LangAPI;
            string Default;
            if (QuestionMark)
            {
                LangAPI = "&lang=";
                Default = LangAPI + "en";
            }
            else
            {
                QuestionMark = true;
                LangAPI = "?lang=";
                Default = LangAPI + "en";
            }

            switch (language)
            {
                case Language.None:
                    return Default;
                case Language.Danish:
                    return LangAPI + "da";
                case Language.English:
                    return Default;
                default:
                    return Default;
            }
        }
        private string GetExclude(List<Exclude> excludes)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (QuestionMark)
            {
                stringBuilder.Append("&exclude=");
            }
            else
            {
                QuestionMark = true;
                stringBuilder.Append("?exclude=");

            }
            if (excludes.Contains(Exclude.None)) return "";
            else
                for (int i = 0; i < excludes.Count; i++)
                {
                    stringBuilder.Append(ProperString(excludes[i]));
                    if (i < excludes.Count - 1) stringBuilder.Append(",");
                }
            return stringBuilder.ToString();

            string ProperString(Exclude item)
            {
                switch (item)
                {
                    case Exclude.Currently:
                        return "currently";
                    case Exclude.Minutely:
                        return "minutely";
                    case Exclude.Hourly:
                        return "hourly";
                    case Exclude.Daily:
                        return "daily";
                    case Exclude.Alerts:
                        return "alerts";
                    case Exclude.Flags:
                        return "flags";
                    default:
                        return "";

                }
            }
        }
    }
}
