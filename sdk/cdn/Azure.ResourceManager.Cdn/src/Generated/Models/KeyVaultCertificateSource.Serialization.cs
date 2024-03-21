// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class KeyVaultCertificateSource : IUtf8JsonSerializable, IJsonModel<KeyVaultCertificateSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KeyVaultCertificateSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KeyVaultCertificateSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultCertificateSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultCertificateSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(SourceType.ToString());
            writer.WritePropertyName("subscriptionId"u8);
            writer.WriteStringValue(SubscriptionId);
            writer.WritePropertyName("resourceGroupName"u8);
            writer.WriteStringValue(ResourceGroupName);
            writer.WritePropertyName("vaultName"u8);
            writer.WriteStringValue(VaultName);
            writer.WritePropertyName("secretName"u8);
            writer.WriteStringValue(SecretName);
            if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion"u8);
                writer.WriteStringValue(SecretVersion);
            }
            writer.WritePropertyName("updateRule"u8);
            writer.WriteStringValue(UpdateRule.ToString());
            writer.WritePropertyName("deleteRule"u8);
            writer.WriteStringValue(DeleteRule.ToString());
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

        KeyVaultCertificateSource IJsonModel<KeyVaultCertificateSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultCertificateSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultCertificateSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultCertificateSource(document.RootElement, options);
        }

        internal static KeyVaultCertificateSource DeserializeKeyVaultCertificateSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            KeyVaultCertificateSourceType typeName = default;
            string subscriptionId = default;
            string resourceGroupName = default;
            string vaultName = default;
            string secretName = default;
            string secretVersion = default;
            CertificateUpdateAction updateRule = default;
            CertificateDeleteAction deleteRule = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new KeyVaultCertificateSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"u8))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vaultName"u8))
                {
                    vaultName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretName"u8))
                {
                    secretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretVersion"u8))
                {
                    secretVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("updateRule"u8))
                {
                    updateRule = new CertificateUpdateAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deleteRule"u8))
                {
                    deleteRule = new CertificateDeleteAction(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KeyVaultCertificateSource(
                typeName,
                subscriptionId,
                resourceGroupName,
                vaultName,
                secretName,
                secretVersion,
                updateRule,
                deleteRule,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KeyVaultCertificateSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultCertificateSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KeyVaultCertificateSource)} does not support '{options.Format}' format.");
            }
        }

        KeyVaultCertificateSource IPersistableModel<KeyVaultCertificateSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultCertificateSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKeyVaultCertificateSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KeyVaultCertificateSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KeyVaultCertificateSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
