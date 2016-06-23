using System;
using AttentionPassengers.Converters;
using Newtonsoft.Json;

namespace AttentionPassengers.Dto
{
    public class Trip
    {
        [JsonProperty("trip_id")]
        public string TripId { get; private set; }

        [JsonProperty("trip_name")]
        public string TripName { get; private set; }

        [JsonProperty("sch_arr_dt")]
        [JsonConverter(typeof(EpochDateTimeConverter))]
        public DateTime ScheduledArrivalTime { get; private set; }

        [JsonProperty("sch_dep_td")]
        [JsonConverter(typeof(EpochDateTimeConverter))]
        public DateTime ScheduledDepartureTime { get; private set; }
    }
}
