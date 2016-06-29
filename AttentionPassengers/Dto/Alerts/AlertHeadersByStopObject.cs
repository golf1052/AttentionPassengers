using Newtonsoft.Json;

namespace AttentionPassengers.Dto.Alerts
{
    public class AlertHeadersByStopObject : AlertHeadersObject
    {
        [JsonProperty("stop_id")]
        public string StopId;

        [JsonProperty("stop_name")]
        public string StopName;
    }
}
