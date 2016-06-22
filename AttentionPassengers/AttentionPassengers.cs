using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttentionPassengers.Dto;
using golf1052.Trexler;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AttentionPassengers
{
    public class AttentionPassengers
    {
        private string ApiKey { get; set; }

        public AttentionPassengers()
        {
            ApiKey = Constants.DevApiKey;
        }

        public AttentionPassengers(string apiKey)
        {
            ApiKey = apiKey;
        }

        // routes
        public async Task<List<Route>> Routes()
        {
            TrexUri uri = new TrexUri(Constants.BaseUrl).AppendPathSegment("routes");
            try
            {
                JObject response = await HelperMethods.GetWebData(new Uri(uri), ApiKey);
                List<Route> routes = new List<Route>();
                foreach (JObject o in (JArray)response["mode"])
                {
                    routes.Add(JsonConvert.DeserializeObject<Route>(o.ToString()));
                }
                return routes;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // routesbystop

        // stopsbyroute
        
        // stopsbylocation

        // schedulebystop

        // schedulebyroutes

        // schedulebyroute

        // schedulebytrip

        // predictionsbystop

        // predictionsbyroutes

        // predictionsbyroute

        // predictionsbytrip

        // vehiclesbyroutes

        // vehiclesbyroute

        // vehiclesbytrip

        // alerts

        // alertsbyroute

        // alertsbystop

        // alertsbyid

        // alertheaders

        // alertheadersbyroute

        // alertheadersbystop

        // servertime
        public async Task<DateTime> ServerTime()
        {
            TrexUri url = new TrexUri(Constants.BaseUrl).AppendPathSegment("servertime");
            try
            {
                JObject response = await HelperMethods.GetWebData(new Uri(url), ApiKey);
                return HelperMethods.EpochToDateTime((long)response["server_dt"]);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
