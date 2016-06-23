using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttentionPassengers.Dto;
using AttentionPassengers.Dto.Alerts;
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
        public async Task<RouteList> Routes()
        {
            TrexUri uri = new TrexUri(Constants.BaseUrl).AppendPathSegment("routes");
            try
            {
                string responseString = await HelperMethods.GetWebData(new Uri(uri), ApiKey);
                return JsonConvert.DeserializeObject<RouteList>(responseString);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // routesbystop
        public async Task<RouteStop> RoutesByStop(string stop)
        {
            if (string.IsNullOrEmpty(stop))
            {
                throw new ArgumentNullException(nameof(stop));
            }
            TrexUri uri = new TrexUri(Constants.BaseUrl).AppendPathSegment("routesbystop").SetQueryParam("stop", stop);
            try
            {
                string responseString = await HelperMethods.GetWebData(new Uri(uri), ApiKey);
                return JsonConvert.DeserializeObject<RouteStop>(responseString);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // stopsbyroute
        public async Task<DirectionList> StopsByRoute(string route)
        {
            if (string.IsNullOrEmpty(route))
            {
                throw new ArgumentNullException(nameof(route));
            }
            TrexUri uri = new TrexUri(Constants.BaseUrl).AppendPathSegment("stopsbyroute").SetQueryParam("route", route);
            try
            {
                string responseString = await HelperMethods.GetWebData(new Uri(uri), ApiKey);
                return JsonConvert.DeserializeObject<DirectionList>(responseString);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        // stopsbylocation
        public async Task<StopList> StopsByLocation(double lat, double lon)
        {
            TrexUri uri = new TrexUri(Constants.BaseUrl).AppendPathSegment("stopsbylocation").SetQueryParams(new Dictionary<string, object>
            {
                { "lat", lat },
                { "lon", lon }
            });
            try
            {
                string responseString = await HelperMethods.GetWebData(new Uri(uri), ApiKey);
                return JsonConvert.DeserializeObject<StopList>(responseString);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

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
        public async Task<AlertsObject> Alerts(bool includeAccessAlerts = false, bool includeServiceAlerts = true)
        {
            TrexUri uri = new TrexUri(Constants.BaseUrl).AppendPathSegment("alerts").SetQueryParams(new Dictionary<string, object>
            {
                { "include_access_alerts", includeAccessAlerts },
                { "include_service_alerts", includeServiceAlerts }
            });
            try
            {
                string responseString = await HelperMethods.GetWebData(new Uri(uri), ApiKey);
                return JsonConvert.DeserializeObject<AlertsObject>(responseString);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

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
                JObject response = (await HelperMethods.GetWebData(new Uri(url), ApiKey)).ToJObject();
                return HelperMethods.EpochToDateTime((long)response["server_dt"]);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
