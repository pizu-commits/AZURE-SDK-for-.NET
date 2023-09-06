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
    public partial class CustomDomainHttpsContent : IUtf8JsonSerializable, IModelJsonSerializable<CustomDomainHttpsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CustomDomainHttpsContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CustomDomainHttpsContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomDomainHttpsContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("certificateSource"u8);
            writer.WriteStringValue(CertificateSource.ToString());
            writer.WritePropertyName("protocolType"u8);
            writer.WriteStringValue(ProtocolType.ToString());
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToSerialString());
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

        internal static CustomDomainHttpsContent DeserializeCustomDomainHttpsContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("certificateSource", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureKeyVault": return UserManagedHttpsContent.DeserializeUserManagedHttpsContent(element);
                    case "Cdn": return CdnManagedHttpsContent.DeserializeCdnManagedHttpsContent(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            CertificateSource certificateSource = default;
            SecureDeliveryProtocolType protocolType = default;
            Optional<CdnMinimumTlsVersion> minimumTlsVersion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateSource"u8))
                {
                    certificateSource = new CertificateSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocolType"u8))
                {
                    protocolType = new SecureDeliveryProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minimumTlsVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumTlsVersion = property.Value.GetString().ToCdnMinimumTlsVersion();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownCustomDomainHttpsParameters(certificateSource, protocolType, Optional.ToNullable(minimumTlsVersion), rawData);
        }

        CustomDomainHttpsContent IModelJsonSerializable<CustomDomainHttpsContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomDomainHttpsContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomDomainHttpsContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CustomDomainHttpsContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomDomainHttpsContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CustomDomainHttpsContent IModelSerializable<CustomDomainHttpsContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomDomainHttpsContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCustomDomainHttpsContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CustomDomainHttpsContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CustomDomainHttpsContent"/> to convert. </param>
        public static implicit operator RequestContent(CustomDomainHttpsContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CustomDomainHttpsContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CustomDomainHttpsContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCustomDomainHttpsContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
