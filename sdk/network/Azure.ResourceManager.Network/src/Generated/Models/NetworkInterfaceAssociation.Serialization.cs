// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkInterfaceAssociation : IUtf8JsonSerializable, IJsonModel<NetworkInterfaceAssociation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkInterfaceAssociation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkInterfaceAssociation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceAssociation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceAssociation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsCollectionDefined(SecurityRules))
            {
                writer.WritePropertyName("securityRules"u8);
                writer.WriteStartArray();
                foreach (var item in SecurityRules)
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

        NetworkInterfaceAssociation IJsonModel<NetworkInterfaceAssociation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceAssociation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceAssociation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkInterfaceAssociation(document.RootElement, options);
        }

        internal static NetworkInterfaceAssociation DeserializeNetworkInterfaceAssociation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            IReadOnlyList<SecurityRuleData> securityRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("securityRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityRuleData> array = new List<SecurityRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityRuleData.DeserializeSecurityRuleData(item, options));
                    }
                    securityRules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkInterfaceAssociation(id, securityRules ?? new ChangeTrackingList<SecurityRuleData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkInterfaceAssociation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceAssociation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaceAssociation)} does not support '{options.Format}' format.");
            }
        }

        NetworkInterfaceAssociation IPersistableModel<NetworkInterfaceAssociation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceAssociation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkInterfaceAssociation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaceAssociation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkInterfaceAssociation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
