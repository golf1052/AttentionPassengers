using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto
{
    public class RouteStop
    {
        [JsonProperty("stop_id")]
        public string StopId { get; private set; }

        [JsonProperty("stop_name")]
        public string StopName { get; private set; }

        [JsonProperty("mode")]
        public List<Mode> Modes { get; private set; }
    }
}
