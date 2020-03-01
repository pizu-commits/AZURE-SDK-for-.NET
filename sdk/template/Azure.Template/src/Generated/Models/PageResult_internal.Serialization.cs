// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.FormRecognizer.Models;
using Azure.Core;

namespace Azure.AI.FormRecognizer
{
    internal partial class PageResult_internal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("page");
            writer.WriteNumberValue(Page);
            if (ClusterId != null)
            {
                writer.WritePropertyName("clusterId");
                writer.WriteNumberValue(ClusterId.Value);
            }
            if (KeyValuePairs != null)
            {
                writer.WritePropertyName("keyValuePairs");
                writer.WriteStartArray();
                foreach (var item in KeyValuePairs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Tables != null)
            {
                writer.WritePropertyName("tables");
                writer.WriteStartArray();
                foreach (var item in Tables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static PageResult_internal DeserializePageResult_internal(JsonElement element)
        {
            PageResult_internal result = new PageResult_internal();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("page"))
                {
                    result.Page = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("clusterId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ClusterId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("keyValuePairs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.KeyValuePairs = new List<KeyValuePair_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.KeyValuePairs.Add(KeyValuePair_internal.DeserializeKeyValuePair_internal(item));
                    }
                    continue;
                }
                if (property.NameEquals("tables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Tables = new List<DataTable_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Tables.Add(DataTable_internal.DeserializeDataTable_internal(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
