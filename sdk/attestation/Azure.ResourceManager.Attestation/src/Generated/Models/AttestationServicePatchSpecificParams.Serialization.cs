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
    internal partial class AttestationServicePatchSpecificParams : IUtf8JsonSerializable, IModelJsonSerializable<AttestationServicePatchSpecificParams>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AttestationServicePatchSpecificParams>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AttestationServicePatchSpecificParams>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AttestationServicePatchSpecificParams>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
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

        internal static AttestationServicePatchSpecificParams DeserializeAttestationServicePatchSpecificParams(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PublicNetworkAccessType> publicNetworkAccess = default;
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AttestationServicePatchSpecificParams(Optional.ToNullable(publicNetworkAccess), rawData);
        }

        AttestationServicePatchSpecificParams IModelJsonSerializable<AttestationServicePatchSpecificParams>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AttestationServicePatchSpecificParams>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAttestationServicePatchSpecificParams(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AttestationServicePatchSpecificParams>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AttestationServicePatchSpecificParams>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AttestationServicePatchSpecificParams IModelSerializable<AttestationServicePatchSpecificParams>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AttestationServicePatchSpecificParams>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAttestationServicePatchSpecificParams(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AttestationServicePatchSpecificParams"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AttestationServicePatchSpecificParams"/> to convert. </param>
        public static implicit operator RequestContent(AttestationServicePatchSpecificParams model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AttestationServicePatchSpecificParams"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AttestationServicePatchSpecificParams(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAttestationServicePatchSpecificParams(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
