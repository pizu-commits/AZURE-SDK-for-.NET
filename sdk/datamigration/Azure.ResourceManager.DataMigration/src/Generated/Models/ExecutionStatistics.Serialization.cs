// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ExecutionStatistics : IUtf8JsonSerializable, IJsonModel<ExecutionStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExecutionStatistics>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExecutionStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecutionStatistics)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExecutionCount))
            {
                writer.WritePropertyName("executionCount"u8);
                writer.WriteNumberValue(ExecutionCount.Value);
            }
            if (Optional.IsDefined(CpuTimeMs))
            {
                writer.WritePropertyName("cpuTimeMs"u8);
                writer.WriteNumberValue(CpuTimeMs.Value);
            }
            if (Optional.IsDefined(ElapsedTimeMs))
            {
                writer.WritePropertyName("elapsedTimeMs"u8);
                writer.WriteNumberValue(ElapsedTimeMs.Value);
            }
            if (!(WaitStats is ChangeTrackingDictionary<string, WaitStatistics> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("waitStats"u8);
                writer.WriteStartObject();
                foreach (var item in WaitStats)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(HasErrors))
            {
                writer.WritePropertyName("hasErrors"u8);
                writer.WriteBooleanValue(HasErrors.Value);
            }
            if (!(SqlErrors is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("sqlErrors"u8);
                writer.WriteStartArray();
                foreach (var item in SqlErrors)
                {
                    writer.WriteStringValue(item);
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

        ExecutionStatistics IJsonModel<ExecutionStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecutionStatistics)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExecutionStatistics(document.RootElement, options);
        }

        internal static ExecutionStatistics DeserializeExecutionStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> executionCount = default;
            Optional<float> cpuTimeMs = default;
            Optional<float> elapsedTimeMs = default;
            Optional<IReadOnlyDictionary<string, WaitStatistics>> waitStats = default;
            Optional<bool> hasErrors = default;
            Optional<IReadOnlyList<string>> sqlErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("executionCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    executionCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cpuTimeMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuTimeMs = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("elapsedTimeMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elapsedTimeMs = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("waitStats"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, WaitStatistics> dictionary = new Dictionary<string, WaitStatistics>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, WaitStatistics.DeserializeWaitStatistics(property0.Value, options));
                    }
                    waitStats = dictionary;
                    continue;
                }
                if (property.NameEquals("hasErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasErrors = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sqlErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sqlErrors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExecutionStatistics(Optional.ToNullable(executionCount), Optional.ToNullable(cpuTimeMs), Optional.ToNullable(elapsedTimeMs), Optional.ToDictionary(waitStats), Optional.ToNullable(hasErrors), Optional.ToList(sqlErrors), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExecutionStatistics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExecutionStatistics)} does not support '{options.Format}' format.");
            }
        }

        ExecutionStatistics IPersistableModel<ExecutionStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExecutionStatistics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExecutionStatistics)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExecutionStatistics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
