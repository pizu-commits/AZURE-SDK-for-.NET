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
    public partial class AdhocBasedBackupTriggerContext : IUtf8JsonSerializable, IJsonModel<AdhocBasedBackupTriggerContext>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdhocBasedBackupTriggerContext>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AdhocBasedBackupTriggerContext>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBasedBackupTriggerContext>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdhocBasedBackupTriggerContext)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("taggingCriteria"u8);
            writer.WriteObjectValue(AdhocBackupRetention, options);
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        AdhocBasedBackupTriggerContext IJsonModel<AdhocBasedBackupTriggerContext>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBasedBackupTriggerContext>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdhocBasedBackupTriggerContext)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdhocBasedBackupTriggerContext(document.RootElement, options);
        }

        internal static AdhocBasedBackupTriggerContext DeserializeAdhocBasedBackupTriggerContext(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AdhocBasedBackupTaggingCriteria taggingCriteria = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("taggingCriteria"u8))
                {
                    taggingCriteria = AdhocBasedBackupTaggingCriteria.DeserializeAdhocBasedBackupTaggingCriteria(property.Value, options);
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AdhocBasedBackupTriggerContext(objectType, serializedAdditionalRawData, taggingCriteria);
        }

        BinaryData IPersistableModel<AdhocBasedBackupTriggerContext>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBasedBackupTriggerContext>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AdhocBasedBackupTriggerContext)} does not support writing '{options.Format}' format.");
            }
        }

        AdhocBasedBackupTriggerContext IPersistableModel<AdhocBasedBackupTriggerContext>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBasedBackupTriggerContext>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAdhocBasedBackupTriggerContext(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AdhocBasedBackupTriggerContext)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdhocBasedBackupTriggerContext>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
