// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabCustomImageVm : IUtf8JsonSerializable, IJsonModel<DevTestLabCustomImageVm>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabCustomImageVm>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabCustomImageVm>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageVm>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabCustomImageVm)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceVmId))
            {
                writer.WritePropertyName("sourceVmId"u8);
                writer.WriteStringValue(SourceVmId);
            }
            if (Optional.IsDefined(WindowsOSInfo))
            {
                writer.WritePropertyName("windowsOsInfo"u8);
                writer.WriteObjectValue(WindowsOSInfo);
            }
            if (Optional.IsDefined(LinuxOSInfo))
            {
                writer.WritePropertyName("linuxOsInfo"u8);
                writer.WriteObjectValue(LinuxOSInfo);
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

        DevTestLabCustomImageVm IJsonModel<DevTestLabCustomImageVm>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageVm>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabCustomImageVm)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabCustomImageVm(document.RootElement, options);
        }

        internal static DevTestLabCustomImageVm DeserializeDevTestLabCustomImageVm(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceVmId = default;
            WindowsOSInfo windowsOSInfo = default;
            LinuxOSInfo linuxOSInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVmId"u8))
                {
                    sourceVmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowsOsInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsOSInfo = WindowsOSInfo.DeserializeWindowsOSInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("linuxOsInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxOSInfo = LinuxOSInfo.DeserializeLinuxOSInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabCustomImageVm(sourceVmId, windowsOSInfo, linuxOSInfo, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabCustomImageVm>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageVm>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabCustomImageVm)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabCustomImageVm IPersistableModel<DevTestLabCustomImageVm>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageVm>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabCustomImageVm(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabCustomImageVm)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabCustomImageVm>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
