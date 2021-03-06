using System.ComponentModel;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto
{
    public class Route
    {
        [JsonProperty("route_id")]
        public string RouteId { get; private set; }

        [JsonProperty("route_name")]
        public string RouteName { get; private set; }

        [DefaultValue(false)]
        [JsonProperty("route_hide", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool RouteHide { get; private set; }
    }
}