using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto.Alerts
{
    public class AlertsObject
    {
        [JsonProperty("alerts")]
        public List<Alert> Alerts { get; private set; }
    }
}
