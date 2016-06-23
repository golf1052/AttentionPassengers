using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto
{
    public class Mode
    {
        [JsonProperty("route_type")]
        public int RouteType { get; private set; }

        [JsonProperty("mode_name")]
        public string ModeName { get; private set; }

        [JsonProperty("route")]
        public List<Route> Routes { get; private set; }
    }
}