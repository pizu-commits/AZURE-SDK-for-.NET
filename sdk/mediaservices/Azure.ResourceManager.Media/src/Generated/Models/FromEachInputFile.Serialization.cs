// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class FromEachInputFile : IUtf8JsonSerializable, IJsonModel<FromEachInputFile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FromEachInputFile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FromEachInputFile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FromEachInputFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FromEachInputFile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsCollectionDefined(IncludedTracks))
            {
                writer.WritePropertyName("includedTracks"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedTracks)
                {
                    writer.WriteObjectValue<TrackDescriptor>(item, options);
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

        FromEachInputFile IJsonModel<FromEachInputFile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FromEachInputFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FromEachInputFile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFromEachInputFile(document.RootElement, options);
        }

        internal static FromEachInputFile DeserializeFromEachInputFile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataType = default;
            IList<TrackDescriptor> includedTracks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("includedTracks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TrackDescriptor> array = new List<TrackDescriptor>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrackDescriptor.DeserializeTrackDescriptor(item, options));
                    }
                    includedTracks = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FromEachInputFile(odataType, includedTracks ?? new ChangeTrackingList<TrackDescriptor>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FromEachInputFile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FromEachInputFile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FromEachInputFile)} does not support writing '{options.Format}' format.");
            }
        }

        FromEachInputFile IPersistableModel<FromEachInputFile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FromEachInputFile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFromEachInputFile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FromEachInputFile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FromEachInputFile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
