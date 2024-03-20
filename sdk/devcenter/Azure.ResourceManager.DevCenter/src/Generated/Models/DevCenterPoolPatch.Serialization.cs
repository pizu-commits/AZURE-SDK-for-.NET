// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    public partial class DevCenterPoolPatch : IUtf8JsonSerializable, IJsonModel<DevCenterPoolPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevCenterPoolPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevCenterPoolPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterPoolPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterPoolPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DevBoxDefinitionName))
            {
                writer.WritePropertyName("devBoxDefinitionName"u8);
                writer.WriteStringValue(DevBoxDefinitionName);
            }
            if (Optional.IsDefined(NetworkConnectionName))
            {
                writer.WritePropertyName("networkConnectionName"u8);
                writer.WriteStringValue(NetworkConnectionName);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(LocalAdministrator))
            {
                writer.WritePropertyName("localAdministrator"u8);
                writer.WriteStringValue(LocalAdministrator.Value.ToString());
            }
            if (Optional.IsDefined(StopOnDisconnect))
            {
                writer.WritePropertyName("stopOnDisconnect"u8);
                writer.WriteObjectValue(StopOnDisconnect);
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

        DevCenterPoolPatch IJsonModel<DevCenterPoolPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterPoolPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterPoolPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevCenterPoolPatch(document.RootElement, options);
        }

        internal static DevCenterPoolPatch DeserializeDevCenterPoolPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation? location = default;
            string devBoxDefinitionName = default;
            string networkConnectionName = default;
            DevCenterLicenseType? licenseType = default;
            LocalAdminStatus? localAdministrator = default;
            StopOnDisconnectConfiguration stopOnDisconnect = default;
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("devBoxDefinitionName"u8))
                        {
                            devBoxDefinitionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkConnectionName"u8))
                        {
                            networkConnectionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("licenseType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseType = new DevCenterLicenseType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("localAdministrator"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            localAdministrator = new LocalAdminStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("stopOnDisconnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stopOnDisconnect = StopOnDisconnectConfiguration.DeserializeStopOnDisconnectConfiguration(property0.Value, options);
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
            return new DevCenterPoolPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                serializedAdditionalRawData,
                devBoxDefinitionName,
                networkConnectionName,
                licenseType,
                localAdministrator,
                stopOnDisconnect);
        }

        BinaryData IPersistableModel<DevCenterPoolPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterPoolPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevCenterPoolPatch)} does not support '{options.Format}' format.");
            }
        }

        DevCenterPoolPatch IPersistableModel<DevCenterPoolPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterPoolPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevCenterPoolPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevCenterPoolPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevCenterPoolPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
