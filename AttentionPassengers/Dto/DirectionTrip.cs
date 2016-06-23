using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto
{
    public class DirectionTrip
    {
        [JsonProperty("direction_id")]
        public int DirectionId { get; private set; }

        [JsonProperty("direction_name")]
        public string DirectionName { get; private set; }

        [JsonProperty("trip")]
        public List<Trip> Trips { get; private set; }
    }
}
