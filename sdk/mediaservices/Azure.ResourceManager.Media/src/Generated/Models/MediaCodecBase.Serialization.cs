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
    public partial class MediaCodecBase : IUtf8JsonSerializable, IModelJsonSerializable<MediaCodecBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaCodecBase>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaCodecBase>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
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

        internal static MediaCodecBase DeserializeMediaCodecBase(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.AacAudio": return AacAudio.DeserializeAacAudio(element);
                    case "#Microsoft.Media.Audio": return MediaAudioBase.DeserializeMediaAudioBase(element);
                    case "#Microsoft.Media.CopyAudio": return CodecCopyAudio.DeserializeCodecCopyAudio(element);
                    case "#Microsoft.Media.CopyVideo": return CodecCopyVideo.DeserializeCodecCopyVideo(element);
                    case "#Microsoft.Media.DDAudio": return DDAudio.DeserializeDDAudio(element);
                    case "#Microsoft.Media.H264Video": return H264Video.DeserializeH264Video(element);
                    case "#Microsoft.Media.H265Video": return H265Video.DeserializeH265Video(element);
                    case "#Microsoft.Media.Image": return MediaImageBase.DeserializeMediaImageBase(element);
                    case "#Microsoft.Media.JpgImage": return JpgImage.DeserializeJpgImage(element);
                    case "#Microsoft.Media.PngImage": return PngImage.DeserializePngImage(element);
                    case "#Microsoft.Media.Video": return MediaVideoBase.DeserializeMediaVideoBase(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string odataType = default;
            Optional<string> label = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownCodec(odataType, label.Value, rawData);
        }

        MediaCodecBase IModelJsonSerializable<MediaCodecBase>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaCodecBase(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaCodecBase>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaCodecBase IModelSerializable<MediaCodecBase>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaCodecBase(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaCodecBase"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaCodecBase"/> to convert. </param>
        public static implicit operator RequestContent(MediaCodecBase model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaCodecBase"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaCodecBase(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaCodecBase(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
