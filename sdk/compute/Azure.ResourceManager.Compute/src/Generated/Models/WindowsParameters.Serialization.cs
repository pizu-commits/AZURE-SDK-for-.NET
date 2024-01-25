// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class WindowsParameters : IUtf8JsonSerializable, IJsonModel<WindowsParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WindowsParameters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WindowsParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsParameters)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ClassificationsToInclude))
            {
                writer.WritePropertyName("classificationsToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in ClassificationsToInclude)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(KbNumbersToInclude))
            {
                writer.WritePropertyName("kbNumbersToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in KbNumbersToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(KbNumbersToExclude))
            {
                writer.WritePropertyName("kbNumbersToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in KbNumbersToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExcludeKbsRequiringReboot))
            {
                writer.WritePropertyName("excludeKbsRequiringReboot"u8);
                writer.WriteBooleanValue(ExcludeKbsRequiringReboot.Value);
            }
            if (Optional.IsDefined(MaxPatchPublishOn))
            {
                writer.WritePropertyName("maxPatchPublishDate"u8);
                writer.WriteStringValue(MaxPatchPublishOn.Value, "O");
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

        WindowsParameters IJsonModel<WindowsParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsParameters)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWindowsParameters(document.RootElement, options);
        }

        internal static WindowsParameters DeserializeWindowsParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<VmGuestPatchClassificationForWindows>> classificationsToInclude = default;
            Optional<IList<string>> kbNumbersToInclude = default;
            Optional<IList<string>> kbNumbersToExclude = default;
            Optional<bool> excludeKbsRequiringReboot = default;
            Optional<DateTimeOffset> maxPatchPublishDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("classificationsToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VmGuestPatchClassificationForWindows> array = new List<VmGuestPatchClassificationForWindows>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new VmGuestPatchClassificationForWindows(item.GetString()));
                    }
                    classificationsToInclude = array;
                    continue;
                }
                if (property.NameEquals("kbNumbersToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    kbNumbersToInclude = array;
                    continue;
                }
                if (property.NameEquals("kbNumbersToExclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    kbNumbersToExclude = array;
                    continue;
                }
                if (property.NameEquals("excludeKbsRequiringReboot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludeKbsRequiringReboot = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxPatchPublishDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPatchPublishDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WindowsParameters(Optional.ToList(classificationsToInclude), Optional.ToList(kbNumbersToInclude), Optional.ToList(kbNumbersToExclude), Optional.ToNullable(excludeKbsRequiringReboot), Optional.ToNullable(maxPatchPublishDate), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WindowsParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WindowsParameters)} does not support '{options.Format}' format.");
            }
        }

        WindowsParameters IPersistableModel<WindowsParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWindowsParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WindowsParameters)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WindowsParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
