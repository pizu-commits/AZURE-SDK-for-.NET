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

namespace Azure.ResourceManager.Attestation.Models
{
    public partial class AttestationServiceCreationSpecificParams : IUtf8JsonSerializable, IModelJsonSerializable<AttestationServiceCreationSpecificParams>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AttestationServiceCreationSpecificParams>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AttestationServiceCreationSpecificParams>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AttestationServiceCreationSpecificParams>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(PolicySigningCertificates))
            {
                writer.WritePropertyName("policySigningCertificates"u8);
                if (PolicySigningCertificates is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<JsonWebKeySet>)PolicySigningCertificates).Serialize(writer, options);
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

        internal static AttestationServiceCreationSpecificParams DeserializeAttestationServiceCreationSpecificParams(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PublicNetworkAccessType> publicNetworkAccess = default;
            Optional<JsonWebKeySet> policySigningCertificates = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new PublicNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policySigningCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policySigningCertificates = JsonWebKeySet.DeserializeJsonWebKeySet(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AttestationServiceCreationSpecificParams(Optional.ToNullable(publicNetworkAccess), policySigningCertificates.Value, rawData);
        }

        AttestationServiceCreationSpecificParams IModelJsonSerializable<AttestationServiceCreationSpecificParams>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AttestationServiceCreationSpecificParams>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAttestationServiceCreationSpecificParams(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AttestationServiceCreationSpecificParams>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AttestationServiceCreationSpecificParams>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AttestationServiceCreationSpecificParams IModelSerializable<AttestationServiceCreationSpecificParams>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AttestationServiceCreationSpecificParams>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAttestationServiceCreationSpecificParams(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AttestationServiceCreationSpecificParams"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AttestationServiceCreationSpecificParams"/> to convert. </param>
        public static implicit operator RequestContent(AttestationServiceCreationSpecificParams model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AttestationServiceCreationSpecificParams"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AttestationServiceCreationSpecificParams(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAttestationServiceCreationSpecificParams(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
