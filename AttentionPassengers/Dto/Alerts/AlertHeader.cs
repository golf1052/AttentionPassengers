using Newtonsoft.Json;

namespace AttentionPassengers.Dto.Alerts
{
    public class AlertHeader
    {
        [JsonProperty("alert_id")]
        public int AlertId { get; private set; }

        [JsonProperty("header_text")]
        public string HeaderText { get; private set; }
    }
}
