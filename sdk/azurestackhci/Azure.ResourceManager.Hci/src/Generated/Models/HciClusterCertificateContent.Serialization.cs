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

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciClusterCertificateContent : IUtf8JsonSerializable, IModelJsonSerializable<HciClusterCertificateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HciClusterCertificateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HciClusterCertificateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HciClusterCertificateContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                if (Properties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<HciClusterRawCertificate>)Properties).Serialize(writer, options);
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

        internal static HciClusterCertificateContent DeserializeHciClusterCertificateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HciClusterRawCertificate> properties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = HciClusterRawCertificate.DeserializeHciClusterRawCertificate(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HciClusterCertificateContent(properties.Value, rawData);
        }

        HciClusterCertificateContent IModelJsonSerializable<HciClusterCertificateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HciClusterCertificateContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHciClusterCertificateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HciClusterCertificateContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HciClusterCertificateContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HciClusterCertificateContent IModelSerializable<HciClusterCertificateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HciClusterCertificateContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHciClusterCertificateContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HciClusterCertificateContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HciClusterCertificateContent"/> to convert. </param>
        public static implicit operator RequestContent(HciClusterCertificateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HciClusterCertificateContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HciClusterCertificateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHciClusterCertificateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
