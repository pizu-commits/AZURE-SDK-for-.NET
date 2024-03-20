// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryTriggerRun : IUtf8JsonSerializable, IJsonModel<DataFactoryTriggerRun>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryTriggerRun>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryTriggerRun>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryTriggerRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryTriggerRun)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TriggerRunId))
            {
                writer.WritePropertyName("triggerRunId"u8);
                writer.WriteStringValue(TriggerRunId);
            }
            if (options.Format != "W" && Optional.IsDefined(TriggerName))
            {
                writer.WritePropertyName("triggerName"u8);
                writer.WriteStringValue(TriggerName);
            }
            if (options.Format != "W" && Optional.IsDefined(TriggerType))
            {
                writer.WritePropertyName("triggerType"u8);
                writer.WriteStringValue(TriggerType);
            }
            if (options.Format != "W" && Optional.IsDefined(TriggerRunTimestamp))
            {
                writer.WritePropertyName("triggerRunTimestamp"u8);
                writer.WriteStringValue(TriggerRunTimestamp.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(TriggeredPipelines))
            {
                writer.WritePropertyName("triggeredPipelines"u8);
                writer.WriteStartObject();
                foreach (var item in TriggeredPipelines)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RunDimension))
            {
                writer.WritePropertyName("runDimension"u8);
                writer.WriteStartObject();
                foreach (var item in RunDimension)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DependencyStatus))
            {
                writer.WritePropertyName("dependencyStatus"u8);
                writer.WriteStartObject();
                foreach (var item in DependencyStatus)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        DataFactoryTriggerRun IJsonModel<DataFactoryTriggerRun>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryTriggerRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryTriggerRun)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryTriggerRun(document.RootElement, options);
        }

        internal static DataFactoryTriggerRun DeserializeDataFactoryTriggerRun(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string triggerRunId = default;
            string triggerName = default;
            string triggerType = default;
            DateTimeOffset? triggerRunTimestamp = default;
            DataFactoryTriggerRunStatus? status = default;
            string message = default;
            IReadOnlyDictionary<string, string> properties = default;
            IReadOnlyDictionary<string, string> triggeredPipelines = default;
            IReadOnlyDictionary<string, string> runDimension = default;
            IReadOnlyDictionary<string, BinaryData> dependencyStatus = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("triggerRunId"u8))
                {
                    triggerRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerName"u8))
                {
                    triggerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerType"u8))
                {
                    triggerType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerRunTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    triggerRunTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DataFactoryTriggerRunStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("triggeredPipelines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    triggeredPipelines = dictionary;
                    continue;
                }
                if (property.NameEquals("runDimension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    runDimension = dictionary;
                    continue;
                }
                if (property.NameEquals("dependencyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    dependencyStatus = dictionary;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryTriggerRun(
                triggerRunId,
                triggerName,
                triggerType,
                triggerRunTimestamp,
                status,
                message,
                properties ?? new ChangeTrackingDictionary<string, string>(),
                triggeredPipelines ?? new ChangeTrackingDictionary<string, string>(),
                runDimension ?? new ChangeTrackingDictionary<string, string>(),
                dependencyStatus ?? new ChangeTrackingDictionary<string, BinaryData>(),
                additionalProperties);
        }

        BinaryData IPersistableModel<DataFactoryTriggerRun>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryTriggerRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryTriggerRun)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryTriggerRun IPersistableModel<DataFactoryTriggerRun>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryTriggerRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryTriggerRun(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryTriggerRun)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryTriggerRun>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
