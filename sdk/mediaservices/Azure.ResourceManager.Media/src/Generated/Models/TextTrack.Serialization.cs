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
    public partial class TextTrack : IUtf8JsonSerializable, IModelJsonSerializable<TextTrack>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TextTrack>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TextTrack>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TextTrack>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName"u8);
                writer.WriteStringValue(FileName);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(PlayerVisibility))
            {
                writer.WritePropertyName("playerVisibility"u8);
                writer.WriteStringValue(PlayerVisibility.Value.ToString());
            }
            if (Optional.IsDefined(HlsSettings))
            {
                writer.WritePropertyName("hlsSettings"u8);
                if (HlsSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<HlsSettings>)HlsSettings).Serialize(writer, options);
                }
            }
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

        internal static TextTrack DeserializeTextTrack(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> fileName = default;
            Optional<string> displayName = default;
            Optional<string> languageCode = default;
            Optional<PlayerVisibility> playerVisibility = default;
            Optional<HlsSettings> hlsSettings = default;
            string odataType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileName"u8))
                {
                    fileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("languageCode"u8))
                {
                    languageCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("playerVisibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    playerVisibility = new PlayerVisibility(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hlsSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hlsSettings = HlsSettings.DeserializeHlsSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TextTrack(odataType, fileName.Value, displayName.Value, languageCode.Value, Optional.ToNullable(playerVisibility), hlsSettings.Value, rawData);
        }

        TextTrack IModelJsonSerializable<TextTrack>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TextTrack>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTextTrack(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TextTrack>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TextTrack>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TextTrack IModelSerializable<TextTrack>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TextTrack>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTextTrack(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TextTrack"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TextTrack"/> to convert. </param>
        public static implicit operator RequestContent(TextTrack model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TextTrack"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TextTrack(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTextTrack(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
