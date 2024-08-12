// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EdgeZones.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EdgeZones
{
    public partial class ExtendedZoneData : IUtf8JsonSerializable, IJsonModel<ExtendedZoneData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtendedZoneData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExtendedZoneData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedZoneData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedZoneData)} does not support writing '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(RegistrationState))
            {
                writer.WritePropertyName("registrationState"u8);
                writer.WriteStringValue(RegistrationState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(RegionalDisplayName))
            {
                writer.WritePropertyName("regionalDisplayName"u8);
                writer.WriteStringValue(RegionalDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(RegionType))
            {
                writer.WritePropertyName("regionType"u8);
                writer.WriteStringValue(RegionType);
            }
            if (options.Format != "W" && Optional.IsDefined(RegionCategory))
            {
                writer.WritePropertyName("regionCategory"u8);
                writer.WriteStringValue(RegionCategory);
            }
            if (options.Format != "W" && Optional.IsDefined(Geography))
            {
                writer.WritePropertyName("geography"u8);
                writer.WriteStringValue(Geography);
            }
            if (options.Format != "W" && Optional.IsDefined(GeographyGroup))
            {
                writer.WritePropertyName("geographyGroup"u8);
                writer.WriteStringValue(GeographyGroup);
            }
            if (options.Format != "W" && Optional.IsDefined(Longitude))
            {
                writer.WritePropertyName("longitude"u8);
                writer.WriteStringValue(Longitude);
            }
            if (options.Format != "W" && Optional.IsDefined(Latitude))
            {
                writer.WritePropertyName("latitude"u8);
                writer.WriteStringValue(Latitude);
            }
            if (options.Format != "W" && Optional.IsDefined(HomeLocation))
            {
                writer.WritePropertyName("homeLocation"u8);
                writer.WriteStringValue(HomeLocation);
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

        ExtendedZoneData IJsonModel<ExtendedZoneData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedZoneData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedZoneData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedZoneData(document.RootElement, options);
        }

        internal static ExtendedZoneData DeserializeExtendedZoneData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            EdgeZonesProvisioningState? provisioningState = default;
            EdgeZonesRegistrationState? registrationState = default;
            string displayName = default;
            string regionalDisplayName = default;
            string regionType = default;
            string regionCategory = default;
            string geography = default;
            string geographyGroup = default;
            string longitude = default;
            string latitude = default;
            string homeLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new EdgeZonesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("registrationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            registrationState = new EdgeZonesRegistrationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("regionalDisplayName"u8))
                        {
                            regionalDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("regionType"u8))
                        {
                            regionType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("regionCategory"u8))
                        {
                            regionCategory = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("geography"u8))
                        {
                            geography = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("geographyGroup"u8))
                        {
                            geographyGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("longitude"u8))
                        {
                            longitude = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("latitude"u8))
                        {
                            latitude = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("homeLocation"u8))
                        {
                            homeLocation = property0.Value.GetString();
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
            return new ExtendedZoneData(
                id,
                name,
                type,
                systemData,
                provisioningState,
                registrationState,
                displayName,
                regionalDisplayName,
                regionType,
                regionCategory,
                geography,
                geographyGroup,
                longitude,
                latitude,
                homeLocation,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExtendedZoneData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedZoneData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExtendedZoneData)} does not support writing '{options.Format}' format.");
            }
        }

        ExtendedZoneData IPersistableModel<ExtendedZoneData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedZoneData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtendedZoneData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtendedZoneData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtendedZoneData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
