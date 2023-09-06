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
    public partial class FirmwareCryptoCertificateSummary : IUtf8JsonSerializable, IModelJsonSerializable<FirmwareCryptoCertificateSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FirmwareCryptoCertificateSummary>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FirmwareCryptoCertificateSummary>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FirmwareCryptoCertificateSummary>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TotalCertificates))
            {
                writer.WritePropertyName("totalCertificates"u8);
                writer.WriteNumberValue(TotalCertificates.Value);
            }
            if (Optional.IsDefined(PairedKeys))
            {
                writer.WritePropertyName("pairedKeys"u8);
                writer.WriteNumberValue(PairedKeys.Value);
            }
            if (Optional.IsDefined(Expired))
            {
                writer.WritePropertyName("expired"u8);
                writer.WriteNumberValue(Expired.Value);
            }
            if (Optional.IsDefined(ExpiringSoon))
            {
                writer.WritePropertyName("expiringSoon"u8);
                writer.WriteNumberValue(ExpiringSoon.Value);
            }
            if (Optional.IsDefined(WeakSignature))
            {
                writer.WritePropertyName("weakSignature"u8);
                writer.WriteNumberValue(WeakSignature.Value);
            }
            if (Optional.IsDefined(SelfSigned))
            {
                writer.WritePropertyName("selfSigned"u8);
                writer.WriteNumberValue(SelfSigned.Value);
            }
            if (Optional.IsDefined(ShortKeySize))
            {
                writer.WritePropertyName("shortKeySize"u8);
                writer.WriteNumberValue(ShortKeySize.Value);
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

        internal static FirmwareCryptoCertificateSummary DeserializeFirmwareCryptoCertificateSummary(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> totalCertificates = default;
            Optional<long> pairedKeys = default;
            Optional<long> expired = default;
            Optional<long> expiringSoon = default;
            Optional<long> weakSignature = default;
            Optional<long> selfSigned = default;
            Optional<long> shortKeySize = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCertificates = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("pairedKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pairedKeys = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("expired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expired = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("expiringSoon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiringSoon = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("weakSignature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weakSignature = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("selfSigned"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    selfSigned = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("shortKeySize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shortKeySize = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FirmwareCryptoCertificateSummary(Optional.ToNullable(totalCertificates), Optional.ToNullable(pairedKeys), Optional.ToNullable(expired), Optional.ToNullable(expiringSoon), Optional.ToNullable(weakSignature), Optional.ToNullable(selfSigned), Optional.ToNullable(shortKeySize), rawData);
        }

        FirmwareCryptoCertificateSummary IModelJsonSerializable<FirmwareCryptoCertificateSummary>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FirmwareCryptoCertificateSummary>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFirmwareCryptoCertificateSummary(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FirmwareCryptoCertificateSummary>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FirmwareCryptoCertificateSummary>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FirmwareCryptoCertificateSummary IModelSerializable<FirmwareCryptoCertificateSummary>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FirmwareCryptoCertificateSummary>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFirmwareCryptoCertificateSummary(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FirmwareCryptoCertificateSummary"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FirmwareCryptoCertificateSummary"/> to convert. </param>
        public static implicit operator RequestContent(FirmwareCryptoCertificateSummary model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FirmwareCryptoCertificateSummary"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FirmwareCryptoCertificateSummary(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFirmwareCryptoCertificateSummary(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
