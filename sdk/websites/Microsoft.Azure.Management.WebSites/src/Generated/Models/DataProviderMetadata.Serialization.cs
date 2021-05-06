// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class DataProviderMetadata : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProviderName))
            {
                writer.WritePropertyName("providerName");
                writer.WriteStringValue(ProviderName);
            }
            writer.WriteEndObject();
        }

        internal static DataProviderMetadata DeserializeDataProviderMetadata(JsonElement element)
        {
            Optional<string> providerName = default;
            Optional<IReadOnlyList<KeyValuePairStringObject>> propertyBag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerName"))
                {
                    providerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("propertyBag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KeyValuePairStringObject> array = new List<KeyValuePairStringObject>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KeyValuePairStringObject.DeserializeKeyValuePairStringObject(item));
                    }
                    propertyBag = array;
                    continue;
                }
            }
            return new DataProviderMetadata(providerName.Value, Optional.ToList(propertyBag));
        }
    }
}
