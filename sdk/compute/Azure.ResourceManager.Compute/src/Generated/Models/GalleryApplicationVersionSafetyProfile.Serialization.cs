// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class GalleryApplicationVersionSafetyProfile : IUtf8JsonSerializable, IJsonModel<GalleryApplicationVersionSafetyProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryApplicationVersionSafetyProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GalleryApplicationVersionSafetyProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryApplicationVersionSafetyProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryApplicationVersionSafetyProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AllowDeletionOfReplicatedLocations))
            {
                writer.WritePropertyName("allowDeletionOfReplicatedLocations"u8);
                writer.WriteBooleanValue(AllowDeletionOfReplicatedLocations.Value);
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

        GalleryApplicationVersionSafetyProfile IJsonModel<GalleryApplicationVersionSafetyProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryApplicationVersionSafetyProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryApplicationVersionSafetyProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryApplicationVersionSafetyProfile(document.RootElement, options);
        }

        internal static GalleryApplicationVersionSafetyProfile DeserializeGalleryApplicationVersionSafetyProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? allowDeletionOfReplicatedLocations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowDeletionOfReplicatedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowDeletionOfReplicatedLocations = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GalleryApplicationVersionSafetyProfile(allowDeletionOfReplicatedLocations, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GalleryApplicationVersionSafetyProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryApplicationVersionSafetyProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GalleryApplicationVersionSafetyProfile)} does not support '{options.Format}' format.");
            }
        }

        GalleryApplicationVersionSafetyProfile IPersistableModel<GalleryApplicationVersionSafetyProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryApplicationVersionSafetyProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGalleryApplicationVersionSafetyProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GalleryApplicationVersionSafetyProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryApplicationVersionSafetyProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
