// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryScheduleTrigger : IUtf8JsonSerializable, IJsonModel<DataFactoryScheduleTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryScheduleTrigger>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryScheduleTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryScheduleTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryScheduleTrigger)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Pipelines is ChangeTrackingList<TriggerPipelineReference> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("pipelines"u8);
                writer.WriteStartArray();
                foreach (var item in Pipelines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(TriggerType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(RuntimeState))
            {
                writer.WritePropertyName("runtimeState"u8);
                writer.WriteStringValue(RuntimeState.Value.ToString());
            }
            if (!(Annotations is ChangeTrackingList<BinaryData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("recurrence"u8);
            writer.WriteObjectValue(Recurrence);
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        DataFactoryScheduleTrigger IJsonModel<DataFactoryScheduleTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryScheduleTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryScheduleTrigger)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryScheduleTrigger(document.RootElement, options);
        }

        internal static DataFactoryScheduleTrigger DeserializeDataFactoryScheduleTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<TriggerPipelineReference>> pipelines = default;
            string type = default;
            Optional<string> description = default;
            Optional<DataFactoryTriggerRuntimeState> runtimeState = default;
            Optional<IList<BinaryData>> annotations = default;
            ScheduleTriggerRecurrence recurrence = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TriggerPipelineReference> array = new List<TriggerPipelineReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TriggerPipelineReference.DeserializeTriggerPipelineReference(item, options));
                    }
                    pipelines = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runtimeState = new DataFactoryTriggerRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("recurrence"u8))
                        {
                            recurrence = ScheduleTriggerRecurrence.DeserializeScheduleTriggerRecurrence(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryScheduleTrigger(type, description.Value, Optional.ToNullable(runtimeState), Optional.ToList(annotations), additionalProperties, Optional.ToList(pipelines), recurrence);
        }

        BinaryData IPersistableModel<DataFactoryScheduleTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryScheduleTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryScheduleTrigger)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryScheduleTrigger IPersistableModel<DataFactoryScheduleTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryScheduleTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryScheduleTrigger(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryScheduleTrigger)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryScheduleTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
