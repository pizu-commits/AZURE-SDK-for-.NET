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
    public partial class SecurityPolicyWebApplicationFirewallAssociation : IUtf8JsonSerializable, IJsonModel<SecurityPolicyWebApplicationFirewallAssociation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityPolicyWebApplicationFirewallAssociation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityPolicyWebApplicationFirewallAssociation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityPolicyWebApplicationFirewallAssociation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityPolicyWebApplicationFirewallAssociation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Domains))
            {
                writer.WritePropertyName("domains"u8);
                writer.WriteStartArray();
                foreach (var item in Domains)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PatternsToMatch))
            {
                writer.WritePropertyName("patternsToMatch"u8);
                writer.WriteStartArray();
                foreach (var item in PatternsToMatch)
                {
                    writer.WriteStringValue(item);
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

        SecurityPolicyWebApplicationFirewallAssociation IJsonModel<SecurityPolicyWebApplicationFirewallAssociation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityPolicyWebApplicationFirewallAssociation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityPolicyWebApplicationFirewallAssociation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityPolicyWebApplicationFirewallAssociation(document.RootElement, options);
        }

        internal static SecurityPolicyWebApplicationFirewallAssociation DeserializeSecurityPolicyWebApplicationFirewallAssociation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<FrontDoorActivatedResourceInfo> domains = default;
            IList<string> patternsToMatch = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domains"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FrontDoorActivatedResourceInfo> array = new List<FrontDoorActivatedResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FrontDoorActivatedResourceInfo.DeserializeFrontDoorActivatedResourceInfo(item, options));
                    }
                    domains = array;
                    continue;
                }
                if (property.NameEquals("patternsToMatch"u8))
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
                    patternsToMatch = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SecurityPolicyWebApplicationFirewallAssociation(domains ?? new ChangeTrackingList<FrontDoorActivatedResourceInfo>(), patternsToMatch ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityPolicyWebApplicationFirewallAssociation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityPolicyWebApplicationFirewallAssociation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityPolicyWebApplicationFirewallAssociation)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityPolicyWebApplicationFirewallAssociation IPersistableModel<SecurityPolicyWebApplicationFirewallAssociation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityPolicyWebApplicationFirewallAssociation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityPolicyWebApplicationFirewallAssociation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityPolicyWebApplicationFirewallAssociation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityPolicyWebApplicationFirewallAssociation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
