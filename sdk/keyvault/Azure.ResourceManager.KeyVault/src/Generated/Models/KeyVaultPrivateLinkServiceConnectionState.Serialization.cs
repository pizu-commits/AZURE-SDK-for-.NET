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

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class KeyVaultPrivateLinkServiceConnectionState : IUtf8JsonSerializable, IModelJsonSerializable<KeyVaultPrivateLinkServiceConnectionState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KeyVaultPrivateLinkServiceConnectionState>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KeyVaultPrivateLinkServiceConnectionState>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultPrivateLinkServiceConnectionState>(this, options.Format);

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
                writer.WriteStringValue(ActionsRequired.Value.ToString());
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

        internal static KeyVaultPrivateLinkServiceConnectionState DeserializeKeyVaultPrivateLinkServiceConnectionState(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<KeyVaultPrivateEndpointServiceConnectionStatus> status = default;
            Optional<string> description = default;
            Optional<KeyVaultActionsRequiredMessage> actionsRequired = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new KeyVaultPrivateEndpointServiceConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionsRequired = new KeyVaultActionsRequiredMessage(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KeyVaultPrivateLinkServiceConnectionState(Optional.ToNullable(status), description.Value, Optional.ToNullable(actionsRequired), rawData);
        }

        KeyVaultPrivateLinkServiceConnectionState IModelJsonSerializable<KeyVaultPrivateLinkServiceConnectionState>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultPrivateLinkServiceConnectionState>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultPrivateLinkServiceConnectionState(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KeyVaultPrivateLinkServiceConnectionState>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultPrivateLinkServiceConnectionState>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KeyVaultPrivateLinkServiceConnectionState IModelSerializable<KeyVaultPrivateLinkServiceConnectionState>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultPrivateLinkServiceConnectionState>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKeyVaultPrivateLinkServiceConnectionState(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KeyVaultPrivateLinkServiceConnectionState"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KeyVaultPrivateLinkServiceConnectionState"/> to convert. </param>
        public static implicit operator RequestContent(KeyVaultPrivateLinkServiceConnectionState model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KeyVaultPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KeyVaultPrivateLinkServiceConnectionState(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKeyVaultPrivateLinkServiceConnectionState(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
