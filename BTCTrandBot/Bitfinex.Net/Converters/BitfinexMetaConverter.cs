﻿using System;
using System.Collections.Generic;
using System.Text;
using Bitfinex.Net.Objects.SocketObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Bitfinex.Net.Converters
{
    internal class BitfinexMetaConverter: JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            var data = JObject.Load(reader);
            return data.ToObject<BitfinexMeta>();
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
