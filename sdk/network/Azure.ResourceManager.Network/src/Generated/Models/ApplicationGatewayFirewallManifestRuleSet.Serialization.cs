// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayFirewallManifestRuleSet : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayFirewallManifestRuleSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayFirewallManifestRuleSet>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationGatewayFirewallManifestRuleSet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayFirewallManifestRuleSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApplicationGatewayFirewallManifestRuleSet)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("ruleSetType"u8);
            writer.WriteStringValue(RuleSetType);
            writer.WritePropertyName("ruleSetVersion"u8);
            writer.WriteStringValue(RuleSetVersion);
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tiers))
            {
                writer.WritePropertyName("tiers"u8);
                writer.WriteStartArray();
                foreach (var item in Tiers)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("ruleGroups"u8);
            writer.WriteStartArray();
            foreach (var item in RuleGroups)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        ApplicationGatewayFirewallManifestRuleSet IJsonModel<ApplicationGatewayFirewallManifestRuleSet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayFirewallManifestRuleSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApplicationGatewayFirewallManifestRuleSet)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayFirewallManifestRuleSet(document.RootElement, options);
        }

        internal static ApplicationGatewayFirewallManifestRuleSet DeserializeApplicationGatewayFirewallManifestRuleSet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ruleSetType = default;
            string ruleSetVersion = default;
            Optional<ApplicationGatewayRuleSetStatusOption> status = default;
            Optional<IReadOnlyList<ApplicationGatewayTierType>> tiers = default;
            IReadOnlyList<ApplicationGatewayFirewallRuleGroup> ruleGroups = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleSetType"u8))
                {
                    ruleSetType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSetVersion"u8))
                {
                    ruleSetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ApplicationGatewayRuleSetStatusOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tiers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayTierType> array = new List<ApplicationGatewayTierType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ApplicationGatewayTierType(item.GetString()));
                    }
                    tiers = array;
                    continue;
                }
                if (property.NameEquals("ruleGroups"u8))
                {
                    List<ApplicationGatewayFirewallRuleGroup> array = new List<ApplicationGatewayFirewallRuleGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayFirewallRuleGroup.DeserializeApplicationGatewayFirewallRuleGroup(item));
                    }
                    ruleGroups = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationGatewayFirewallManifestRuleSet(ruleSetType, ruleSetVersion, Optional.ToNullable(status), Optional.ToList(tiers), ruleGroups, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewayFirewallManifestRuleSet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayFirewallManifestRuleSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ApplicationGatewayFirewallManifestRuleSet)} does not support '{options.Format}' format.");
            }
        }

        ApplicationGatewayFirewallManifestRuleSet IPersistableModel<ApplicationGatewayFirewallManifestRuleSet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayFirewallManifestRuleSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationGatewayFirewallManifestRuleSet(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ApplicationGatewayFirewallManifestRuleSet)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayFirewallManifestRuleSet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
