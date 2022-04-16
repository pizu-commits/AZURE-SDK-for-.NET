// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query");
                writer.WriteStringValue(Query);
            }
            if (Optional.IsCollectionDefined(AuthorizedResources))
            {
                writer.WritePropertyName("authorizedResources");
                writer.WriteStartArray();
                foreach (var item in AuthorizedResources)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("dataSourceId");
            writer.WriteStringValue(DataSourceId);
            if (Optional.IsDefined(QueryType))
            {
                writer.WritePropertyName("queryType");
                writer.WriteStringValue(QueryType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static MonitorSource DeserializeMonitorSource(JsonElement element)
        {
            Optional<string> query = default;
            Optional<IList<string>> authorizedResources = default;
            string dataSourceId = default;
            Optional<QueryType> queryType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorizedResources"))
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
                    authorizedResources = array;
                    continue;
                }
                if (property.NameEquals("dataSourceId"))
                {
                    dataSourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    queryType = new QueryType(property.Value.GetString());
                    continue;
                }
            }
            return new MonitorSource(query.Value, Optional.ToList(authorizedResources), dataSourceId, Optional.ToNullable(queryType));
        }
    }
}
