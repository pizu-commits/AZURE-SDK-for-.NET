// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnalyzeTextLROResult : IUtf8JsonSerializable, IJsonModel<AnalyzeTextLROResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalyzeTextLROResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AnalyzeTextLROResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AnalyzeTextLROResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AnalyzeTextLROResult>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(TaskName))
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(TaskName);
            }
            writer.WritePropertyName("lastUpdateDateTime"u8);
            writer.WriteStringValue(LastUpdateDateTime, "O");
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        AnalyzeTextLROResult IJsonModel<AnalyzeTextLROResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AnalyzeTextLROResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeTextLROResult(document.RootElement, options);
        }

        internal static AnalyzeTextLROResult DeserializeAnalyzeTextLROResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AbstractiveSummarizationLROResults": return AbstractiveSummarizationLROResult.DeserializeAbstractiveSummarizationLROResult(element);
                    case "CustomEntityRecognitionLROResults": return CustomEntityRecognitionLROResult.DeserializeCustomEntityRecognitionLROResult(element);
                    case "CustomMultiLabelClassificationLROResults": return CustomMultiLabelClassificationLROResult.DeserializeCustomMultiLabelClassificationLROResult(element);
                    case "CustomSingleLabelClassificationLROResults": return CustomSingleLabelClassificationLROResult.DeserializeCustomSingleLabelClassificationLROResult(element);
                    case "EntityLinkingLROResults": return EntityLinkingLROResult.DeserializeEntityLinkingLROResult(element);
                    case "EntityRecognitionLROResults": return EntityRecognitionLROResult.DeserializeEntityRecognitionLROResult(element);
                    case "ExtractiveSummarizationLROResults": return ExtractiveSummarizationLROResult.DeserializeExtractiveSummarizationLROResult(element);
                    case "HealthcareLROResults": return HealthcareLROResult.DeserializeHealthcareLROResult(element);
                    case "KeyPhraseExtractionLROResults": return KeyPhraseExtractionLROResult.DeserializeKeyPhraseExtractionLROResult(element);
                    case "PiiEntityRecognitionLROResults": return PiiEntityRecognitionLROResult.DeserializePiiEntityRecognitionLROResult(element);
                    case "SentimentAnalysisLROResults": return SentimentLROResult.DeserializeSentimentLROResult(element);
                }
            }
            AnalyzeTextLROResultsKind kind = default;
            Optional<string> taskName = default;
            DateTimeOffset lastUpdateDateTime = default;
            TextAnalyticsOperationStatus status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextLROResultsKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"u8))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new TextAnalyticsOperationStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AnalyzeTextLROResult(lastUpdateDateTime, status, serializedAdditionalRawData, kind, taskName.Value);
        }

        BinaryData IPersistableModel<AnalyzeTextLROResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AnalyzeTextLROResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AnalyzeTextLROResult IPersistableModel<AnalyzeTextLROResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AnalyzeTextLROResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAnalyzeTextLROResult(document.RootElement, options);
        }

        string IPersistableModel<AnalyzeTextLROResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
