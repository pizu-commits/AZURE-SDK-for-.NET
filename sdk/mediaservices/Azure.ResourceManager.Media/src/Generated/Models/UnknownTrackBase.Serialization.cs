// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class UnknownTrackBase : IUtf8JsonSerializable, IModelJsonSerializable<MediaAssetTrackBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaAssetTrackBase>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaAssetTrackBase>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaAssetTrackBase>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        internal static MediaAssetTrackBase DeserializeUnknownTrackBase(JsonElement element, ModelSerializerOptions options = default) => DeserializeMediaAssetTrackBase(element, options);

        MediaAssetTrackBase IModelJsonSerializable<MediaAssetTrackBase>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaAssetTrackBase>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownTrackBase(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaAssetTrackBase>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaAssetTrackBase>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaAssetTrackBase IModelSerializable<MediaAssetTrackBase>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaAssetTrackBase>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaAssetTrackBase(doc.RootElement, options);
        }
    }
}
