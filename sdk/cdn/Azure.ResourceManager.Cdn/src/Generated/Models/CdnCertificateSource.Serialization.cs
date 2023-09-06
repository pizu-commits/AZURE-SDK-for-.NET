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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CdnCertificateSource : IUtf8JsonSerializable, IModelJsonSerializable<CdnCertificateSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CdnCertificateSource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CdnCertificateSource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CdnCertificateSource>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(SourceType.ToString());
            writer.WritePropertyName("certificateType"u8);
            writer.WriteStringValue(CertificateType.ToString());
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

        internal static CdnCertificateSource DeserializeCdnCertificateSource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CdnCertificateSourceType typeName = default;
            CdnManagedCertificateType certificateType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new CdnCertificateSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("certificateType"u8))
                {
                    certificateType = new CdnManagedCertificateType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CdnCertificateSource(typeName, certificateType, rawData);
        }

        CdnCertificateSource IModelJsonSerializable<CdnCertificateSource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CdnCertificateSource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnCertificateSource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CdnCertificateSource>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CdnCertificateSource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CdnCertificateSource IModelSerializable<CdnCertificateSource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CdnCertificateSource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCdnCertificateSource(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CdnCertificateSource"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CdnCertificateSource"/> to convert. </param>
        public static implicit operator RequestContent(CdnCertificateSource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CdnCertificateSource"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CdnCertificateSource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCdnCertificateSource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
