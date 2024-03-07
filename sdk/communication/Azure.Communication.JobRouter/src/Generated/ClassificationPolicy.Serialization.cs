// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Azure.Communication.JobRouter
{
    public partial class ClassificationPolicy : IUtf8JsonWriteable, IJsonModel<ClassificationPolicy>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClassificationPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClassificationPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClassificationPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.ToString());
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(FallbackQueueId))
            {
                writer.WritePropertyName("fallbackQueueId"u8);
                writer.WriteStringValue(FallbackQueueId);
            }
            if (Optional.IsCollectionDefined(QueueSelectorAttachments))
            {
                writer.WritePropertyName("queueSelectorAttachments"u8);
                writer.WriteStartArray();
                foreach (var item in QueueSelectorAttachments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PrioritizationRule))
            {
                writer.WritePropertyName("prioritizationRule"u8);
                writer.WriteObjectValue(PrioritizationRule);
            }
            if (Optional.IsCollectionDefined(WorkerSelectorAttachments))
            {
                writer.WritePropertyName("workerSelectorAttachments"u8);
                writer.WriteStartArray();
                foreach (var item in WorkerSelectorAttachments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ClassificationPolicy IJsonModel<ClassificationPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClassificationPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClassificationPolicy(document.RootElement, options);
        }

        internal static ClassificationPolicy DeserializeClassificationPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag etag = default;
            string id = default;
            string name = default;
            string fallbackQueueId = default;
            IList<QueueSelectorAttachment> queueSelectorAttachments = default;
            RouterRule prioritizationRule = default;
            IList<WorkerSelectorAttachment> workerSelectorAttachments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fallbackQueueId"u8))
                {
                    fallbackQueueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueSelectorAttachments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QueueSelectorAttachment> array = new List<QueueSelectorAttachment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueueSelectorAttachment.DeserializeQueueSelectorAttachment(item, options));
                    }
                    queueSelectorAttachments = array;
                    continue;
                }
                if (property.NameEquals("prioritizationRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prioritizationRule = RouterRule.DeserializeRouterRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("workerSelectorAttachments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WorkerSelectorAttachment> array = new List<WorkerSelectorAttachment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkerSelectorAttachment.DeserializeWorkerSelectorAttachment(item, options));
                    }
                    workerSelectorAttachments = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClassificationPolicy(
                etag,
                id,
                name,
                fallbackQueueId,
                queueSelectorAttachments ?? new ChangeTrackingList<QueueSelectorAttachment>(),
                prioritizationRule,
                workerSelectorAttachments ?? new ChangeTrackingList<WorkerSelectorAttachment>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClassificationPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClassificationPolicy)} does not support '{options.Format}' format.");
            }
        }

        ClassificationPolicy IPersistableModel<ClassificationPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClassificationPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClassificationPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClassificationPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ClassificationPolicy FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeClassificationPolicy(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual RequestBody ToRequestBody()
        {
            var content = new Utf8JsonRequestBody();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
