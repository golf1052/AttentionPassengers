using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto
{
    public class StopList
    {
        [JsonProperty("lat")]
        public double Lat { get; private set; }

        [JsonProperty("lon")]
        public double Lon { get; private set; }

        [JsonProperty("stop")]
        public List<StopLocation> Stops { get; private set; }
    }
}
