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

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class FirmwareCryptoCertificateEntity : IUtf8JsonSerializable, IModelJsonSerializable<FirmwareCryptoCertificateEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FirmwareCryptoCertificateEntity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FirmwareCryptoCertificateEntity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CommonName))
            {
                if (CommonName != null)
                {
                    writer.WritePropertyName("commonName"u8);
                    writer.WriteStringValue(CommonName);
                }
                else
                {
                    writer.WriteNull("commonName");
                }
            }
            if (Optional.IsDefined(Organization))
            {
                if (Organization != null)
                {
                    writer.WritePropertyName("organization"u8);
                    writer.WriteStringValue(Organization);
                }
                else
                {
                    writer.WriteNull("organization");
                }
            }
            if (Optional.IsDefined(OrganizationalUnit))
            {
                if (OrganizationalUnit != null)
                {
                    writer.WritePropertyName("organizationalUnit"u8);
                    writer.WriteStringValue(OrganizationalUnit);
                }
                else
                {
                    writer.WriteNull("organizationalUnit");
                }
            }
            if (Optional.IsDefined(State))
            {
                if (State != null)
                {
                    writer.WritePropertyName("state"u8);
                    writer.WriteStringValue(State);
                }
                else
                {
                    writer.WriteNull("state");
                }
            }
            if (Optional.IsDefined(Country))
            {
                if (Country != null)
                {
                    writer.WritePropertyName("country"u8);
                    writer.WriteStringValue(Country);
                }
                else
                {
                    writer.WriteNull("country");
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

        internal static FirmwareCryptoCertificateEntity DeserializeFirmwareCryptoCertificateEntity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> commonName = default;
            Optional<string> organization = default;
            Optional<string> organizationalUnit = default;
            Optional<string> state = default;
            Optional<string> country = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commonName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        commonName = null;
                        continue;
                    }
                    commonName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        organization = null;
                        continue;
                    }
                    organization = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationalUnit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        organizationalUnit = null;
                        continue;
                    }
                    organizationalUnit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        state = null;
                        continue;
                    }
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        country = null;
                        continue;
                    }
                    country = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FirmwareCryptoCertificateEntity(commonName.Value, organization.Value, organizationalUnit.Value, state.Value, country.Value, rawData);
        }

        FirmwareCryptoCertificateEntity IModelJsonSerializable<FirmwareCryptoCertificateEntity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFirmwareCryptoCertificateEntity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FirmwareCryptoCertificateEntity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FirmwareCryptoCertificateEntity IModelSerializable<FirmwareCryptoCertificateEntity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFirmwareCryptoCertificateEntity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FirmwareCryptoCertificateEntity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FirmwareCryptoCertificateEntity"/> to convert. </param>
        public static implicit operator RequestContent(FirmwareCryptoCertificateEntity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FirmwareCryptoCertificateEntity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FirmwareCryptoCertificateEntity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFirmwareCryptoCertificateEntity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
