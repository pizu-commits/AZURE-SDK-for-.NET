// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppRuntimes : IUtf8JsonSerializable, IJsonModel<WebAppRuntimes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebAppRuntimes>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebAppRuntimes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppRuntimes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppRuntimes)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(LinuxRuntimeSettings))
            {
                writer.WritePropertyName("linuxRuntimeSettings"u8);
                writer.WriteObjectValue(LinuxRuntimeSettings);
            }
            if (options.Format != "W" && Optional.IsDefined(WindowsRuntimeSettings))
            {
                writer.WritePropertyName("windowsRuntimeSettings"u8);
                writer.WriteObjectValue(WindowsRuntimeSettings);
            }
            if (options.Format != "W" && Optional.IsDefined(LinuxContainerSettings))
            {
                writer.WritePropertyName("linuxContainerSettings"u8);
                writer.WriteObjectValue(LinuxContainerSettings);
            }
            if (options.Format != "W" && Optional.IsDefined(WindowsContainerSettings))
            {
                writer.WritePropertyName("windowsContainerSettings"u8);
                writer.WriteObjectValue(WindowsContainerSettings);
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

        WebAppRuntimes IJsonModel<WebAppRuntimes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppRuntimes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppRuntimes)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppRuntimes(document.RootElement, options);
        }

        internal static WebAppRuntimes DeserializeWebAppRuntimes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WebAppRuntimeSettings linuxRuntimeSettings = default;
            WebAppRuntimeSettings windowsRuntimeSettings = default;
            LinuxJavaContainerSettings linuxContainerSettings = default;
            WindowsJavaContainerSettings windowsContainerSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linuxRuntimeSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxRuntimeSettings = WebAppRuntimeSettings.DeserializeWebAppRuntimeSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("windowsRuntimeSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsRuntimeSettings = WebAppRuntimeSettings.DeserializeWebAppRuntimeSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("linuxContainerSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxContainerSettings = LinuxJavaContainerSettings.DeserializeLinuxJavaContainerSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("windowsContainerSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsContainerSettings = WindowsJavaContainerSettings.DeserializeWindowsJavaContainerSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebAppRuntimes(linuxRuntimeSettings, windowsRuntimeSettings, linuxContainerSettings, windowsContainerSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebAppRuntimes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppRuntimes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebAppRuntimes)} does not support '{options.Format}' format.");
            }
        }

        WebAppRuntimes IPersistableModel<WebAppRuntimes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppRuntimes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebAppRuntimes(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebAppRuntimes)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebAppRuntimes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
