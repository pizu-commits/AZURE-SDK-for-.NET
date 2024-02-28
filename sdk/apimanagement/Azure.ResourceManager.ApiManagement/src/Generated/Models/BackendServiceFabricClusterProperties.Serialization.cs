// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class BackendServiceFabricClusterProperties : IUtf8JsonSerializable, IJsonModel<BackendServiceFabricClusterProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackendServiceFabricClusterProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackendServiceFabricClusterProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendServiceFabricClusterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendServiceFabricClusterProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ClientCertificateId != null)
            {
                writer.WritePropertyName("clientCertificateId"u8);
                writer.WriteStringValue(ClientCertificateId);
            }
            if (ClientCertificatethumbprint != null)
            {
                writer.WritePropertyName("clientCertificatethumbprint"u8);
                writer.WriteStringValue(ClientCertificatethumbprint);
            }
            if (MaxPartitionResolutionRetries.HasValue)
            {
                writer.WritePropertyName("maxPartitionResolutionRetries"u8);
                writer.WriteNumberValue(MaxPartitionResolutionRetries.Value);
            }
            writer.WritePropertyName("managementEndpoints"u8);
            writer.WriteStartArray();
            foreach (var item in ManagementEndpoints)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (!(ServerCertificateThumbprints is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("serverCertificateThumbprints"u8);
                writer.WriteStartArray();
                foreach (var item in ServerCertificateThumbprints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ServerX509Names is ChangeTrackingList<X509CertificateName> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("serverX509Names"u8);
                writer.WriteStartArray();
                foreach (var item in ServerX509Names)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        BackendServiceFabricClusterProperties IJsonModel<BackendServiceFabricClusterProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendServiceFabricClusterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendServiceFabricClusterProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackendServiceFabricClusterProperties(document.RootElement, options);
        }

        internal static BackendServiceFabricClusterProperties DeserializeBackendServiceFabricClusterProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clientCertificateId = default;
            string clientCertificatethumbprint = default;
            int? maxPartitionResolutionRetries = default;
            IList<string> managementEndpoints = default;
            IList<string> serverCertificateThumbprints = default;
            IList<X509CertificateName> serverX509Names = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientCertificateId"u8))
                {
                    clientCertificateId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientCertificatethumbprint"u8))
                {
                    clientCertificatethumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxPartitionResolutionRetries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPartitionResolutionRetries = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("managementEndpoints"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    managementEndpoints = array;
                    continue;
                }
                if (property.NameEquals("serverCertificateThumbprints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    serverCertificateThumbprints = array;
                    continue;
                }
                if (property.NameEquals("serverX509Names"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<X509CertificateName> array = new List<X509CertificateName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(X509CertificateName.DeserializeX509CertificateName(item, options));
                    }
                    serverX509Names = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackendServiceFabricClusterProperties(
                clientCertificateId,
                clientCertificatethumbprint,
                maxPartitionResolutionRetries,
                managementEndpoints,
                serverCertificateThumbprints ?? new ChangeTrackingList<string>(),
                serverX509Names ?? new ChangeTrackingList<X509CertificateName>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackendServiceFabricClusterProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendServiceFabricClusterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackendServiceFabricClusterProperties)} does not support '{options.Format}' format.");
            }
        }

        BackendServiceFabricClusterProperties IPersistableModel<BackendServiceFabricClusterProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendServiceFabricClusterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackendServiceFabricClusterProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackendServiceFabricClusterProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackendServiceFabricClusterProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
