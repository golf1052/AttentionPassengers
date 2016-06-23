using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto
{
    public class RouteList
    {
        [JsonProperty("mode")]
        public List<Mode> Modes { get; private set; }
    }
}
