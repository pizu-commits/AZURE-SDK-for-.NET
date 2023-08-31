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
    public partial class CommonEncryptionCenc : IUtf8JsonSerializable, IModelJsonSerializable<CommonEncryptionCenc>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CommonEncryptionCenc>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CommonEncryptionCenc>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EnabledProtocols))
            {
                writer.WritePropertyName("enabledProtocols"u8);
                if (EnabledProtocols is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MediaEnabledProtocols>)EnabledProtocols).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(ClearTracks))
            {
                writer.WritePropertyName("clearTracks"u8);
                writer.WriteStartArray();
                foreach (var item in ClearTracks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MediaTrackSelection>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContentKeys))
            {
                writer.WritePropertyName("contentKeys"u8);
                if (ContentKeys is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StreamingPolicyContentKeys>)ContentKeys).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Drm))
            {
                writer.WritePropertyName("drm"u8);
                if (Drm is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CencDrmConfiguration>)Drm).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ClearKeyEncryptionConfiguration))
            {
                writer.WritePropertyName("clearKeyEncryptionConfiguration"u8);
                if (ClearKeyEncryptionConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClearKeyEncryptionConfiguration>)ClearKeyEncryptionConfiguration).Serialize(writer, options);
                }
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

        internal static CommonEncryptionCenc DeserializeCommonEncryptionCenc(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MediaEnabledProtocols> enabledProtocols = default;
            Optional<IList<MediaTrackSelection>> clearTracks = default;
            Optional<StreamingPolicyContentKeys> contentKeys = default;
            Optional<CencDrmConfiguration> drm = default;
            Optional<ClearKeyEncryptionConfiguration> clearKeyEncryptionConfiguration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabledProtocols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledProtocols = MediaEnabledProtocols.DeserializeMediaEnabledProtocols(property.Value);
                    continue;
                }
                if (property.NameEquals("clearTracks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaTrackSelection> array = new List<MediaTrackSelection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaTrackSelection.DeserializeMediaTrackSelection(item));
                    }
                    clearTracks = array;
                    continue;
                }
                if (property.NameEquals("contentKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentKeys = StreamingPolicyContentKeys.DeserializeStreamingPolicyContentKeys(property.Value);
                    continue;
                }
                if (property.NameEquals("drm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    drm = CencDrmConfiguration.DeserializeCencDrmConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("clearKeyEncryptionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clearKeyEncryptionConfiguration = ClearKeyEncryptionConfiguration.DeserializeClearKeyEncryptionConfiguration(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CommonEncryptionCenc(enabledProtocols.Value, Optional.ToList(clearTracks), contentKeys.Value, drm.Value, clearKeyEncryptionConfiguration.Value, rawData);
        }

        CommonEncryptionCenc IModelJsonSerializable<CommonEncryptionCenc>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCommonEncryptionCenc(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CommonEncryptionCenc>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CommonEncryptionCenc IModelSerializable<CommonEncryptionCenc>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCommonEncryptionCenc(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CommonEncryptionCenc"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CommonEncryptionCenc"/> to convert. </param>
        public static implicit operator RequestContent(CommonEncryptionCenc model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CommonEncryptionCenc"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CommonEncryptionCenc(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCommonEncryptionCenc(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
