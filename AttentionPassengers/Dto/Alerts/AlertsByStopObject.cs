using Newtonsoft.Json;

namespace AttentionPassengers.Dto.Alerts
{
    public class AlertsByStopObject : AlertsObject
    {
        [JsonProperty("stop_id")]
        public string StopId { get; private set; }

        [JsonProperty("stop_name")]
        public string StopName { get; private set; }
    }
}
