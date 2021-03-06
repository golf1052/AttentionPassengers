﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AttentionPassengers.Converters
{
    public class EpochDateTimeConverter : DateTimeConverterBase
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return null;
            }
            else
            {
                string stringValue = (string)reader.Value;
                if (string.IsNullOrEmpty(stringValue))
                {
                    return null;
                }
                return epoch.AddSeconds(double.Parse(stringValue));
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(((DateTime)value - epoch).TotalSeconds.ToString());
        }
    }
}
