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

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeDeviceCapacityInfo : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeDeviceCapacityInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeDeviceCapacityInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxEdgeDeviceCapacityInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceCapacityInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeDeviceCapacityInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(TimeStamp))
            {
                writer.WritePropertyName("timeStamp"u8);
                writer.WriteStringValue(TimeStamp.Value, "O");
            }
            if (Optional.IsDefined(ClusterStorageCapacityInfo))
            {
                writer.WritePropertyName("clusterStorageCapacityInfo"u8);
                writer.WriteObjectValue(ClusterStorageCapacityInfo);
            }
            if (Optional.IsDefined(ClusterComputeCapacityInfo))
            {
                writer.WritePropertyName("clusterComputeCapacityInfo"u8);
                writer.WriteObjectValue(ClusterComputeCapacityInfo);
            }
            if (Optional.IsCollectionDefined(NodeCapacityInfos))
            {
                writer.WritePropertyName("nodeCapacityInfos"u8);
                writer.WriteStartObject();
                foreach (var item in NodeCapacityInfos)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        DataBoxEdgeDeviceCapacityInfo IJsonModel<DataBoxEdgeDeviceCapacityInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceCapacityInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeDeviceCapacityInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeDeviceCapacityInfo(document.RootElement, options);
        }

        internal static DataBoxEdgeDeviceCapacityInfo DeserializeDataBoxEdgeDeviceCapacityInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            DateTimeOffset? timeStamp = default;
            EdgeClusterStorageViewInfo clusterStorageCapacityInfo = default;
            EdgeClusterCapacityViewInfo clusterComputeCapacityInfo = default;
            IDictionary<string, HostCapacity> nodeCapacityInfos = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("timeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("clusterStorageCapacityInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterStorageCapacityInfo = EdgeClusterStorageViewInfo.DeserializeEdgeClusterStorageViewInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("clusterComputeCapacityInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterComputeCapacityInfo = EdgeClusterCapacityViewInfo.DeserializeEdgeClusterCapacityViewInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("nodeCapacityInfos"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, HostCapacity> dictionary = new Dictionary<string, HostCapacity>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, HostCapacity.DeserializeHostCapacity(property1.Value, options));
                            }
                            nodeCapacityInfos = dictionary;
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
            return new DataBoxEdgeDeviceCapacityInfo(
                id,
                name,
                type,
                systemData,
                timeStamp,
                clusterStorageCapacityInfo,
                clusterComputeCapacityInfo,
                nodeCapacityInfos ?? new ChangeTrackingDictionary<string, HostCapacity>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeDeviceCapacityInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceCapacityInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeDeviceCapacityInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxEdgeDeviceCapacityInfo IPersistableModel<DataBoxEdgeDeviceCapacityInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceCapacityInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxEdgeDeviceCapacityInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeDeviceCapacityInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeDeviceCapacityInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
