using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AttentionPassengers.Dto.Alerts
{
    public class Elevator
    {
        public enum ElevatorTypes
        {
            Elevator,
            Escalator,
            Lift
        }

        [JsonProperty("elev_id")]
        public string ElevatorId { get; private set; }

        [JsonProperty("elev_name")]
        public string ElevatorName { get; private set; }

        [JsonProperty("elev_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ElevatorTypes ElevatorType { get; private set; }

        [JsonProperty("stops")]
        public List<Stop> Stops { get; private set; }
    }
}
