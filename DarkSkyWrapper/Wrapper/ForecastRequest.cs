using DarkSkyWrapper.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DarkSkyWrapper.Wrapper
{
    public class ForecastRequest
    {
        public Forecast Forecast { get; set; }
        public string Request;
        public ForecastRequest(string Request)
        {
            this.Request = Request;
        }
        public async Task<Forecast> RunAsync()
        {
            string Result = await ReadURL(Request);
            Forecast = JsonConvert.DeserializeObject<Forecast>(Result);
            return Forecast;

        }
        private async Task<String> ReadURL(string Request)
        {
            return await new WebClient().DownloadStringTaskAsync(Request);
        }
    }
}
