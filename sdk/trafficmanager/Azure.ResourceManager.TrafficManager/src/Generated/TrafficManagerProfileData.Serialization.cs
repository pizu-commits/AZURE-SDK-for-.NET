// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    public partial class TrafficManagerProfileData : IUtf8JsonSerializable, IJsonModel<TrafficManagerProfileData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrafficManagerProfileData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrafficManagerProfileData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerProfileData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficManagerProfileData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
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
            if (Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (ProfileStatus.HasValue)
            {
                writer.WritePropertyName("profileStatus"u8);
                writer.WriteStringValue(ProfileStatus.Value.ToString());
            }
            if (TrafficRoutingMethod.HasValue)
            {
                writer.WritePropertyName("trafficRoutingMethod"u8);
                writer.WriteStringValue(TrafficRoutingMethod.Value.ToString());
            }
            if (DnsConfig != null)
            {
                writer.WritePropertyName("dnsConfig"u8);
                writer.WriteObjectValue(DnsConfig);
            }
            if (MonitorConfig != null)
            {
                writer.WritePropertyName("monitorConfig"u8);
                writer.WriteObjectValue(MonitorConfig);
            }
            if (!(Endpoints is ChangeTrackingList<TrafficManagerEndpointData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (TrafficViewEnrollmentStatus.HasValue)
            {
                writer.WritePropertyName("trafficViewEnrollmentStatus"u8);
                writer.WriteStringValue(TrafficViewEnrollmentStatus.Value.ToString());
            }
            if (!(AllowedEndpointRecordTypes is ChangeTrackingList<AllowedEndpointRecordType> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("allowedEndpointRecordTypes"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedEndpointRecordTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (MaxReturn.HasValue)
            {
                if (MaxReturn != null)
                {
                    writer.WritePropertyName("maxReturn"u8);
                    writer.WriteNumberValue(MaxReturn.Value);
                }
                else
                {
                    writer.WriteNull("maxReturn");
                }
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

        TrafficManagerProfileData IJsonModel<TrafficManagerProfileData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerProfileData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficManagerProfileData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficManagerProfileData(document.RootElement, options);
        }

        internal static TrafficManagerProfileData DeserializeTrafficManagerProfileData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<AzureLocation> location = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<TrafficManagerProfileStatus> profileStatus = default;
            Optional<TrafficRoutingMethod> trafficRoutingMethod = default;
            Optional<TrafficManagerDnsConfig> dnsConfig = default;
            Optional<TrafficManagerMonitorConfig> monitorConfig = default;
            IList<TrafficManagerEndpointData> endpoints = default;
            Optional<TrafficViewEnrollmentStatus> trafficViewEnrollmentStatus = default;
            IList<AllowedEndpointRecordType> allowedEndpointRecordTypes = default;
            Optional<long?> maxReturn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("profileStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            profileStatus = new TrafficManagerProfileStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("trafficRoutingMethod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trafficRoutingMethod = new TrafficRoutingMethod(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dnsConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsConfig = TrafficManagerDnsConfig.DeserializeTrafficManagerDnsConfig(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("monitorConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            monitorConfig = TrafficManagerMonitorConfig.DeserializeTrafficManagerMonitorConfig(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("endpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TrafficManagerEndpointData> array = new List<TrafficManagerEndpointData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrafficManagerEndpointData.DeserializeTrafficManagerEndpointData(item, options));
                            }
                            endpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("trafficViewEnrollmentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trafficViewEnrollmentStatus = new TrafficViewEnrollmentStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowedEndpointRecordTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AllowedEndpointRecordType> array = new List<AllowedEndpointRecordType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new AllowedEndpointRecordType(item.GetString()));
                            }
                            allowedEndpointRecordTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("maxReturn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                maxReturn = null;
                                continue;
                            }
                            maxReturn = property0.Value.GetInt64();
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
            return new TrafficManagerProfileData(id.Value, name.Value, Optional.ToNullable(type), serializedAdditionalRawData, Optional.ToDictionary(tags), Optional.ToNullable(location), Optional.ToNullable(profileStatus), Optional.ToNullable(trafficRoutingMethod), dnsConfig.Value, monitorConfig.Value, endpoints ?? new ChangeTrackingList<TrafficManagerEndpointData>(), Optional.ToNullable(trafficViewEnrollmentStatus), allowedEndpointRecordTypes ?? new ChangeTrackingList<AllowedEndpointRecordType>(), Optional.ToNullable(maxReturn));
        }

        BinaryData IPersistableModel<TrafficManagerProfileData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerProfileData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrafficManagerProfileData)} does not support '{options.Format}' format.");
            }
        }

        TrafficManagerProfileData IPersistableModel<TrafficManagerProfileData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerProfileData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrafficManagerProfileData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrafficManagerProfileData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrafficManagerProfileData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
