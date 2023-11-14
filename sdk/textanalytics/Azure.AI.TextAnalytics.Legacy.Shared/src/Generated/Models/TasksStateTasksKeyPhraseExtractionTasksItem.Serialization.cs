// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.AI.TextAnalytics.Legacy;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    internal partial class TasksStateTasksKeyPhraseExtractionTasksItem : IUtf8JsonSerializable, IJsonModel<TasksStateTasksKeyPhraseExtractionTasksItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TasksStateTasksKeyPhraseExtractionTasksItem>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<TasksStateTasksKeyPhraseExtractionTasksItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<TasksStateTasksKeyPhraseExtractionTasksItem>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<TasksStateTasksKeyPhraseExtractionTasksItem>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Results))
            {
                writer.WritePropertyName("results"u8);
                writer.WriteObjectValue(Results);
            }
            writer.WritePropertyName("lastUpdateDateTime"u8);
            writer.WriteStringValue(LastUpdateDateTime, "O");
            if (Optional.IsDefined(TaskName))
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(TaskName);
            }
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToSerialString());
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

        TasksStateTasksKeyPhraseExtractionTasksItem IJsonModel<TasksStateTasksKeyPhraseExtractionTasksItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TasksStateTasksKeyPhraseExtractionTasksItem)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTasksStateTasksKeyPhraseExtractionTasksItem(document.RootElement, options);
        }

        internal static TasksStateTasksKeyPhraseExtractionTasksItem DeserializeTasksStateTasksKeyPhraseExtractionTasksItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<KeyPhraseResult> results = default;
            DateTimeOffset lastUpdateDateTime = default;
            Optional<string> taskName = default;
            State status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    results = KeyPhraseResult.DeserializeKeyPhraseResult(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"u8))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToState();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TasksStateTasksKeyPhraseExtractionTasksItem(lastUpdateDateTime, taskName.Value, status, serializedAdditionalRawData, results.Value);
        }

        BinaryData IPersistableModel<TasksStateTasksKeyPhraseExtractionTasksItem>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TasksStateTasksKeyPhraseExtractionTasksItem)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        TasksStateTasksKeyPhraseExtractionTasksItem IPersistableModel<TasksStateTasksKeyPhraseExtractionTasksItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TasksStateTasksKeyPhraseExtractionTasksItem)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeTasksStateTasksKeyPhraseExtractionTasksItem(document.RootElement, options);
        }

        string IPersistableModel<TasksStateTasksKeyPhraseExtractionTasksItem>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
