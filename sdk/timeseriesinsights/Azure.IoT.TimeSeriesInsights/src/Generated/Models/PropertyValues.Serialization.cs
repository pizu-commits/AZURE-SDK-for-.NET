// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class PropertyValues : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ValuesInternal))
            {
                writer.WritePropertyName("values");
                ValuesInternal.WriteTo(writer);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static PropertyValues DeserializePropertyValues(JsonElement element)
        {
            Optional<JsonElement> values = default;
            Optional<string> name = default;
            Optional<PropertyTypes> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("values"))
                {
                    values = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new PropertyTypes(property.Value.GetString());
                    continue;
                }
            }
            return new PropertyValues(name.Value, Optional.ToNullable(type), values);
        }
    }
}
