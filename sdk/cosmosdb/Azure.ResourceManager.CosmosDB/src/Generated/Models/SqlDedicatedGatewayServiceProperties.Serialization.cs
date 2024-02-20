// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class SqlDedicatedGatewayServiceProperties : IUtf8JsonSerializable, IJsonModel<SqlDedicatedGatewayServiceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlDedicatedGatewayServiceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlDedicatedGatewayServiceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDedicatedGatewayServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlDedicatedGatewayServiceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SqlDedicatedGatewayEndpoint))
            {
                writer.WritePropertyName("sqlDedicatedGatewayEndpoint"u8);
                writer.WriteStringValue(SqlDedicatedGatewayEndpoint);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(InstanceSize))
            {
                writer.WritePropertyName("instanceSize"u8);
                writer.WriteStringValue(InstanceSize.Value.ToString());
            }
            if (Optional.IsDefined(InstanceCount))
            {
                writer.WritePropertyName("instanceCount"u8);
                writer.WriteNumberValue(InstanceCount.Value);
            }
            writer.WritePropertyName("serviceType"u8);
            writer.WriteStringValue(ServiceType.ToString());
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        SqlDedicatedGatewayServiceProperties IJsonModel<SqlDedicatedGatewayServiceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDedicatedGatewayServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlDedicatedGatewayServiceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlDedicatedGatewayServiceProperties(document.RootElement, options);
        }

        internal static SqlDedicatedGatewayServiceProperties DeserializeSqlDedicatedGatewayServiceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sqlDedicatedGatewayEndpoint = default;
            Optional<IReadOnlyList<SqlDedicatedGatewayRegionalService>> locations = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<CosmosDBServiceSize> instanceSize = default;
            Optional<int> instanceCount = default;
            CosmosDBServiceType serviceType = default;
            Optional<CosmosDBServiceStatus> status = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlDedicatedGatewayEndpoint"u8))
                {
                    sqlDedicatedGatewayEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlDedicatedGatewayRegionalService> array = new List<SqlDedicatedGatewayRegionalService>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlDedicatedGatewayRegionalService.DeserializeSqlDedicatedGatewayRegionalService(item, options));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("instanceSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceSize = new CosmosDBServiceSize(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("serviceType"u8))
                {
                    serviceType = new CosmosDBServiceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new CosmosDBServiceStatus(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SqlDedicatedGatewayServiceProperties(Optional.ToNullable(creationTime), Optional.ToNullable(instanceSize), Optional.ToNullable(instanceCount), serviceType, Optional.ToNullable(status), additionalProperties, sqlDedicatedGatewayEndpoint.Value, Optional.ToList(locations));
        }

        BinaryData IPersistableModel<SqlDedicatedGatewayServiceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDedicatedGatewayServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlDedicatedGatewayServiceProperties)} does not support '{options.Format}' format.");
            }
        }

        SqlDedicatedGatewayServiceProperties IPersistableModel<SqlDedicatedGatewayServiceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDedicatedGatewayServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlDedicatedGatewayServiceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlDedicatedGatewayServiceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlDedicatedGatewayServiceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
