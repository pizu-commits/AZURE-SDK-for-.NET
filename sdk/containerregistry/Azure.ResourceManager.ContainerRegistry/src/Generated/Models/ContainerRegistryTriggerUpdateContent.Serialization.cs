// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryTriggerUpdateContent : IUtf8JsonSerializable, IJsonModel<ContainerRegistryTriggerUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryTriggerUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryTriggerUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTriggerUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryTriggerUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(TimerTriggers is ChangeTrackingList<ContainerRegistryTimerTriggerUpdateContent> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("timerTriggers"u8);
                writer.WriteStartArray();
                foreach (var item in TimerTriggers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(SourceTriggers is ChangeTrackingList<ContainerRegistrySourceTriggerUpdateContent> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("sourceTriggers"u8);
                writer.WriteStartArray();
                foreach (var item in SourceTriggers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BaseImageTrigger))
            {
                writer.WritePropertyName("baseImageTrigger"u8);
                writer.WriteObjectValue(BaseImageTrigger);
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

        ContainerRegistryTriggerUpdateContent IJsonModel<ContainerRegistryTriggerUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTriggerUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryTriggerUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryTriggerUpdateContent(document.RootElement, options);
        }

        internal static ContainerRegistryTriggerUpdateContent DeserializeContainerRegistryTriggerUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ContainerRegistryTimerTriggerUpdateContent>> timerTriggers = default;
            Optional<IList<ContainerRegistrySourceTriggerUpdateContent>> sourceTriggers = default;
            Optional<ContainerRegistryBaseImageTriggerUpdateContent> baseImageTrigger = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timerTriggers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryTimerTriggerUpdateContent> array = new List<ContainerRegistryTimerTriggerUpdateContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTimerTriggerUpdateContent.DeserializeContainerRegistryTimerTriggerUpdateContent(item, options));
                    }
                    timerTriggers = array;
                    continue;
                }
                if (property.NameEquals("sourceTriggers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistrySourceTriggerUpdateContent> array = new List<ContainerRegistrySourceTriggerUpdateContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistrySourceTriggerUpdateContent.DeserializeContainerRegistrySourceTriggerUpdateContent(item, options));
                    }
                    sourceTriggers = array;
                    continue;
                }
                if (property.NameEquals("baseImageTrigger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    baseImageTrigger = ContainerRegistryBaseImageTriggerUpdateContent.DeserializeContainerRegistryBaseImageTriggerUpdateContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryTriggerUpdateContent(Optional.ToList(timerTriggers), Optional.ToList(sourceTriggers), baseImageTrigger.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistryTriggerUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTriggerUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryTriggerUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryTriggerUpdateContent IPersistableModel<ContainerRegistryTriggerUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTriggerUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryTriggerUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryTriggerUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryTriggerUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
