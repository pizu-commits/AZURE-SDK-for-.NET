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

namespace Azure.ResourceManager.BotService.Models
{
    public partial class TelegramChannelProperties : IUtf8JsonSerializable, IModelJsonSerializable<TelegramChannelProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TelegramChannelProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TelegramChannelProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TelegramChannelProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AccessToken))
            {
                writer.WritePropertyName("accessToken"u8);
                writer.WriteStringValue(AccessToken);
            }
            if (Optional.IsDefined(IsValidated))
            {
                writer.WritePropertyName("isValidated"u8);
                writer.WriteBooleanValue(IsValidated.Value);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
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

        internal static TelegramChannelProperties DeserializeTelegramChannelProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> accessToken = default;
            Optional<bool> isValidated = default;
            bool isEnabled = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessToken"u8))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isValidated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isValidated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TelegramChannelProperties(accessToken.Value, Optional.ToNullable(isValidated), isEnabled, rawData);
        }

        TelegramChannelProperties IModelJsonSerializable<TelegramChannelProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TelegramChannelProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTelegramChannelProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TelegramChannelProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TelegramChannelProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TelegramChannelProperties IModelSerializable<TelegramChannelProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TelegramChannelProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTelegramChannelProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TelegramChannelProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TelegramChannelProperties"/> to convert. </param>
        public static implicit operator RequestContent(TelegramChannelProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TelegramChannelProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TelegramChannelProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTelegramChannelProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
