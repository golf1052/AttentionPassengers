using System;
using AttentionPassengers.Converters;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto.Alerts
{
    public class EffectPeriod
    {
        [JsonProperty("effect_start")]
        [JsonConverter(typeof(EpochDateTimeConverter))]
        public DateTime EffectStart { get; private set; }

        [JsonProperty("effect_end")]
        [JsonConverter(typeof(EpochDateTimeConverter))]
        public DateTime? EffectEnd { get; private set; }
    }
}
