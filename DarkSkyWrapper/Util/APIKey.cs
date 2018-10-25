using System;
using System.Collections.Generic;
using System.Text;
using static DarkSkyWrapper.Assert.Assert;
namespace DarkSkyWrapper.Util
{
    public class APIKey
    {
        public string APIKeyValue { get; set; }

        public APIKey(string Key)
        {
            NotNullOrEmpty(Key, "API Key cannot be empty", "API Key cannot be null");
            APIKeyValue = Key;
        }

    }
}
