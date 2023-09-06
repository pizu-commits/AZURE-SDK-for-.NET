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
    public partial class ProvisionedClustersCommonPropertiesStatusProvisioningStatusError : IUtf8JsonSerializable, IModelJsonSerializable<ProvisionedClustersCommonPropertiesStatusProvisioningStatusError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProvisionedClustersCommonPropertiesStatusProvisioningStatusError>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProvisionedClustersCommonPropertiesStatusProvisioningStatusError>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProvisionedClustersCommonPropertiesStatusProvisioningStatusError>(this, options.Format);

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

        internal static ProvisionedClustersCommonPropertiesStatusProvisioningStatusError DeserializeProvisionedClustersCommonPropertiesStatusProvisioningStatusError(JsonElement element, ModelSerializerOptions options = default)
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
            return new ProvisionedClustersCommonPropertiesStatusProvisioningStatusError(code.Value, message.Value, rawData);
        }

        ProvisionedClustersCommonPropertiesStatusProvisioningStatusError IModelJsonSerializable<ProvisionedClustersCommonPropertiesStatusProvisioningStatusError>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProvisionedClustersCommonPropertiesStatusProvisioningStatusError>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProvisionedClustersCommonPropertiesStatusProvisioningStatusError(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProvisionedClustersCommonPropertiesStatusProvisioningStatusError>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProvisionedClustersCommonPropertiesStatusProvisioningStatusError>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProvisionedClustersCommonPropertiesStatusProvisioningStatusError IModelSerializable<ProvisionedClustersCommonPropertiesStatusProvisioningStatusError>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProvisionedClustersCommonPropertiesStatusProvisioningStatusError>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProvisionedClustersCommonPropertiesStatusProvisioningStatusError(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProvisionedClustersCommonPropertiesStatusProvisioningStatusError"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProvisionedClustersCommonPropertiesStatusProvisioningStatusError"/> to convert. </param>
        public static implicit operator RequestContent(ProvisionedClustersCommonPropertiesStatusProvisioningStatusError model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProvisionedClustersCommonPropertiesStatusProvisioningStatusError"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProvisionedClustersCommonPropertiesStatusProvisioningStatusError(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProvisionedClustersCommonPropertiesStatusProvisioningStatusError(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
