using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using AttentionPassengers.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AttentionPassengers.Dto.Alerts
{
    public class Alert
    {
        public enum AlertSeverity
        {
            Severe,
            Significant,
            Moderate,
            Minor,
            Information
        }

        public enum AlertLifecycles
        {
            [EnumMember(Value = "Upcoming")]
            Upcoming,

            [EnumMember(Value = "New")]
            New,

            [EnumMember(Value = "Ongoing")]
            Ongoing,

            [EnumMember(Value = "Ongoing-Upcoming")]
            OngoingUpcoming
        }

        [JsonProperty("alert_id")]
        public int AlertId { get; private set; }

        [JsonProperty("effect_name")]
        public string EffectName { get; private set; }

        [JsonProperty("effect")]
        public string Effect { get; private set; }

        [JsonProperty("cause_name")]
        public string CauseName { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }

        [JsonProperty("header_text")]
        public string HeaderText { get; private set; }

        [JsonProperty("short_header_text")]
        public string ShortHeaderText { get; private set; }

        [JsonProperty("url")]
        public string Url { get; private set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; private set; }

        [JsonProperty("description_text")]
        public string DescriptionText { get; private set; }

        [JsonProperty("severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AlertSeverity Severity { get; private set; }

        [JsonProperty("created_dt")]
        [JsonConverter(typeof(EpochDateTimeConverter))]
        public DateTime Created { get; private set; }

        [JsonProperty("last_modified_dt")]
        [JsonConverter(typeof(EpochDateTimeConverter))]
        public DateTime LastModified { get; private set; }

        [JsonProperty("service_effect_text")]
        public string ServiceEffectText { get; private set; }

        [JsonProperty("timeframe_text")]
        public string TimeframeText { get; private set; }

        [JsonProperty("alert_lifecycle")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AlertLifecycles AlertLifecycle { get; private set; }

        [JsonProperty("banner_text")]
        public string BannerText { get; private set; }

        [JsonProperty("announcement_text")]
        public string AnnouncementText { get; private set; }

        [JsonProperty("effect_periods")]
        public List<EffectPeriod> EffectPeriods { get; private set; }

        [JsonProperty("affected_services")]
        public AffectedServices AffectedServices { get; private set; }
    }
}
