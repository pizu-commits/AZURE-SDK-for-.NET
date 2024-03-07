// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Communication.JobRouter
{
    public partial class RouterJobPositionDetails : IUtf8JsonWriteable, IJsonModel<RouterJobPositionDetails>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<RouterJobPositionDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RouterJobPositionDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterJobPositionDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouterJobPositionDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("jobId"u8);
            writer.WriteStringValue(JobId);
            writer.WritePropertyName("position"u8);
            writer.WriteNumberValue(Position);
            writer.WritePropertyName("queueId"u8);
            writer.WriteStringValue(QueueId);
            writer.WritePropertyName("queueLength"u8);
            writer.WriteNumberValue(QueueLength);
            writer.WritePropertyName("estimatedWaitTimeMinutes"u8);
            WriteEstimatedWaitTime(writer);
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

        RouterJobPositionDetails IJsonModel<RouterJobPositionDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterJobPositionDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouterJobPositionDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRouterJobPositionDetails(document.RootElement, options);
        }

        internal static RouterJobPositionDetails DeserializeRouterJobPositionDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string jobId = default;
            int position = default;
            string queueId = default;
            int queueLength = default;
            TimeSpan estimatedWaitTimeMinutes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("position"u8))
                {
                    position = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueLength"u8))
                {
                    queueLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("estimatedWaitTimeMinutes"u8))
                {
                    ReadEstimatedWaitTime(property, ref estimatedWaitTimeMinutes);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RouterJobPositionDetails(
                jobId,
                position,
                queueId,
                queueLength,
                estimatedWaitTimeMinutes,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RouterJobPositionDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterJobPositionDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RouterJobPositionDetails)} does not support '{options.Format}' format.");
            }
        }

        RouterJobPositionDetails IPersistableModel<RouterJobPositionDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterJobPositionDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRouterJobPositionDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RouterJobPositionDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RouterJobPositionDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static RouterJobPositionDetails FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRouterJobPositionDetails(document.RootElement);
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
