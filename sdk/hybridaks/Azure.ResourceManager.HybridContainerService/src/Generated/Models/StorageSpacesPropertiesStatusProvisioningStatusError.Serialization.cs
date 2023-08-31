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

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class StorageSpacesPropertiesStatusProvisioningStatusError : IUtf8JsonSerializable, IModelJsonSerializable<StorageSpacesPropertiesStatusProvisioningStatusError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageSpacesPropertiesStatusProvisioningStatusError>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageSpacesPropertiesStatusProvisioningStatusError>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
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

        internal static StorageSpacesPropertiesStatusProvisioningStatusError DeserializeStorageSpacesPropertiesStatusProvisioningStatusError(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> message = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageSpacesPropertiesStatusProvisioningStatusError(code.Value, message.Value, rawData);
        }

        StorageSpacesPropertiesStatusProvisioningStatusError IModelJsonSerializable<StorageSpacesPropertiesStatusProvisioningStatusError>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageSpacesPropertiesStatusProvisioningStatusError(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageSpacesPropertiesStatusProvisioningStatusError>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageSpacesPropertiesStatusProvisioningStatusError IModelSerializable<StorageSpacesPropertiesStatusProvisioningStatusError>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageSpacesPropertiesStatusProvisioningStatusError(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageSpacesPropertiesStatusProvisioningStatusError"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageSpacesPropertiesStatusProvisioningStatusError"/> to convert. </param>
        public static implicit operator RequestContent(StorageSpacesPropertiesStatusProvisioningStatusError model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageSpacesPropertiesStatusProvisioningStatusError"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageSpacesPropertiesStatusProvisioningStatusError(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageSpacesPropertiesStatusProvisioningStatusError(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
