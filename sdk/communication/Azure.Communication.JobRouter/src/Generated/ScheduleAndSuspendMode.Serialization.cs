// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Communication.JobRouter
{
    public partial class ScheduleAndSuspendMode : IUtf8JsonWriteable, IJsonModel<ScheduleAndSuspendMode>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduleAndSuspendMode>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScheduleAndSuspendMode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleAndSuspendMode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduleAndSuspendMode)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("scheduleAt"u8);
            writer.WriteStringValue(ScheduleAt, "O");
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        ScheduleAndSuspendMode IJsonModel<ScheduleAndSuspendMode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleAndSuspendMode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduleAndSuspendMode)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduleAndSuspendMode(document.RootElement, options);
        }

        internal static ScheduleAndSuspendMode DeserializeScheduleAndSuspendMode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset scheduleAt = default;
            JobMatchingModeKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleAt"u8))
                {
                    scheduleAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new JobMatchingModeKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScheduleAndSuspendMode(kind, serializedAdditionalRawData, scheduleAt);
        }

        BinaryData IPersistableModel<ScheduleAndSuspendMode>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleAndSuspendMode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScheduleAndSuspendMode)} does not support '{options.Format}' format.");
            }
        }

        ScheduleAndSuspendMode IPersistableModel<ScheduleAndSuspendMode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleAndSuspendMode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScheduleAndSuspendMode(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScheduleAndSuspendMode)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScheduleAndSuspendMode>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static new ScheduleAndSuspendMode FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeScheduleAndSuspendMode(document.RootElement);
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
