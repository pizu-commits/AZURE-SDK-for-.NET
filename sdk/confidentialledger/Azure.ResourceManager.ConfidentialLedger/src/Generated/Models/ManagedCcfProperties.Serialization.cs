// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    public partial class ManagedCcfProperties : IUtf8JsonSerializable, IJsonModel<ManagedCcfProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedCcfProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedCcfProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedCcfProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedCcfProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(AppName))
            {
                writer.WritePropertyName("appName"u8);
                writer.WriteStringValue(AppName);
            }
            if (options.Format != "W" && Optional.IsDefined(AppUri))
            {
                writer.WritePropertyName("appUri"u8);
                writer.WriteStringValue(AppUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(IdentityServiceUri))
            {
                writer.WritePropertyName("identityServiceUri"u8);
                writer.WriteStringValue(IdentityServiceUri.AbsoluteUri);
            }
            if (!(MemberIdentityCertificates is ChangeTrackingList<ConfidentialLedgerMemberIdentityCertificate> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("memberIdentityCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in MemberIdentityCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DeploymentType))
            {
                writer.WritePropertyName("deploymentType"u8);
                writer.WriteObjectValue(DeploymentType);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
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

        ManagedCcfProperties IJsonModel<ManagedCcfProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedCcfProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedCcfProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedCcfProperties(document.RootElement, options);
        }

        internal static ManagedCcfProperties DeserializeManagedCcfProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> appName = default;
            Optional<Uri> appUri = default;
            Optional<Uri> identityServiceUri = default;
            Optional<IList<ConfidentialLedgerMemberIdentityCertificate>> memberIdentityCertificates = default;
            Optional<ConfidentialLedgerDeploymentType> deploymentType = default;
            Optional<ConfidentialLedgerProvisioningState> provisioningState = default;
            Optional<int> nodeCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appName"u8))
                {
                    appName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("memberIdentityCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConfidentialLedgerMemberIdentityCertificate> array = new List<ConfidentialLedgerMemberIdentityCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConfidentialLedgerMemberIdentityCertificate.DeserializeConfidentialLedgerMemberIdentityCertificate(item, options));
                    }
                    memberIdentityCertificates = array;
                    continue;
                }
                if (property.NameEquals("deploymentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentType = ConfidentialLedgerDeploymentType.DeserializeConfidentialLedgerDeploymentType(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ConfidentialLedgerProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedCcfProperties(appName.Value, appUri.Value, identityServiceUri.Value, Optional.ToList(memberIdentityCertificates), deploymentType.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(nodeCount), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedCcfProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedCcfProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedCcfProperties)} does not support '{options.Format}' format.");
            }
        }

        ManagedCcfProperties IPersistableModel<ManagedCcfProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedCcfProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedCcfProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedCcfProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedCcfProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
