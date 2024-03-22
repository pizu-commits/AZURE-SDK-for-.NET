// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class DataCollectionRuleData : IUtf8JsonSerializable, IJsonModel<DataCollectionRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionRuleData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataCollectionRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(ImmutableId))
            {
                writer.WritePropertyName("immutableId"u8);
                writer.WriteStringValue(ImmutableId);
            }
            if (Optional.IsDefined(DataCollectionEndpointId))
            {
                writer.WritePropertyName("dataCollectionEndpointId"u8);
                writer.WriteStringValue(DataCollectionEndpointId);
            }
            if (options.Format != "W" && Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue<DataCollectionRuleMetadata>(Metadata, options);
            }
            if (Optional.IsCollectionDefined(StreamDeclarations))
            {
                writer.WritePropertyName("streamDeclarations"u8);
                writer.WriteStartObject();
                foreach (var item in StreamDeclarations)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue<DataStreamDeclaration>(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(DataSources))
            {
                writer.WritePropertyName("dataSources"u8);
                writer.WriteObjectValue<DataCollectionRuleDataSources>(DataSources, options);
            }
            if (Optional.IsDefined(Destinations))
            {
                writer.WritePropertyName("destinations"u8);
                writer.WriteObjectValue<DataCollectionRuleDestinations>(Destinations, options);
            }
            if (Optional.IsCollectionDefined(DataFlows))
            {
                writer.WritePropertyName("dataFlows"u8);
                writer.WriteStartArray();
                foreach (var item in DataFlows)
                {
                    writer.WriteObjectValue<DataFlow>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
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
            }
            writer.WriteEndObject();
        }

        DataCollectionRuleData IJsonModel<DataCollectionRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionRuleData(document.RootElement, options);
        }

        internal static DataCollectionRuleData DeserializeDataCollectionRuleData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataCollectionRuleResourceKind? kind = default;
            ManagedServiceIdentity identity = default;
            ETag? etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string description = default;
            string immutableId = default;
            ResourceIdentifier dataCollectionEndpointId = default;
            DataCollectionRuleMetadata metadata = default;
            IDictionary<string, DataStreamDeclaration> streamDeclarations = default;
            DataCollectionRuleDataSources dataSources = default;
            DataCollectionRuleDestinations destinations = default;
            IList<DataFlow> dataFlows = default;
            DataCollectionRuleProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new DataCollectionRuleResourceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("immutableId"u8))
                        {
                            immutableId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataCollectionEndpointId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataCollectionEndpointId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = DataCollectionRuleMetadata.DeserializeDataCollectionRuleMetadata(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("streamDeclarations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, DataStreamDeclaration> dictionary = new Dictionary<string, DataStreamDeclaration>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, DataStreamDeclaration.DeserializeDataStreamDeclaration(property1.Value, options));
                            }
                            streamDeclarations = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("dataSources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataSources = DataCollectionRuleDataSources.DeserializeDataCollectionRuleDataSources(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("destinations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            destinations = DataCollectionRuleDestinations.DeserializeDataCollectionRuleDestinations(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dataFlows"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataFlow> array = new List<DataFlow>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataFlow.DeserializeDataFlow(item, options));
                            }
                            dataFlows = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DataCollectionRuleProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataCollectionRuleData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                kind,
                identity,
                etag,
                description,
                immutableId,
                dataCollectionEndpointId,
                metadata,
                streamDeclarations ?? new ChangeTrackingDictionary<string, DataStreamDeclaration>(),
                dataSources,
                destinations,
                dataFlows ?? new ChangeTrackingList<DataFlow>(),
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionRuleData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRuleData)} does not support writing '{options.Format}' format.");
            }
        }

        DataCollectionRuleData IPersistableModel<DataCollectionRuleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataCollectionRuleData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRuleData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollectionRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
