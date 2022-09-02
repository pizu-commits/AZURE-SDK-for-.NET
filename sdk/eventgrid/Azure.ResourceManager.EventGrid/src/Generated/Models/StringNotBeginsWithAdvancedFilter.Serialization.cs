// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class StringNotBeginsWithAdvancedFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values");
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("operatorType");
            writer.WriteStringValue(OperatorType.ToString());
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key");
                writer.WriteStringValue(Key);
            }
            writer.WriteEndObject();
        }

        internal static StringNotBeginsWithAdvancedFilter DeserializeStringNotBeginsWithAdvancedFilter(JsonElement element)
        {
            Optional<IList<string>> values = default;
            AdvancedFilterOperatorType operatorType = default;
            Optional<string> key = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("values"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("operatorType"))
                {
                    operatorType = new AdvancedFilterOperatorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"))
                {
                    key = property.Value.GetString();
                    continue;
                }
            }
            return new StringNotBeginsWithAdvancedFilter(operatorType, key.Value, Optional.ToList(values));
        }
    }
}
