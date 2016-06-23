using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using golf1052.Trexler;
using System.Collections.Generic;

namespace AttentionPassengers
{
    public static class HelperMethods
    {
        public static async Task<string> GetWebData(Uri uri, string apiKey)
        {
            HttpClient client = new HttpClient();
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentNullException(nameof(apiKey));
            }
            uri = new Uri(new TrexUri(uri.ToString()).SetQueryParams(new Dictionary<string, object>()
            {
                { "api_key", apiKey },
                { "format", "json" }
            }));
            HttpResponseMessage response = await client.GetAsync(uri);
            string responseString;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                responseString = await response.Content.ReadAsStringAsync();
                throw new Exception($"MBTA exception:\n{responseString}");
            }
        }

        public static JObject ToJObject(this string str)
        {
            return JObject.Parse(str);
        }

        /// <summary>
        /// Converts a epoch date time (milliseconds) to a C# DateTime
        /// </summary>
        /// <param name="date">Date as an epoch time (milliseconds)</param>
        /// <returns>A C# DateTime (UTC)</returns>
        public static DateTime EpochToDateTime(long date)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(date);
        }
    }
}
