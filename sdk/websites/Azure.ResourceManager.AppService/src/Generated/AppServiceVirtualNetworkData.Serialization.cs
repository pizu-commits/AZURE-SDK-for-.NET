// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServiceVirtualNetworkData : IUtf8JsonSerializable, IJsonModel<AppServiceVirtualNetworkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceVirtualNetworkData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceVirtualNetworkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceVirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceVirtualNetworkData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (VnetResourceId != null)
            {
                writer.WritePropertyName("vnetResourceId"u8);
                writer.WriteStringValue(VnetResourceId);
            }
            if (options.Format != "W" && CertThumbprintString != null)
            {
                writer.WritePropertyName("certThumbprint"u8);
                writer.WriteStringValue(CertThumbprintString);
            }
            if (CertBlob != null)
            {
                writer.WritePropertyName("certBlob"u8);
                writer.WriteStringValue(CertBlob);
            }
            if (options.Format != "W" && !(Routes is ChangeTrackingList<AppServiceVirtualNetworkRoute> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteStartArray();
                foreach (var item in Routes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && IsResyncRequired.HasValue)
            {
                writer.WritePropertyName("resyncRequired"u8);
                writer.WriteBooleanValue(IsResyncRequired.Value);
            }
            if (DnsServers != null)
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStringValue(DnsServers);
            }
            if (IsSwift.HasValue)
            {
                writer.WritePropertyName("isSwift"u8);
                writer.WriteBooleanValue(IsSwift.Value);
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

        AppServiceVirtualNetworkData IJsonModel<AppServiceVirtualNetworkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceVirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceVirtualNetworkData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceVirtualNetworkData(document.RootElement, options);
        }

        internal static AppServiceVirtualNetworkData DeserializeAppServiceVirtualNetworkData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> vnetResourceId = default;
            Optional<string> certThumbprint = default;
            Optional<string> certBlob = default;
            IReadOnlyList<AppServiceVirtualNetworkRoute> routes = default;
            Optional<bool> resyncRequired = default;
            Optional<string> dnsServers = default;
            Optional<bool> isSwift = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("vnetResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vnetResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("certThumbprint"u8))
                        {
                            certThumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("certBlob"u8))
                        {
                            certBlob = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AppServiceVirtualNetworkRoute> array = new List<AppServiceVirtualNetworkRoute>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AppServiceVirtualNetworkRoute.DeserializeAppServiceVirtualNetworkRoute(item, options));
                            }
                            routes = array;
                            continue;
                        }
                        if (property0.NameEquals("resyncRequired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resyncRequired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dnsServers"u8))
                        {
                            dnsServers = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isSwift"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isSwift = property0.Value.GetBoolean();
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
            return new AppServiceVirtualNetworkData(id, name, type, systemData.Value, vnetResourceId.Value, certThumbprint.Value, certBlob.Value, routes ?? new ChangeTrackingList<AppServiceVirtualNetworkRoute>(), Optional.ToNullable(resyncRequired), dnsServers.Value, Optional.ToNullable(isSwift), kind.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceVirtualNetworkData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceVirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceVirtualNetworkData)} does not support '{options.Format}' format.");
            }
        }

        AppServiceVirtualNetworkData IPersistableModel<AppServiceVirtualNetworkData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceVirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceVirtualNetworkData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceVirtualNetworkData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceVirtualNetworkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
