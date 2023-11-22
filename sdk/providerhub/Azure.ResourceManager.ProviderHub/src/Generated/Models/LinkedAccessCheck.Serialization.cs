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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class LinkedAccessCheck : IUtf8JsonSerializable, IJsonModel<LinkedAccessCheck>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkedAccessCheck>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LinkedAccessCheck>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedAccessCheck>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(LinkedAccessCheck)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ActionName))
            {
                writer.WritePropertyName("actionName"u8);
                writer.WriteStringValue(ActionName);
            }
            if (Optional.IsDefined(LinkedProperty))
            {
                writer.WritePropertyName("linkedProperty"u8);
                writer.WriteStringValue(LinkedProperty);
            }
            if (Optional.IsDefined(LinkedAction))
            {
                writer.WritePropertyName("linkedAction"u8);
                writer.WriteStringValue(LinkedAction);
            }
            if (Optional.IsDefined(LinkedActionVerb))
            {
                writer.WritePropertyName("linkedActionVerb"u8);
                writer.WriteStringValue(LinkedActionVerb);
            }
            if (Optional.IsDefined(LinkedType))
            {
                writer.WritePropertyName("linkedType"u8);
                writer.WriteStringValue(LinkedType);
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

        LinkedAccessCheck IJsonModel<LinkedAccessCheck>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedAccessCheck>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(LinkedAccessCheck)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkedAccessCheck(document.RootElement, options);
        }

        internal static LinkedAccessCheck DeserializeLinkedAccessCheck(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> actionName = default;
            Optional<string> linkedProperty = default;
            Optional<string> linkedAction = default;
            Optional<string> linkedActionVerb = default;
            Optional<string> linkedType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionName"u8))
                {
                    actionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedProperty"u8))
                {
                    linkedProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedAction"u8))
                {
                    linkedAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedActionVerb"u8))
                {
                    linkedActionVerb = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedType"u8))
                {
                    linkedType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinkedAccessCheck(actionName.Value, linkedProperty.Value, linkedAction.Value, linkedActionVerb.Value, linkedType.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LinkedAccessCheck>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedAccessCheck>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(LinkedAccessCheck)} does not support '{options.Format}' format.");
            }
        }

        LinkedAccessCheck IPersistableModel<LinkedAccessCheck>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedAccessCheck>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLinkedAccessCheck(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(LinkedAccessCheck)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LinkedAccessCheck>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
