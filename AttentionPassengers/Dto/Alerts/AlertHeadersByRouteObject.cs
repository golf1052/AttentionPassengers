using Newtonsoft.Json;

namespace AttentionPassengers.Dto.Alerts
{
    public class AlertHeadersByRouteObject : AlertHeadersObject
    {
        [JsonProperty("route_id")]
        public string RouteId;

        [JsonProperty("route_name")]
        public string RouteName;
    }
}
