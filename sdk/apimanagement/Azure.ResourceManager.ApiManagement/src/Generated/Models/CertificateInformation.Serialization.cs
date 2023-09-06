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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class CertificateInformation : IUtf8JsonSerializable, IModelJsonSerializable<CertificateInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CertificateInformation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CertificateInformation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateInformation>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("expiry"u8);
            writer.WriteStringValue(ExpireOn, "O");
            writer.WritePropertyName("thumbprint"u8);
            writer.WriteStringValue(Thumbprint);
            writer.WritePropertyName("subject"u8);
            writer.WriteStringValue(Subject);
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

        internal static CertificateInformation DeserializeCertificateInformation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset expiry = default;
            string thumbprint = default;
            string subject = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expiry"u8))
                {
                    expiry = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CertificateInformation(expiry, thumbprint, subject, rawData);
        }

        CertificateInformation IModelJsonSerializable<CertificateInformation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateInformation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCertificateInformation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CertificateInformation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateInformation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CertificateInformation IModelSerializable<CertificateInformation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateInformation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCertificateInformation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CertificateInformation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CertificateInformation"/> to convert. </param>
        public static implicit operator RequestContent(CertificateInformation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CertificateInformation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CertificateInformation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCertificateInformation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
