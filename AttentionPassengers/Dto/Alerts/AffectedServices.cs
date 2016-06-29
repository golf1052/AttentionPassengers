using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto.Alerts
{
    public class AffectedServices
    {
        [JsonProperty("services")]
        public List<Service> Services { get; private set; }

        [JsonProperty("elevators")]
        public List<Elevator> Elevators { get; private set; }
    }
}
