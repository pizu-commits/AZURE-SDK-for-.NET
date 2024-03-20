// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class TopicTypeAdditionalEnforcedPermission : IUtf8JsonSerializable, IJsonModel<TopicTypeAdditionalEnforcedPermission>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TopicTypeAdditionalEnforcedPermission>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TopicTypeAdditionalEnforcedPermission>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicTypeAdditionalEnforcedPermission>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TopicTypeAdditionalEnforcedPermission)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PermissionName))
            {
                writer.WritePropertyName("permissionName"u8);
                writer.WriteStringValue(PermissionName);
            }
            if (Optional.IsDefined(IsDataAction))
            {
                writer.WritePropertyName("isDataAction"u8);
                writer.WriteBooleanValue(IsDataAction.Value);
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

        TopicTypeAdditionalEnforcedPermission IJsonModel<TopicTypeAdditionalEnforcedPermission>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicTypeAdditionalEnforcedPermission>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TopicTypeAdditionalEnforcedPermission)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTopicTypeAdditionalEnforcedPermission(document.RootElement, options);
        }

        internal static TopicTypeAdditionalEnforcedPermission DeserializeTopicTypeAdditionalEnforcedPermission(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string permissionName = default;
            bool? isDataAction = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("permissionName"u8))
                {
                    permissionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDataAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDataAction = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TopicTypeAdditionalEnforcedPermission(permissionName, isDataAction, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TopicTypeAdditionalEnforcedPermission>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicTypeAdditionalEnforcedPermission>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TopicTypeAdditionalEnforcedPermission)} does not support '{options.Format}' format.");
            }
        }

        TopicTypeAdditionalEnforcedPermission IPersistableModel<TopicTypeAdditionalEnforcedPermission>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicTypeAdditionalEnforcedPermission>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTopicTypeAdditionalEnforcedPermission(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TopicTypeAdditionalEnforcedPermission)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TopicTypeAdditionalEnforcedPermission>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
