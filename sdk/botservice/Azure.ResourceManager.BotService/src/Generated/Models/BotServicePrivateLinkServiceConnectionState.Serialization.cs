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
    public partial class BotServicePrivateLinkServiceConnectionState : IUtf8JsonSerializable, IModelJsonSerializable<BotServicePrivateLinkServiceConnectionState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BotServicePrivateLinkServiceConnectionState>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BotServicePrivateLinkServiceConnectionState>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BotServicePrivateLinkServiceConnectionState>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ActionsRequired))
            {
                writer.WritePropertyName("actionsRequired"u8);
                writer.WriteStringValue(ActionsRequired);
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

        internal static BotServicePrivateLinkServiceConnectionState DeserializeBotServicePrivateLinkServiceConnectionState(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BotServicePrivateEndpointServiceConnectionStatus> status = default;
            Optional<string> description = default;
            Optional<string> actionsRequired = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new BotServicePrivateEndpointServiceConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"u8))
                {
                    actionsRequired = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BotServicePrivateLinkServiceConnectionState(Optional.ToNullable(status), description.Value, actionsRequired.Value, rawData);
        }

        BotServicePrivateLinkServiceConnectionState IModelJsonSerializable<BotServicePrivateLinkServiceConnectionState>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BotServicePrivateLinkServiceConnectionState>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBotServicePrivateLinkServiceConnectionState(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BotServicePrivateLinkServiceConnectionState>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BotServicePrivateLinkServiceConnectionState>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BotServicePrivateLinkServiceConnectionState IModelSerializable<BotServicePrivateLinkServiceConnectionState>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BotServicePrivateLinkServiceConnectionState>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBotServicePrivateLinkServiceConnectionState(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BotServicePrivateLinkServiceConnectionState"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BotServicePrivateLinkServiceConnectionState"/> to convert. </param>
        public static implicit operator RequestContent(BotServicePrivateLinkServiceConnectionState model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BotServicePrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BotServicePrivateLinkServiceConnectionState(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBotServicePrivateLinkServiceConnectionState(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
