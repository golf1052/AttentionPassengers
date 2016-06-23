using Newtonsoft.Json;

namespace AttentionPassengers.Dto.Alerts
{
    public class Stop
    {
        [JsonProperty("stop_id")]
        public string StopId { get; private set; }

        [JsonProperty("stop_name")]
        public string StopName { get; private set; }

        [JsonProperty("parent_station")]
        public string ParentStation { get; private set; }

        [JsonProperty("parent_station_name")]
        public string ParentStationName { get; private set; }
    }
}
