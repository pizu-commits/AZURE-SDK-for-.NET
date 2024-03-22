// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class AudioTranscription : IUtf8JsonSerializable, IJsonModel<AudioTranscription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AudioTranscription>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AudioTranscription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranscription)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            if (Optional.IsDefined(InternalAudioTaskLabel))
            {
                writer.WritePropertyName("task"u8);
                writer.WriteStringValue(InternalAudioTaskLabel.Value.ToString());
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteNumberValue(Convert.ToDouble(Duration.Value.ToString("s\\.fff")));
            }
            if (Optional.IsCollectionDefined(Segments))
            {
                writer.WritePropertyName("segments"u8);
                writer.WriteStartArray();
                foreach (var item in Segments)
                {
                    writer.WriteObjectValue<AudioTranscriptionSegment>(item, options);
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

        AudioTranscription IJsonModel<AudioTranscription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranscription)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAudioTranscription(document.RootElement, options);
        }

        internal static AudioTranscription DeserializeAudioTranscription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            AudioTaskLabel? task = default;
            string language = default;
            TimeSpan? duration = default;
            IReadOnlyList<AudioTranscriptionSegment> segments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("task"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    task = new AudioTaskLabel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = TimeSpan.FromSeconds(property.Value.GetDouble());
                    continue;
                }
                if (property.NameEquals("segments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AudioTranscriptionSegment> array = new List<AudioTranscriptionSegment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AudioTranscriptionSegment.DeserializeAudioTranscriptionSegment(item, options));
                    }
                    segments = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AudioTranscription(
                text,
                task,
                language,
                duration,
                segments ?? new ChangeTrackingList<AudioTranscriptionSegment>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AudioTranscription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranscription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AudioTranscription)} does not support writing '{options.Format}' format.");
            }
        }

        AudioTranscription IPersistableModel<AudioTranscription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranscription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAudioTranscription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AudioTranscription)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AudioTranscription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<AudioTranscription>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
