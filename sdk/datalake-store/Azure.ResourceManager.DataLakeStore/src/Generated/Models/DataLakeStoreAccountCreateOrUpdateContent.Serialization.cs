// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataLakeStore;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    public partial class DataLakeStoreAccountCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<DataLakeStoreAccountCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataLakeStoreAccountCreateOrUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataLakeStoreAccountCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreAccountCreateOrUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultGroup))
            {
                writer.WritePropertyName("defaultGroup"u8);
                writer.WriteStringValue(DefaultGroup);
            }
            if (Optional.IsDefined(EncryptionConfig))
            {
                writer.WritePropertyName("encryptionConfig"u8);
                writer.WriteObjectValue(EncryptionConfig);
            }
            if (Optional.IsDefined(EncryptionState))
            {
                writer.WritePropertyName("encryptionState"u8);
                writer.WriteStringValue(EncryptionState.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(FirewallRules))
            {
                writer.WritePropertyName("firewallRules"u8);
                writer.WriteStartArray();
                foreach (var item in FirewallRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FirewallState))
            {
                writer.WritePropertyName("firewallState"u8);
                writer.WriteStringValue(FirewallState.Value.ToSerialString());
            }
            if (Optional.IsDefined(FirewallAllowAzureIPs))
            {
                writer.WritePropertyName("firewallAllowAzureIps"u8);
                writer.WriteStringValue(FirewallAllowAzureIPs.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(TrustedIdProviders))
            {
                writer.WritePropertyName("trustedIdProviders"u8);
                writer.WriteStartArray();
                foreach (var item in TrustedIdProviders)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TrustedIdProviderState))
            {
                writer.WritePropertyName("trustedIdProviderState"u8);
                writer.WriteStringValue(TrustedIdProviderState.Value.ToSerialString());
            }
            if (Optional.IsDefined(NewTier))
            {
                writer.WritePropertyName("newTier"u8);
                writer.WriteStringValue(NewTier.Value.ToSerialString());
            }
            writer.WriteEndObject();
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

        DataLakeStoreAccountCreateOrUpdateContent IJsonModel<DataLakeStoreAccountCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreAccountCreateOrUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeStoreAccountCreateOrUpdateContent(document.RootElement, options);
        }

        internal static DataLakeStoreAccountCreateOrUpdateContent DeserializeDataLakeStoreAccountCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation location = default;
            IDictionary<string, string> tags = default;
            ManagedServiceIdentity identity = default;
            string defaultGroup = default;
            DataLakeStoreAccountEncryptionConfig encryptionConfig = default;
            DataLakeStoreEncryptionState? encryptionState = default;
            IList<FirewallRuleForDataLakeStoreAccountCreateOrUpdateContent> firewallRules = default;
            IList<VirtualNetworkRuleForDataLakeStoreAccountCreateOrUpdateContent> virtualNetworkRules = default;
            DataLakeStoreFirewallState? firewallState = default;
            DataLakeStoreFirewallAllowAzureIPsState? firewallAllowAzureIPs = default;
            IList<TrustedIdProviderForDataLakeStoreAccountCreateOrUpdateContent> trustedIdProviders = default;
            DataLakeStoreTrustedIdProviderState? trustedIdProviderState = default;
            DataLakeStoreCommitmentTierType? newTier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("defaultGroup"u8))
                        {
                            defaultGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptionConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionConfig = DataLakeStoreAccountEncryptionConfig.DeserializeDataLakeStoreAccountEncryptionConfig(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("encryptionState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionState = property0.Value.GetString().ToDataLakeStoreEncryptionState();
                            continue;
                        }
                        if (property0.NameEquals("firewallRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FirewallRuleForDataLakeStoreAccountCreateOrUpdateContent> array = new List<FirewallRuleForDataLakeStoreAccountCreateOrUpdateContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FirewallRuleForDataLakeStoreAccountCreateOrUpdateContent.DeserializeFirewallRuleForDataLakeStoreAccountCreateOrUpdateContent(item, options));
                            }
                            firewallRules = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualNetworkRuleForDataLakeStoreAccountCreateOrUpdateContent> array = new List<VirtualNetworkRuleForDataLakeStoreAccountCreateOrUpdateContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualNetworkRuleForDataLakeStoreAccountCreateOrUpdateContent.DeserializeVirtualNetworkRuleForDataLakeStoreAccountCreateOrUpdateContent(item, options));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("firewallState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallState = property0.Value.GetString().ToDataLakeStoreFirewallState();
                            continue;
                        }
                        if (property0.NameEquals("firewallAllowAzureIps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallAllowAzureIPs = property0.Value.GetString().ToDataLakeStoreFirewallAllowAzureIPsState();
                            continue;
                        }
                        if (property0.NameEquals("trustedIdProviders"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TrustedIdProviderForDataLakeStoreAccountCreateOrUpdateContent> array = new List<TrustedIdProviderForDataLakeStoreAccountCreateOrUpdateContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrustedIdProviderForDataLakeStoreAccountCreateOrUpdateContent.DeserializeTrustedIdProviderForDataLakeStoreAccountCreateOrUpdateContent(item, options));
                            }
                            trustedIdProviders = array;
                            continue;
                        }
                        if (property0.NameEquals("trustedIdProviderState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trustedIdProviderState = property0.Value.GetString().ToDataLakeStoreTrustedIdProviderState();
                            continue;
                        }
                        if (property0.NameEquals("newTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newTier = property0.Value.GetString().ToDataLakeStoreCommitmentTierType();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataLakeStoreAccountCreateOrUpdateContent(
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                identity,
                defaultGroup,
                encryptionConfig,
                encryptionState,
                firewallRules ?? new ChangeTrackingList<FirewallRuleForDataLakeStoreAccountCreateOrUpdateContent>(),
                virtualNetworkRules ?? new ChangeTrackingList<VirtualNetworkRuleForDataLakeStoreAccountCreateOrUpdateContent>(),
                firewallState,
                firewallAllowAzureIPs,
                trustedIdProviders ?? new ChangeTrackingList<TrustedIdProviderForDataLakeStoreAccountCreateOrUpdateContent>(),
                trustedIdProviderState,
                newTier,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataLakeStoreAccountCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreAccountCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        DataLakeStoreAccountCreateOrUpdateContent IPersistableModel<DataLakeStoreAccountCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataLakeStoreAccountCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreAccountCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataLakeStoreAccountCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
