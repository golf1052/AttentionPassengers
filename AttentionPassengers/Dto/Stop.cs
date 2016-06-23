﻿using Newtonsoft.Json;

namespace AttentionPassengers.Dto
{
    public class Stop
    {
        [JsonProperty("stop_order")]
        public int StopOrder { get; private set; }

        [JsonProperty("stop_id")]
        public string StopId { get; private set; }

        [JsonProperty("stop_name")]
        public string StopName { get; private set; }

        [JsonProperty("parent_station")]
        public string ParentStation { get; private set; }

        [JsonProperty("parent_station_name")]
        public string ParentStationName { get; private set; }

        [JsonProperty("stop_lat")]
        public double StopLat { get; private set; }

        [JsonProperty("stop_lon")]
        public double StopLon { get; private set; }
    }
}
