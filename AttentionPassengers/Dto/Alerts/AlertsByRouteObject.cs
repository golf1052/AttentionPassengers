using Newtonsoft.Json;

namespace AttentionPassengers.Dto.Alerts
{
    public class AlertsByRouteObject : AlertsObject
    {
        [JsonProperty("route_id")]
        public string RouteId { get; private set; }

        [JsonProperty("route_name")]
        public string RouteName { get; private set; }
    }
}
