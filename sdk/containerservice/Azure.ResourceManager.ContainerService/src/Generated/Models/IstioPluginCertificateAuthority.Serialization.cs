// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class IstioPluginCertificateAuthority : IUtf8JsonSerializable, IJsonModel<IstioPluginCertificateAuthority>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IstioPluginCertificateAuthority>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IstioPluginCertificateAuthority>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioPluginCertificateAuthority>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IstioPluginCertificateAuthority)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultId);
            }
            if (Optional.IsDefined(CertObjectName))
            {
                writer.WritePropertyName("certObjectName"u8);
                writer.WriteStringValue(CertObjectName);
            }
            if (Optional.IsDefined(KeyObjectName))
            {
                writer.WritePropertyName("keyObjectName"u8);
                writer.WriteStringValue(KeyObjectName);
            }
            if (Optional.IsDefined(RootCertObjectName))
            {
                writer.WritePropertyName("rootCertObjectName"u8);
                writer.WriteStringValue(RootCertObjectName);
            }
            if (Optional.IsDefined(CertChainObjectName))
            {
                writer.WritePropertyName("certChainObjectName"u8);
                writer.WriteStringValue(CertChainObjectName);
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

        IstioPluginCertificateAuthority IJsonModel<IstioPluginCertificateAuthority>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioPluginCertificateAuthority>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IstioPluginCertificateAuthority)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIstioPluginCertificateAuthority(document.RootElement, options);
        }

        internal static IstioPluginCertificateAuthority DeserializeIstioPluginCertificateAuthority(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier keyVaultId = default;
            string certObjectName = default;
            string keyObjectName = default;
            string rootCertObjectName = default;
            string certChainObjectName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("certObjectName"u8))
                {
                    certObjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyObjectName"u8))
                {
                    keyObjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rootCertObjectName"u8))
                {
                    rootCertObjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certChainObjectName"u8))
                {
                    certChainObjectName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IstioPluginCertificateAuthority(
                keyVaultId,
                certObjectName,
                keyObjectName,
                rootCertObjectName,
                certChainObjectName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IstioPluginCertificateAuthority>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioPluginCertificateAuthority>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IstioPluginCertificateAuthority)} does not support '{options.Format}' format.");
            }
        }

        IstioPluginCertificateAuthority IPersistableModel<IstioPluginCertificateAuthority>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioPluginCertificateAuthority>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIstioPluginCertificateAuthority(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IstioPluginCertificateAuthority)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IstioPluginCertificateAuthority>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
