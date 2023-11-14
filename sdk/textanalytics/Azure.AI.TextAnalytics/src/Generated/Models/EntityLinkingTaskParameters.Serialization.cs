// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class EntityLinkingTaskParameters : IUtf8JsonSerializable, IJsonModel<EntityLinkingTaskParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EntityLinkingTaskParameters>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<EntityLinkingTaskParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<EntityLinkingTaskParameters>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<EntityLinkingTaskParameters>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StringIndexType))
            {
                writer.WritePropertyName("stringIndexType"u8);
                writer.WriteStringValue(StringIndexType.Value.ToString());
            }
            if (Optional.IsDefined(ModelVersion))
            {
                writer.WritePropertyName("modelVersion"u8);
                writer.WriteStringValue(ModelVersion);
            }
            if (Optional.IsDefined(LoggingOptOut))
            {
                writer.WritePropertyName("loggingOptOut"u8);
                writer.WriteBooleanValue(LoggingOptOut.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        EntityLinkingTaskParameters IJsonModel<EntityLinkingTaskParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EntityLinkingTaskParameters)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEntityLinkingTaskParameters(document.RootElement, options);
        }

        internal static EntityLinkingTaskParameters DeserializeEntityLinkingTaskParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StringIndexType> stringIndexType = default;
            Optional<string> modelVersion = default;
            Optional<bool> loggingOptOut = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stringIndexType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stringIndexType = new StringIndexType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingOptOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loggingOptOut = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EntityLinkingTaskParameters(Optional.ToNullable(loggingOptOut), serializedAdditionalRawData, modelVersion.Value, Optional.ToNullable(stringIndexType));
        }

        BinaryData IPersistableModel<EntityLinkingTaskParameters>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EntityLinkingTaskParameters)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        EntityLinkingTaskParameters IPersistableModel<EntityLinkingTaskParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EntityLinkingTaskParameters)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeEntityLinkingTaskParameters(document.RootElement, options);
        }

        string IPersistableModel<EntityLinkingTaskParameters>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
