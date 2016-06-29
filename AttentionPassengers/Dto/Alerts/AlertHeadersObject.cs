using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto.Alerts
{
    public class AlertHeadersObject
    {
        [JsonProperty("alert_headers")]
        public List<AlertHeader> AlertHeaders { get; private set; }
    }
}
