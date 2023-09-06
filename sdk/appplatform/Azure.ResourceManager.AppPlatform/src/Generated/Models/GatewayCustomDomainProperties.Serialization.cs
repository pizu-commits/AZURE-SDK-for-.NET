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

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class GatewayCustomDomainProperties : IUtf8JsonSerializable, IModelJsonSerializable<GatewayCustomDomainProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GatewayCustomDomainProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GatewayCustomDomainProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GatewayCustomDomainProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(Thumbprint);
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

        internal static GatewayCustomDomainProperties DeserializeGatewayCustomDomainProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> thumbprint = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GatewayCustomDomainProperties(thumbprint.Value, rawData);
        }

        GatewayCustomDomainProperties IModelJsonSerializable<GatewayCustomDomainProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GatewayCustomDomainProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGatewayCustomDomainProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GatewayCustomDomainProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GatewayCustomDomainProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GatewayCustomDomainProperties IModelSerializable<GatewayCustomDomainProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GatewayCustomDomainProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGatewayCustomDomainProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GatewayCustomDomainProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GatewayCustomDomainProperties"/> to convert. </param>
        public static implicit operator RequestContent(GatewayCustomDomainProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GatewayCustomDomainProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GatewayCustomDomainProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGatewayCustomDomainProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
