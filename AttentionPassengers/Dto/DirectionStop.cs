using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto
{
    public class DirectionStop
    {
        [JsonProperty("direction_id")]
        public int DirectionId { get; private set; }

        [JsonProperty("direction_name")]
        public string DirectionName { get; private set; }

        [JsonProperty("stop")]
        public List<Stop> Stops { get; private set; }
    }
}
