// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterServerCertificateCommonNames : IUtf8JsonSerializable, IJsonModel<ClusterServerCertificateCommonNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterServerCertificateCommonNames>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterServerCertificateCommonNames>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterServerCertificateCommonNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterServerCertificateCommonNames)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CommonNames))
            {
                writer.WritePropertyName("commonNames"u8);
                writer.WriteStartArray();
                foreach (var item in CommonNames)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(X509StoreName))
            {
                writer.WritePropertyName("x509StoreName"u8);
                writer.WriteStringValue(X509StoreName.Value.ToString());
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

        ClusterServerCertificateCommonNames IJsonModel<ClusterServerCertificateCommonNames>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterServerCertificateCommonNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterServerCertificateCommonNames)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterServerCertificateCommonNames(document.RootElement, options);
        }

        internal static ClusterServerCertificateCommonNames DeserializeClusterServerCertificateCommonNames(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ClusterServerCertificateCommonName> commonNames = default;
            ClusterCertificateStoreName? x509StoreName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commonNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ClusterServerCertificateCommonName> array = new List<ClusterServerCertificateCommonName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClusterServerCertificateCommonName.DeserializeClusterServerCertificateCommonName(item, options));
                    }
                    commonNames = array;
                    continue;
                }
                if (property.NameEquals("x509StoreName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    x509StoreName = new ClusterCertificateStoreName(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterServerCertificateCommonNames(commonNames ?? new ChangeTrackingList<ClusterServerCertificateCommonName>(), x509StoreName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterServerCertificateCommonNames>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterServerCertificateCommonNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterServerCertificateCommonNames)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterServerCertificateCommonNames IPersistableModel<ClusterServerCertificateCommonNames>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterServerCertificateCommonNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterServerCertificateCommonNames(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterServerCertificateCommonNames)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterServerCertificateCommonNames>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
