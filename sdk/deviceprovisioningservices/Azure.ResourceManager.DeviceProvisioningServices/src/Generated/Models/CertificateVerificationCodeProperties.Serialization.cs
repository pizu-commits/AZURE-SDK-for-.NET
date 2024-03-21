// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class CertificateVerificationCodeProperties : IUtf8JsonSerializable, IJsonModel<CertificateVerificationCodeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CertificateVerificationCodeProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CertificateVerificationCodeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertificateVerificationCodeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CertificateVerificationCodeProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VerificationCode))
            {
                writer.WritePropertyName("verificationCode"u8);
                writer.WriteStringValue(VerificationCode);
            }
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteStringValue(Subject);
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiry"u8);
                writer.WriteStringValue(ExpireOn.Value, "R");
            }
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Thumbprint);
#else
                using (JsonDocument document = JsonDocument.Parse(Thumbprint))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(IsVerified))
            {
                writer.WritePropertyName("isVerified"u8);
                writer.WriteBooleanValue(IsVerified.Value);
            }
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Certificate);
#else
                using (JsonDocument document = JsonDocument.Parse(Certificate))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "R");
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updated"u8);
                writer.WriteStringValue(UpdatedOn.Value, "R");
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        CertificateVerificationCodeProperties IJsonModel<CertificateVerificationCodeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertificateVerificationCodeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CertificateVerificationCodeProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCertificateVerificationCodeProperties(document.RootElement, options);
        }

        internal static CertificateVerificationCodeProperties DeserializeCertificateVerificationCodeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string verificationCode = default;
            string subject = default;
            DateTimeOffset? expiry = default;
            BinaryData thumbprint = default;
            bool? isVerified = default;
            BinaryData certificate = default;
            DateTimeOffset? created = default;
            DateTimeOffset? updated = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verificationCode"u8))
                {
                    verificationCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiry = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("isVerified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("certificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificate = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("created"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    created = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("updated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updated = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CertificateVerificationCodeProperties(
                verificationCode,
                subject,
                expiry,
                thumbprint,
                isVerified,
                certificate,
                created,
                updated,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CertificateVerificationCodeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertificateVerificationCodeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CertificateVerificationCodeProperties)} does not support '{options.Format}' format.");
            }
        }

        CertificateVerificationCodeProperties IPersistableModel<CertificateVerificationCodeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertificateVerificationCodeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCertificateVerificationCodeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CertificateVerificationCodeProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CertificateVerificationCodeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
