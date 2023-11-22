// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnDeviceScriptContent : IUtf8JsonSerializable, IJsonModel<VpnDeviceScriptContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnDeviceScriptContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnDeviceScriptContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnDeviceScriptContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VpnDeviceScriptContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Vendor))
            {
                writer.WritePropertyName("vendor"u8);
                writer.WriteStringValue(Vendor);
            }
            if (Optional.IsDefined(DeviceFamily))
            {
                writer.WritePropertyName("deviceFamily"u8);
                writer.WriteStringValue(DeviceFamily);
            }
            if (Optional.IsDefined(FirmwareVersion))
            {
                writer.WritePropertyName("firmwareVersion"u8);
                writer.WriteStringValue(FirmwareVersion);
            }
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

        VpnDeviceScriptContent IJsonModel<VpnDeviceScriptContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnDeviceScriptContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VpnDeviceScriptContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnDeviceScriptContent(document.RootElement, options);
        }

        internal static VpnDeviceScriptContent DeserializeVpnDeviceScriptContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vendor = default;
            Optional<string> deviceFamily = default;
            Optional<string> firmwareVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vendor"u8))
                {
                    vendor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceFamily"u8))
                {
                    deviceFamily = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firmwareVersion"u8))
                {
                    firmwareVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnDeviceScriptContent(vendor.Value, deviceFamily.Value, firmwareVersion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnDeviceScriptContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnDeviceScriptContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(VpnDeviceScriptContent)} does not support '{options.Format}' format.");
            }
        }

        VpnDeviceScriptContent IPersistableModel<VpnDeviceScriptContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnDeviceScriptContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnDeviceScriptContent(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(VpnDeviceScriptContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnDeviceScriptContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
