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
using Azure.ResourceManager.Orbital.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Orbital
{
    public partial class OrbitalContactData : IUtf8JsonSerializable, IJsonModel<OrbitalContactData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OrbitalContactData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OrbitalContactData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrbitalContactData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
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
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(ReservationStartOn))
            {
                writer.WritePropertyName("reservationStartTime"u8);
                writer.WriteStringValue(ReservationStartOn.Value, "O");
            }
            if (Optional.IsDefined(ReservationEndOn))
            {
                writer.WritePropertyName("reservationEndTime"u8);
                writer.WriteStringValue(ReservationEndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(RxStartOn))
            {
                writer.WritePropertyName("rxStartTime"u8);
                writer.WriteStringValue(RxStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(RxEndOn))
            {
                writer.WritePropertyName("rxEndTime"u8);
                writer.WriteStringValue(RxEndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(TxStartOn))
            {
                writer.WritePropertyName("txStartTime"u8);
                writer.WriteStringValue(TxStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(TxEndOn))
            {
                writer.WritePropertyName("txEndTime"u8);
                writer.WriteStringValue(TxEndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(MaximumElevationDegrees))
            {
                writer.WritePropertyName("maximumElevationDegrees"u8);
                writer.WriteNumberValue(MaximumElevationDegrees.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StartAzimuthDegrees))
            {
                writer.WritePropertyName("startAzimuthDegrees"u8);
                writer.WriteNumberValue(StartAzimuthDegrees.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EndAzimuthDegrees))
            {
                writer.WritePropertyName("endAzimuthDegrees"u8);
                writer.WriteNumberValue(EndAzimuthDegrees.Value);
            }
            if (Optional.IsDefined(GroundStationName))
            {
                writer.WritePropertyName("groundStationName"u8);
                writer.WriteStringValue(GroundStationName);
            }
            if (options.Format != "W" && Optional.IsDefined(StartElevationDegrees))
            {
                writer.WritePropertyName("startElevationDegrees"u8);
                writer.WriteNumberValue(StartElevationDegrees.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EndElevationDegrees))
            {
                writer.WritePropertyName("endElevationDegrees"u8);
                writer.WriteNumberValue(EndElevationDegrees.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AntennaConfiguration))
            {
                writer.WritePropertyName("antennaConfiguration"u8);
                writer.WriteObjectValue<OrbitalContactAntennaConfiguration>(AntennaConfiguration, options);
            }
            if (Optional.IsDefined(ContactProfile))
            {
                writer.WritePropertyName("contactProfile"u8);
                JsonSerializer.Serialize(writer, ContactProfile);
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

        OrbitalContactData IJsonModel<OrbitalContactData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrbitalContactData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOrbitalContactData(document.RootElement, options);
        }

        internal static OrbitalContactData DeserializeOrbitalContactData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            OrbitalProvisioningState? provisioningState = default;
            OrbitalContactStatus? status = default;
            DateTimeOffset? reservationStartTime = default;
            DateTimeOffset? reservationEndTime = default;
            DateTimeOffset? rxStartTime = default;
            DateTimeOffset? rxEndTime = default;
            DateTimeOffset? txStartTime = default;
            DateTimeOffset? txEndTime = default;
            string errorMessage = default;
            float? maximumElevationDegrees = default;
            float? startAzimuthDegrees = default;
            float? endAzimuthDegrees = default;
            string groundStationName = default;
            float? startElevationDegrees = default;
            float? endElevationDegrees = default;
            OrbitalContactAntennaConfiguration antennaConfiguration = default;
            WritableSubResource contactProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new OrbitalProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new OrbitalContactStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reservationStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reservationStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("reservationEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reservationEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("rxStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rxStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("rxEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rxEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("txStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            txStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("txEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            txEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"u8))
                        {
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maximumElevationDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumElevationDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("startAzimuthDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startAzimuthDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("endAzimuthDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endAzimuthDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("groundStationName"u8))
                        {
                            groundStationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startElevationDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startElevationDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("endElevationDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endElevationDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("antennaConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            antennaConfiguration = OrbitalContactAntennaConfiguration.DeserializeOrbitalContactAntennaConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("contactProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contactProfile = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
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
            return new OrbitalContactData(
                id,
                name,
                type,
                systemData,
                etag,
                provisioningState,
                status,
                reservationStartTime,
                reservationEndTime,
                rxStartTime,
                rxEndTime,
                txStartTime,
                txEndTime,
                errorMessage,
                maximumElevationDegrees,
                startAzimuthDegrees,
                endAzimuthDegrees,
                groundStationName,
                startElevationDegrees,
                endElevationDegrees,
                antennaConfiguration,
                contactProfile,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OrbitalContactData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OrbitalContactData)} does not support writing '{options.Format}' format.");
            }
        }

        OrbitalContactData IPersistableModel<OrbitalContactData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOrbitalContactData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OrbitalContactData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OrbitalContactData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
