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
    public partial class MediaAudioBase : IUtf8JsonSerializable, IJsonModel<MediaAudioBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaAudioBase>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MediaAudioBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAudioBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaAudioBase)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Channels))
            {
                writer.WritePropertyName("channels"u8);
                writer.WriteNumberValue(Channels.Value);
            }
            if (Optional.IsDefined(SamplingRate))
            {
                writer.WritePropertyName("samplingRate"u8);
                writer.WriteNumberValue(SamplingRate.Value);
            }
            if (Optional.IsDefined(Bitrate))
            {
                writer.WritePropertyName("bitrate"u8);
                writer.WriteNumberValue(Bitrate.Value);
            }
        }

        MediaAudioBase IJsonModel<MediaAudioBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAudioBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaAudioBase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaAudioBase(document.RootElement, options);
        }

        internal static MediaAudioBase DeserializeMediaAudioBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.AacAudio": return AacAudio.DeserializeAacAudio(element, options);
                    case "#Microsoft.Media.DDAudio": return DDAudio.DeserializeDDAudio(element, options);
                }
            }
            int? channels = default;
            int? samplingRate = default;
            int? bitrate = default;
            string odataType = "#Microsoft.Media.Audio";
            string label = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("channels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    channels = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("samplingRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    samplingRate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bitrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MediaAudioBase(
                odataType,
                label,
                serializedAdditionalRawData,
                channels,
                samplingRate,
                bitrate);
        }

        BinaryData IPersistableModel<MediaAudioBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAudioBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaAudioBase)} does not support writing '{options.Format}' format.");
            }
        }

        MediaAudioBase IPersistableModel<MediaAudioBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAudioBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaAudioBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaAudioBase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaAudioBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
