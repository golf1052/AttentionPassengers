using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto
{
    public class RouteScheduleDirection
    {
        [JsonProperty("route_id")]
        public string RouteId { get; private set; }

        [JsonProperty("route_name")]
        public string RouteName { get; private set; }

        [JsonProperty("direction")]
        public List<DirectionTrip> Direction { get; private set; }
    }
}
