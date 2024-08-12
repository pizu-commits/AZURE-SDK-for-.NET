// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class HealthcareApisServiceProperties : IUtf8JsonSerializable, IJsonModel<HealthcareApisServiceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthcareApisServiceProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HealthcareApisServiceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareApisServiceProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AccessPolicies))
            {
                writer.WritePropertyName("accessPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in AccessPolicies)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CosmosDbConfiguration))
            {
                writer.WritePropertyName("cosmosDbConfiguration"u8);
                writer.WriteObjectValue(CosmosDbConfiguration, options);
            }
            if (Optional.IsDefined(AuthenticationConfiguration))
            {
                writer.WritePropertyName("authenticationConfiguration"u8);
                writer.WriteObjectValue(AuthenticationConfiguration, options);
            }
            if (Optional.IsDefined(CorsConfiguration))
            {
                writer.WritePropertyName("corsConfiguration"u8);
                writer.WriteObjectValue(CorsConfiguration, options);
            }
            if (Optional.IsDefined(ExportConfiguration))
            {
                writer.WritePropertyName("exportConfiguration"u8);
                writer.WriteObjectValue(ExportConfiguration, options);
            }
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(AcrConfiguration))
            {
                writer.WritePropertyName("acrConfiguration"u8);
                writer.WriteObjectValue(AcrConfiguration, options);
            }
            if (Optional.IsDefined(ImportConfiguration))
            {
                writer.WritePropertyName("importConfiguration"u8);
                writer.WriteObjectValue(ImportConfiguration, options);
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

        HealthcareApisServiceProperties IJsonModel<HealthcareApisServiceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareApisServiceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareApisServiceProperties(document.RootElement, options);
        }

        internal static HealthcareApisServiceProperties DeserializeHealthcareApisServiceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthcareApisProvisioningState? provisioningState = default;
            IList<HealthcareApisServiceAccessPolicyEntry> accessPolicies = default;
            HealthcareApisServiceCosmosDbConfiguration cosmosDbConfiguration = default;
            HealthcareApisServiceAuthenticationConfiguration authenticationConfiguration = default;
            HealthcareApisServiceCorsConfiguration corsConfiguration = default;
            ServiceExportConfigurationInfo exportConfiguration = default;
            IList<HealthcareApisPrivateEndpointConnectionData> privateEndpointConnections = default;
            HealthcareApisPublicNetworkAccess? publicNetworkAccess = default;
            HealthcareApisServiceAcrConfiguration acrConfiguration = default;
            HealthcareApisServiceImportConfiguration importConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new HealthcareApisProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accessPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HealthcareApisServiceAccessPolicyEntry> array = new List<HealthcareApisServiceAccessPolicyEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareApisServiceAccessPolicyEntry.DeserializeHealthcareApisServiceAccessPolicyEntry(item, options));
                    }
                    accessPolicies = array;
                    continue;
                }
                if (property.NameEquals("cosmosDbConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cosmosDbConfiguration = HealthcareApisServiceCosmosDbConfiguration.DeserializeHealthcareApisServiceCosmosDbConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("authenticationConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationConfiguration = HealthcareApisServiceAuthenticationConfiguration.DeserializeHealthcareApisServiceAuthenticationConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("corsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    corsConfiguration = HealthcareApisServiceCorsConfiguration.DeserializeHealthcareApisServiceCorsConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("exportConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exportConfiguration = ServiceExportConfigurationInfo.DeserializeServiceExportConfigurationInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HealthcareApisPrivateEndpointConnectionData> array = new List<HealthcareApisPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareApisPrivateEndpointConnectionData.DeserializeHealthcareApisPrivateEndpointConnectionData(item, options));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new HealthcareApisPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("acrConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acrConfiguration = HealthcareApisServiceAcrConfiguration.DeserializeHealthcareApisServiceAcrConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("importConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    importConfiguration = HealthcareApisServiceImportConfiguration.DeserializeHealthcareApisServiceImportConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HealthcareApisServiceProperties(
                provisioningState,
                accessPolicies ?? new ChangeTrackingList<HealthcareApisServiceAccessPolicyEntry>(),
                cosmosDbConfiguration,
                authenticationConfiguration,
                corsConfiguration,
                exportConfiguration,
                privateEndpointConnections ?? new ChangeTrackingList<HealthcareApisPrivateEndpointConnectionData>(),
                publicNetworkAccess,
                acrConfiguration,
                importConfiguration,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthcareApisServiceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HealthcareApisServiceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        HealthcareApisServiceProperties IPersistableModel<HealthcareApisServiceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHealthcareApisServiceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HealthcareApisServiceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthcareApisServiceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
