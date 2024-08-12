// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterAaddsDetail : IUtf8JsonSerializable, IJsonModel<HDInsightClusterAaddsDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightClusterAaddsDetail>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightClusterAaddsDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterAaddsDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterAaddsDetail)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (Optional.IsDefined(IsInitialSyncComplete))
            {
                writer.WritePropertyName("initialSyncComplete"u8);
                writer.WriteBooleanValue(IsInitialSyncComplete.Value);
            }
            if (Optional.IsDefined(IsLdapsEnabled))
            {
                writer.WritePropertyName("ldapsEnabled"u8);
                writer.WriteBooleanValue(IsLdapsEnabled.Value);
            }
            if (Optional.IsDefined(LdapsPublicCertificateInBase64))
            {
                writer.WritePropertyName("ldapsPublicCertificateInBase64"u8);
                writer.WriteStringValue(LdapsPublicCertificateInBase64);
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
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

        HDInsightClusterAaddsDetail IJsonModel<HDInsightClusterAaddsDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterAaddsDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterAaddsDetail)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterAaddsDetail(document.RootElement, options);
        }

        internal static HDInsightClusterAaddsDetail DeserializeHDInsightClusterAaddsDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainName = default;
            bool? initialSyncComplete = default;
            bool? ldapsEnabled = default;
            string ldapsPublicCertificateInBase64 = default;
            ResourceIdentifier resourceId = default;
            ResourceIdentifier subnetId = default;
            Guid? tenantId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialSyncComplete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialSyncComplete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ldapsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ldapsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ldapsPublicCertificateInBase64"u8))
                {
                    ldapsPublicCertificateInBase64 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightClusterAaddsDetail(
                domainName,
                initialSyncComplete,
                ldapsEnabled,
                ldapsPublicCertificateInBase64,
                resourceId,
                subnetId,
                tenantId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightClusterAaddsDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterAaddsDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterAaddsDetail)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightClusterAaddsDetail IPersistableModel<HDInsightClusterAaddsDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterAaddsDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightClusterAaddsDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterAaddsDetail)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightClusterAaddsDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
