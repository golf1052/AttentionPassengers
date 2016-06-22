using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto
{
    public class Route
    {
        [JsonProperty("route_type")]
        public int RouteType { get; set; }

        [JsonProperty("mode_name")]
        public string ModeName { get; set; }

        [JsonProperty("route")]
        public List<RouteInfo> Routes { get; set; }
    }
}