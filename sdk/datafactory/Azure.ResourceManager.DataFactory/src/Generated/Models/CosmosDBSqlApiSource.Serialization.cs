// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class CosmosDBSqlApiSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Query);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Query.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(PageSize))
            {
                writer.WritePropertyName("pageSize");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PageSize);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PageSize.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(PreferredRegions))
            {
                writer.WritePropertyName("preferredRegions");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PreferredRegions);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PreferredRegions.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(DetectDatetime))
            {
                writer.WritePropertyName("detectDatetime");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DetectDatetime);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DetectDatetime.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AdditionalColumns))
            {
                writer.WritePropertyName("additionalColumns");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AdditionalColumns);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AdditionalColumns.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(CopySourceType);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SourceRetryCount);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SourceRetryCount.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SourceRetryWait);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SourceRetryWait.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MaxConcurrentConnections);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(MaxConcurrentConnections.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DisableMetricsCollection);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DisableMetricsCollection.ToString()).RootElement);
#endif
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBSqlApiSource DeserializeCosmosDBSqlApiSource(JsonElement element)
        {
            Optional<BinaryData> query = default;
            Optional<BinaryData> pageSize = default;
            Optional<BinaryData> preferredRegions = default;
            Optional<BinaryData> detectDatetime = default;
            Optional<BinaryData> additionalColumns = default;
            string type = default;
            Optional<BinaryData> sourceRetryCount = default;
            Optional<BinaryData> sourceRetryWait = default;
            Optional<BinaryData> maxConcurrentConnections = default;
            Optional<BinaryData> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    query = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("pageSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    pageSize = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("preferredRegions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    preferredRegions = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("detectDatetime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    detectDatetime = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("additionalColumns"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    additionalColumns = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceRetryCount = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceRetryWait = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableMetricsCollection = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CosmosDBSqlApiSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, disableMetricsCollection.Value, additionalProperties, query.Value, pageSize.Value, preferredRegions.Value, detectDatetime.Value, additionalColumns.Value);
        }
    }
}
