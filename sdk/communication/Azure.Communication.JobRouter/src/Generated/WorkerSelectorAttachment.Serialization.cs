// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    [PersistableModelProxy(typeof(UnknownWorkerSelectorAttachment))]
    public partial class WorkerSelectorAttachment : IUtf8JsonSerializable, IJsonModel<WorkerSelectorAttachment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkerSelectorAttachment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkerSelectorAttachment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkerSelectorAttachment)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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

        WorkerSelectorAttachment IJsonModel<WorkerSelectorAttachment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkerSelectorAttachment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkerSelectorAttachment(document.RootElement, options);
        }

        internal static WorkerSelectorAttachment DeserializeWorkerSelectorAttachment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "conditional": return ConditionalWorkerSelectorAttachment.DeserializeConditionalWorkerSelectorAttachment(element, options);
                    case "passThrough": return PassThroughWorkerSelectorAttachment.DeserializePassThroughWorkerSelectorAttachment(element, options);
                    case "ruleEngine": return RuleEngineWorkerSelectorAttachment.DeserializeRuleEngineWorkerSelectorAttachment(element, options);
                    case "static": return StaticWorkerSelectorAttachment.DeserializeStaticWorkerSelectorAttachment(element, options);
                    case "weightedAllocation": return WeightedAllocationWorkerSelectorAttachment.DeserializeWeightedAllocationWorkerSelectorAttachment(element, options);
                }
            }
            return UnknownWorkerSelectorAttachment.DeserializeUnknownWorkerSelectorAttachment(element, options);
        }

        BinaryData IPersistableModel<WorkerSelectorAttachment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkerSelectorAttachment)} does not support writing '{options.Format}' format.");
            }
        }

        WorkerSelectorAttachment IPersistableModel<WorkerSelectorAttachment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkerSelectorAttachment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkerSelectorAttachment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkerSelectorAttachment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static WorkerSelectorAttachment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWorkerSelectorAttachment(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
