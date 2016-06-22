using Newtonsoft.Json;

namespace AttentionPassengers.Dto
{
    public class RouteInfo
    {
        [JsonProperty("route_id")]
        public string RouteId { get; set; }

        [JsonProperty("route_name")]
        public string RouteName { get; set; }
    }
}