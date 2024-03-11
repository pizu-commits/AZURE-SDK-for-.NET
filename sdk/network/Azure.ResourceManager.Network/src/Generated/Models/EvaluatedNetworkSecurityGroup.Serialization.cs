// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class EvaluatedNetworkSecurityGroup : IUtf8JsonSerializable, IJsonModel<EvaluatedNetworkSecurityGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EvaluatedNetworkSecurityGroup>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EvaluatedNetworkSecurityGroup>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EvaluatedNetworkSecurityGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EvaluatedNetworkSecurityGroup)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkSecurityGroupId))
            {
                writer.WritePropertyName("networkSecurityGroupId"u8);
                writer.WriteStringValue(NetworkSecurityGroupId);
            }
            if (Optional.IsDefined(AppliedTo))
            {
                writer.WritePropertyName("appliedTo"u8);
                writer.WriteStringValue(AppliedTo);
            }
            if (Optional.IsDefined(MatchedRule))
            {
                writer.WritePropertyName("matchedRule"u8);
                writer.WriteObjectValue(MatchedRule);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RulesEvaluationResult))
            {
                writer.WritePropertyName("rulesEvaluationResult"u8);
                writer.WriteStartArray();
                foreach (var item in RulesEvaluationResult)
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

        EvaluatedNetworkSecurityGroup IJsonModel<EvaluatedNetworkSecurityGroup>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EvaluatedNetworkSecurityGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EvaluatedNetworkSecurityGroup)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEvaluatedNetworkSecurityGroup(document.RootElement, options);
        }

        internal static EvaluatedNetworkSecurityGroup DeserializeEvaluatedNetworkSecurityGroup(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier networkSecurityGroupId = default;
            string appliedTo = default;
            MatchedRule matchedRule = default;
            IReadOnlyList<NetworkSecurityRulesEvaluationResult> rulesEvaluationResult = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkSecurityGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkSecurityGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appliedTo"u8))
                {
                    appliedTo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("matchedRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    matchedRule = MatchedRule.DeserializeMatchedRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("rulesEvaluationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkSecurityRulesEvaluationResult> array = new List<NetworkSecurityRulesEvaluationResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkSecurityRulesEvaluationResult.DeserializeNetworkSecurityRulesEvaluationResult(item, options));
                    }
                    rulesEvaluationResult = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EvaluatedNetworkSecurityGroup(networkSecurityGroupId, appliedTo, matchedRule, rulesEvaluationResult ?? new ChangeTrackingList<NetworkSecurityRulesEvaluationResult>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EvaluatedNetworkSecurityGroup>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EvaluatedNetworkSecurityGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EvaluatedNetworkSecurityGroup)} does not support '{options.Format}' format.");
            }
        }

        EvaluatedNetworkSecurityGroup IPersistableModel<EvaluatedNetworkSecurityGroup>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EvaluatedNetworkSecurityGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEvaluatedNetworkSecurityGroup(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EvaluatedNetworkSecurityGroup)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EvaluatedNetworkSecurityGroup>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
