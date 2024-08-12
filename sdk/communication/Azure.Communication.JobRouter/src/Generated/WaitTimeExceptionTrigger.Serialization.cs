// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class WaitTimeExceptionTrigger : IUtf8JsonSerializable, IJsonModel<WaitTimeExceptionTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WaitTimeExceptionTrigger>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WaitTimeExceptionTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WaitTimeExceptionTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WaitTimeExceptionTrigger)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("thresholdSeconds"u8);
            WriteThresholdSeconds(writer, options);
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

        WaitTimeExceptionTrigger IJsonModel<WaitTimeExceptionTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WaitTimeExceptionTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WaitTimeExceptionTrigger)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWaitTimeExceptionTrigger(document.RootElement, options);
        }

        internal static WaitTimeExceptionTrigger DeserializeWaitTimeExceptionTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan thresholdSeconds = default;
            ExceptionTriggerKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("thresholdSeconds"u8))
                {
                    ReadThresholdSeconds(property, ref thresholdSeconds);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ExceptionTriggerKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WaitTimeExceptionTrigger(kind, serializedAdditionalRawData, thresholdSeconds);
        }

        BinaryData IPersistableModel<WaitTimeExceptionTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WaitTimeExceptionTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WaitTimeExceptionTrigger)} does not support writing '{options.Format}' format.");
            }
        }

        WaitTimeExceptionTrigger IPersistableModel<WaitTimeExceptionTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WaitTimeExceptionTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWaitTimeExceptionTrigger(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WaitTimeExceptionTrigger)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WaitTimeExceptionTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new WaitTimeExceptionTrigger FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWaitTimeExceptionTrigger(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
