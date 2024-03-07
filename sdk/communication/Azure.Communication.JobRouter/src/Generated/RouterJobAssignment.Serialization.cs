// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Communication.JobRouter
{
    public partial class RouterJobAssignment : IUtf8JsonWriteable, IJsonModel<RouterJobAssignment>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<RouterJobAssignment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RouterJobAssignment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterJobAssignment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouterJobAssignment)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("assignmentId"u8);
                writer.WriteStringValue(AssignmentId);
            }
            if (Optional.IsDefined(WorkerId))
            {
                writer.WritePropertyName("workerId"u8);
                writer.WriteStringValue(WorkerId);
            }
            writer.WritePropertyName("assignedAt"u8);
            writer.WriteStringValue(AssignedAt, "O");
            if (Optional.IsDefined(CompletedAt))
            {
                writer.WritePropertyName("completedAt"u8);
                writer.WriteStringValue(CompletedAt.Value, "O");
            }
            if (Optional.IsDefined(ClosedAt))
            {
                writer.WritePropertyName("closedAt"u8);
                writer.WriteStringValue(ClosedAt.Value, "O");
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

        RouterJobAssignment IJsonModel<RouterJobAssignment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterJobAssignment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouterJobAssignment)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRouterJobAssignment(document.RootElement, options);
        }

        internal static RouterJobAssignment DeserializeRouterJobAssignment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assignmentId = default;
            string workerId = default;
            DateTimeOffset assignedAt = default;
            DateTimeOffset? completedAt = default;
            DateTimeOffset? closedAt = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assignmentId"u8))
                {
                    assignmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workerId"u8))
                {
                    workerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignedAt"u8))
                {
                    assignedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("completedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    completedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("closedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    closedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RouterJobAssignment(
                assignmentId,
                workerId,
                assignedAt,
                completedAt,
                closedAt,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RouterJobAssignment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterJobAssignment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RouterJobAssignment)} does not support '{options.Format}' format.");
            }
        }

        RouterJobAssignment IPersistableModel<RouterJobAssignment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterJobAssignment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRouterJobAssignment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RouterJobAssignment)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RouterJobAssignment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static RouterJobAssignment FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRouterJobAssignment(document.RootElement);
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
