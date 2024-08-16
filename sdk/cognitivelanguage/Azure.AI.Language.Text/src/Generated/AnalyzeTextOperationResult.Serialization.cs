// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text
{
    [PersistableModelProxy(typeof(UnknownAnalyzeTextOperationResult))]
    public partial class AnalyzeTextOperationResult : IUtf8JsonSerializable, IJsonModel<AnalyzeTextOperationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalyzeTextOperationResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AnalyzeTextOperationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeTextOperationResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("lastUpdateDateTime"u8);
            writer.WriteStringValue(LastUpdateDateTime, "O");
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(Name);
            }
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

        AnalyzeTextOperationResult IJsonModel<AnalyzeTextOperationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeTextOperationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeTextOperationResult(document.RootElement, options);
        }

        internal static AnalyzeTextOperationResult DeserializeAnalyzeTextOperationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AbstractiveSummarizationLROResults": return AbstractiveSummarizationOperationResult.DeserializeAbstractiveSummarizationOperationResult(element, options);
                    case "CustomAbstractiveSummarizationLROResults": return CustomAbstractiveSummarizationOperationResult.DeserializeCustomAbstractiveSummarizationOperationResult(element, options);
                    case "CustomEntityRecognitionLROResults": return CustomEntityRecognitionOperationResult.DeserializeCustomEntityRecognitionOperationResult(element, options);
                    case "CustomHealthcareLROResults": return CustomHealthcareOperationResult.DeserializeCustomHealthcareOperationResult(element, options);
                    case "CustomMultiLabelClassificationLROResults": return CustomMultiLabelClassificationOperationResult.DeserializeCustomMultiLabelClassificationOperationResult(element, options);
                    case "CustomSentimentAnalysisLROResults": return CustomSentimentAnalysisOperationResult.DeserializeCustomSentimentAnalysisOperationResult(element, options);
                    case "CustomSingleLabelClassificationLROResults": return CustomSingleLabelClassificationOperationResult.DeserializeCustomSingleLabelClassificationOperationResult(element, options);
                    case "EntityLinkingLROResults": return EntityLinkingOperationResult.DeserializeEntityLinkingOperationResult(element, options);
                    case "EntityRecognitionLROResults": return EntityRecognitionOperationResult.DeserializeEntityRecognitionOperationResult(element, options);
                    case "ExtractiveSummarizationLROResults": return ExtractiveSummarizationOperationResult.DeserializeExtractiveSummarizationOperationResult(element, options);
                    case "HealthcareLROResults": return HealthcareOperationResult.DeserializeHealthcareOperationResult(element, options);
                    case "KeyPhraseExtractionLROResults": return KeyPhraseExtractionOperationResult.DeserializeKeyPhraseExtractionOperationResult(element, options);
                    case "PiiEntityRecognitionLROResults": return PiiEntityRecognitionOperationResult.DeserializePiiEntityRecognitionOperationResult(element, options);
                    case "SentimentAnalysisLROResults": return SentimentOperationResult.DeserializeSentimentOperationResult(element, options);
                }
            }
            return UnknownAnalyzeTextOperationResult.DeserializeUnknownAnalyzeTextOperationResult(element, options);
        }

        BinaryData IPersistableModel<AnalyzeTextOperationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalyzeTextOperationResult)} does not support writing '{options.Format}' format.");
            }
        }

        AnalyzeTextOperationResult IPersistableModel<AnalyzeTextOperationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnalyzeTextOperationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalyzeTextOperationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalyzeTextOperationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AnalyzeTextOperationResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAnalyzeTextOperationResult(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
