// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class DataMasking : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(QueryParams))
            {
                writer.WritePropertyName("queryParams");
                writer.WriteStartArray();
                foreach (var item in QueryParams)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers");
                writer.WriteStartArray();
                foreach (var item in Headers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DataMasking DeserializeDataMasking(JsonElement element)
        {
            Optional<IList<DataMaskingEntity>> queryParams = default;
            Optional<IList<DataMaskingEntity>> headers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryParams"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataMaskingEntity> array = new List<DataMaskingEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataMaskingEntity.DeserializeDataMaskingEntity(item));
                    }
                    queryParams = array;
                    continue;
                }
                if (property.NameEquals("headers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataMaskingEntity> array = new List<DataMaskingEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataMaskingEntity.DeserializeDataMaskingEntity(item));
                    }
                    headers = array;
                    continue;
                }
            }
            return new DataMasking(Optional.ToList(queryParams), Optional.ToList(headers));
        }
    }
}
