// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryFileTaskStep : IUtf8JsonSerializable, IJsonModel<ContainerRegistryFileTaskStep>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryFileTaskStep>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryFileTaskStep>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryFileTaskStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryFileTaskStep)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("taskFilePath"u8);
            writer.WriteStringValue(TaskFilePath);
            if (Optional.IsDefined(ValuesFilePath))
            {
                writer.WritePropertyName("valuesFilePath"u8);
                writer.WriteStringValue(ValuesFilePath);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ContainerRegistryTaskStepType.ToString());
            if (options.Format != "W" && Optional.IsCollectionDefined(BaseImageDependencies))
            {
                writer.WritePropertyName("baseImageDependencies"u8);
                writer.WriteStartArray();
                foreach (var item in BaseImageDependencies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContextPath))
            {
                writer.WritePropertyName("contextPath"u8);
                writer.WriteStringValue(ContextPath);
            }
            if (Optional.IsDefined(ContextAccessToken))
            {
                writer.WritePropertyName("contextAccessToken"u8);
                writer.WriteStringValue(ContextAccessToken);
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

        ContainerRegistryFileTaskStep IJsonModel<ContainerRegistryFileTaskStep>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryFileTaskStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryFileTaskStep)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryFileTaskStep(document.RootElement, options);
        }

        internal static ContainerRegistryFileTaskStep DeserializeContainerRegistryFileTaskStep(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string taskFilePath = default;
            string valuesFilePath = default;
            IList<ContainerRegistryTaskOverridableValue> values = default;
            ContainerRegistryTaskStepType type = default;
            IReadOnlyList<ContainerRegistryBaseImageDependency> baseImageDependencies = default;
            string contextPath = default;
            string contextAccessToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("taskFilePath"u8))
                {
                    taskFilePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valuesFilePath"u8))
                {
                    valuesFilePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryTaskOverridableValue> array = new List<ContainerRegistryTaskOverridableValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTaskOverridableValue.DeserializeContainerRegistryTaskOverridableValue(item, options));
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ContainerRegistryTaskStepType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("baseImageDependencies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryBaseImageDependency> array = new List<ContainerRegistryBaseImageDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryBaseImageDependency.DeserializeContainerRegistryBaseImageDependency(item, options));
                    }
                    baseImageDependencies = array;
                    continue;
                }
                if (property.NameEquals("contextPath"u8))
                {
                    contextPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contextAccessToken"u8))
                {
                    contextAccessToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryFileTaskStep(
                type,
                baseImageDependencies ?? new ChangeTrackingList<ContainerRegistryBaseImageDependency>(),
                contextPath,
                contextAccessToken,
                serializedAdditionalRawData,
                taskFilePath,
                valuesFilePath,
                values ?? new ChangeTrackingList<ContainerRegistryTaskOverridableValue>());
        }

        BinaryData IPersistableModel<ContainerRegistryFileTaskStep>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryFileTaskStep>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryFileTaskStep)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryFileTaskStep IPersistableModel<ContainerRegistryFileTaskStep>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryFileTaskStep>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryFileTaskStep(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryFileTaskStep)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryFileTaskStep>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
