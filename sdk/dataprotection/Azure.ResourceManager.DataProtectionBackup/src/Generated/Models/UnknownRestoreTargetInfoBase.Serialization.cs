// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    internal partial class UnknownRestoreTargetInfoBase : IUtf8JsonSerializable, IJsonModel<RestoreTargetInfoBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestoreTargetInfoBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestoreTargetInfoBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreTargetInfoBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreTargetInfoBase)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("recoveryOption"u8);
            writer.WriteStringValue(RecoverySetting.ToString());
            if (Optional.IsDefined(RestoreLocation))
            {
                writer.WritePropertyName("restoreLocation"u8);
                writer.WriteStringValue(RestoreLocation.Value);
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

        RestoreTargetInfoBase IJsonModel<RestoreTargetInfoBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreTargetInfoBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreTargetInfoBase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestoreTargetInfoBase(document.RootElement, options);
        }

        internal static UnknownRestoreTargetInfoBase DeserializeUnknownRestoreTargetInfoBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string objectType = "Unknown";
            RecoverySetting recoveryOption = default;
            AzureLocation? restoreLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryOption"u8))
                {
                    recoveryOption = new RecoverySetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("restoreLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownRestoreTargetInfoBase(objectType, recoveryOption, restoreLocation, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RestoreTargetInfoBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreTargetInfoBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RestoreTargetInfoBase)} does not support writing '{options.Format}' format.");
            }
        }

        RestoreTargetInfoBase IPersistableModel<RestoreTargetInfoBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreTargetInfoBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestoreTargetInfoBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestoreTargetInfoBase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestoreTargetInfoBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
