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
    public partial class EdgeKubernetesRole : IUtf8JsonSerializable, IJsonModel<EdgeKubernetesRole>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeKubernetesRole>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EdgeKubernetesRole>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRole>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeKubernetesRole)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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
            if (Optional.IsDefined(HostPlatform))
            {
                writer.WritePropertyName("hostPlatform"u8);
                writer.WriteStringValue(HostPlatform.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(HostPlatformType))
            {
                writer.WritePropertyName("hostPlatformType"u8);
                writer.WriteStringValue(HostPlatformType.Value.ToString());
            }
            if (Optional.IsDefined(KubernetesClusterInfo))
            {
                writer.WritePropertyName("kubernetesClusterInfo"u8);
                writer.WriteObjectValue(KubernetesClusterInfo, options);
            }
            if (Optional.IsDefined(KubernetesRoleResources))
            {
                writer.WritePropertyName("kubernetesRoleResources"u8);
                writer.WriteObjectValue(KubernetesRoleResources, options);
            }
            if (Optional.IsDefined(RoleStatus))
            {
                writer.WritePropertyName("roleStatus"u8);
                writer.WriteStringValue(RoleStatus.Value.ToString());
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

        EdgeKubernetesRole IJsonModel<EdgeKubernetesRole>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRole>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeKubernetesRole)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeKubernetesRole(document.RootElement, options);
        }

        internal static EdgeKubernetesRole DeserializeEdgeKubernetesRole(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxEdgeRoleType kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            DataBoxEdgeOSPlatformType? hostPlatform = default;
            EdgeKubernetesState? provisioningState = default;
            HostPlatformType? hostPlatformType = default;
            EdgeKubernetesClusterInfo kubernetesClusterInfo = default;
            EdgeKubernetesRoleResources kubernetesRoleResources = default;
            DataBoxEdgeRoleStatus? roleStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new DataBoxEdgeRoleType(property.Value.GetString());
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
                        if (property0.NameEquals("hostPlatform"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostPlatform = new DataBoxEdgeOSPlatformType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new EdgeKubernetesState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hostPlatformType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostPlatformType = new HostPlatformType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("kubernetesClusterInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            kubernetesClusterInfo = EdgeKubernetesClusterInfo.DeserializeEdgeKubernetesClusterInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("kubernetesRoleResources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            kubernetesRoleResources = EdgeKubernetesRoleResources.DeserializeEdgeKubernetesRoleResources(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("roleStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleStatus = new DataBoxEdgeRoleStatus(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EdgeKubernetesRole(
                id,
                name,
                type,
                systemData,
                kind,
                serializedAdditionalRawData,
                hostPlatform,
                provisioningState,
                hostPlatformType,
                kubernetesClusterInfo,
                kubernetesRoleResources,
                roleStatus);
        }

        BinaryData IPersistableModel<EdgeKubernetesRole>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRole>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeKubernetesRole)} does not support writing '{options.Format}' format.");
            }
        }

        EdgeKubernetesRole IPersistableModel<EdgeKubernetesRole>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRole>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeKubernetesRole(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeKubernetesRole)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeKubernetesRole>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
