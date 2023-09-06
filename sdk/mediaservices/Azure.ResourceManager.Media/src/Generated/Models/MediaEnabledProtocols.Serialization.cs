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
    public partial class MediaEnabledProtocols : IUtf8JsonSerializable, IModelJsonSerializable<MediaEnabledProtocols>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaEnabledProtocols>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaEnabledProtocols>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaEnabledProtocols>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("download"u8);
            writer.WriteBooleanValue(IsDownloadEnabled);
            writer.WritePropertyName("dash"u8);
            writer.WriteBooleanValue(IsDashEnabled);
            writer.WritePropertyName("hls"u8);
            writer.WriteBooleanValue(IsHlsEnabled);
            writer.WritePropertyName("smoothStreaming"u8);
            writer.WriteBooleanValue(IsSmoothStreamingEnabled);
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

        internal static MediaEnabledProtocols DeserializeMediaEnabledProtocols(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool download = default;
            bool dash = default;
            bool hls = default;
            bool smoothStreaming = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("download"u8))
                {
                    download = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dash"u8))
                {
                    dash = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hls"u8))
                {
                    hls = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("smoothStreaming"u8))
                {
                    smoothStreaming = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaEnabledProtocols(download, dash, hls, smoothStreaming, rawData);
        }

        MediaEnabledProtocols IModelJsonSerializable<MediaEnabledProtocols>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaEnabledProtocols>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaEnabledProtocols(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaEnabledProtocols>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaEnabledProtocols>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaEnabledProtocols IModelSerializable<MediaEnabledProtocols>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaEnabledProtocols>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaEnabledProtocols(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaEnabledProtocols"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaEnabledProtocols"/> to convert. </param>
        public static implicit operator RequestContent(MediaEnabledProtocols model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaEnabledProtocols"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaEnabledProtocols(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaEnabledProtocols(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
