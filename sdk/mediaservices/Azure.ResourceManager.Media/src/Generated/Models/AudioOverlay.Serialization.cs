// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Media.Models
{
    public partial class AudioOverlay : IUtf8JsonSerializable, IModelJsonSerializable<AudioOverlay>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AudioOverlay>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AudioOverlay>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AudioOverlay>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("inputLabel"u8);
            writer.WriteStringValue(InputLabel);
            if (Optional.IsDefined(Start))
            {
                writer.WritePropertyName("start"u8);
                writer.WriteStringValue(Start.Value, "P");
            }
            if (Optional.IsDefined(End))
            {
                writer.WritePropertyName("end"u8);
                writer.WriteStringValue(End.Value, "P");
            }
            if (Optional.IsDefined(FadeInDuration))
            {
                writer.WritePropertyName("fadeInDuration"u8);
                writer.WriteStringValue(FadeInDuration.Value, "P");
            }
            if (Optional.IsDefined(FadeOutDuration))
            {
                writer.WritePropertyName("fadeOutDuration"u8);
                writer.WriteStringValue(FadeOutDuration.Value, "P");
            }
            if (Optional.IsDefined(AudioGainLevel))
            {
                writer.WritePropertyName("audioGainLevel"u8);
                writer.WriteNumberValue(AudioGainLevel.Value);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static AudioOverlay DeserializeAudioOverlay(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataType = default;
            string inputLabel = default;
            Optional<TimeSpan> start = default;
            Optional<TimeSpan> end = default;
            Optional<TimeSpan> fadeInDuration = default;
            Optional<TimeSpan> fadeOutDuration = default;
            Optional<double> audioGainLevel = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputLabel"u8))
                {
                    inputLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    start = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    end = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("fadeInDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fadeInDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("fadeOutDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fadeOutDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("audioGainLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    audioGainLevel = property.Value.GetDouble();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AudioOverlay(odataType, inputLabel, Optional.ToNullable(start), Optional.ToNullable(end), Optional.ToNullable(fadeInDuration), Optional.ToNullable(fadeOutDuration), Optional.ToNullable(audioGainLevel), rawData);
        }

        AudioOverlay IModelJsonSerializable<AudioOverlay>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AudioOverlay>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAudioOverlay(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AudioOverlay>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AudioOverlay>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AudioOverlay IModelSerializable<AudioOverlay>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AudioOverlay>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAudioOverlay(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AudioOverlay"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AudioOverlay"/> to convert. </param>
        public static implicit operator RequestContent(AudioOverlay model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AudioOverlay"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AudioOverlay(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAudioOverlay(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
