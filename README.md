# DarkSkyWrapper
DarkSkyWrapper API in C#


#Usage

            string Key = "";
            
            float lat = 37.8267f;
            
            float lon = -122.4233f;
            
            List<Exclude> excludes = new List<Exclude> { Exclude.None, Exclude.Flags, Exclude.Hourly };
            
            string uri = new RequestBuilder(new APIKey(Key), new GeoCoords(new Latitude(lat), new Longitute(lon)), Unit.Auto,           DateTime.Now, Language.English, excludes, true).Build();
            
            ForecastRequest forecastRequest = new ForecastRequest(uri);
            
            Forecast forecast = forecastRequest.RunAsync().Result;
            
            
