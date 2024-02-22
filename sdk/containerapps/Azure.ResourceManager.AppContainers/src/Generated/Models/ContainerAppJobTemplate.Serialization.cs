// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppJobTemplate : IUtf8JsonSerializable, IJsonModel<ContainerAppJobTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppJobTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppJobTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobTemplate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(InitContainers is ChangeTrackingList<ContainerAppInitContainer> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("initContainers"u8);
                writer.WriteStartArray();
                foreach (var item in InitContainers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Containers is ChangeTrackingList<ContainerAppContainer> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("containers"u8);
                writer.WriteStartArray();
                foreach (var item in Containers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Volumes is ChangeTrackingList<ContainerAppVolume> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("volumes"u8);
                writer.WriteStartArray();
                foreach (var item in Volumes)
                {
                    writer.WriteObjectValue(item);
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

        ContainerAppJobTemplate IJsonModel<ContainerAppJobTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobTemplate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppJobTemplate(document.RootElement, options);
        }

        internal static ContainerAppJobTemplate DeserializeContainerAppJobTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ContainerAppInitContainer>> initContainers = default;
            Optional<IList<ContainerAppContainer>> containers = default;
            Optional<IList<ContainerAppVolume>> volumes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("initContainers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppInitContainer> array = new List<ContainerAppInitContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppInitContainer.DeserializeContainerAppInitContainer(item, options));
                    }
                    initContainers = array;
                    continue;
                }
                if (property.NameEquals("containers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppContainer> array = new List<ContainerAppContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppContainer.DeserializeContainerAppContainer(item, options));
                    }
                    containers = array;
                    continue;
                }
                if (property.NameEquals("volumes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppVolume> array = new List<ContainerAppVolume>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppVolume.DeserializeContainerAppVolume(item, options));
                    }
                    volumes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppJobTemplate(Optional.ToList(initContainers), Optional.ToList(containers), Optional.ToList(volumes), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppJobTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobTemplate)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppJobTemplate IPersistableModel<ContainerAppJobTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppJobTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobTemplate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppJobTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
