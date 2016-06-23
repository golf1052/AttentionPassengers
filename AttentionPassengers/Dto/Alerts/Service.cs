using System.ComponentModel;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto.Alerts
{
    public class Service
    {
        [JsonProperty("route_type")]
        public int? RouteType { get; private set; }

        [JsonProperty("mode_name")]
        public string ModeName { get; private set; }

        [JsonProperty("route_id")]
        public string RouteId { get; private set; }

        [JsonProperty("route_name")]
        public string RouteName { get; private set; }

        [DefaultValue(false)]
        [JsonProperty("route_hide", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool RouteHide { get; private set; }

        [JsonProperty("direction_id")]
        public int? DirectionId { get; private set; }

        [JsonProperty("direction_name")]
        public string DirectionName { get; private set; }

        [JsonProperty("trip_id")]
        public string TripId { get; private set; }

        [JsonProperty("trip_name")]
        public string TripName { get; private set; }

        [JsonProperty("stop_id")]
        public string StopId { get; private set; }

        [JsonProperty("stop_name")]
        public string StopName { get; private set; }
    }
}
