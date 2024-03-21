// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class NetworkSecurityPerimeterProfileAccessRule : IUtf8JsonSerializable, IJsonModel<NetworkSecurityPerimeterProfileAccessRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkSecurityPerimeterProfileAccessRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkSecurityPerimeterProfileAccessRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterProfileAccessRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterProfileAccessRule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FullyQualifiedArmId))
            {
                writer.WritePropertyName("fullyQualifiedArmId"u8);
                writer.WriteStringValue(FullyQualifiedArmId);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(NetworkSecurityPerimeterProfileAccessRuleType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(NetworkSecurityPerimeterProfileAccessRuleType);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Direction))
            {
                writer.WritePropertyName("direction"u8);
                writer.WriteStringValue(Direction.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AddressPrefixes))
            {
                writer.WritePropertyName("addressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Subscriptions))
            {
                writer.WritePropertyName("subscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in Subscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NetworkSecurityPerimeters))
            {
                writer.WritePropertyName("networkSecurityPerimeters"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkSecurityPerimeters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FullyQualifiedDomainNames))
            {
                writer.WritePropertyName("fullyQualifiedDomainNames"u8);
                writer.WriteStartArray();
                foreach (var item in FullyQualifiedDomainNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EmailAddresses))
            {
                writer.WritePropertyName("emailAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in EmailAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PhoneNumbers))
            {
                writer.WritePropertyName("phoneNumbers"u8);
                writer.WriteStartArray();
                foreach (var item in PhoneNumbers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        NetworkSecurityPerimeterProfileAccessRule IJsonModel<NetworkSecurityPerimeterProfileAccessRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterProfileAccessRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterProfileAccessRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkSecurityPerimeterProfileAccessRule(document.RootElement, options);
        }

        internal static NetworkSecurityPerimeterProfileAccessRule DeserializeNetworkSecurityPerimeterProfileAccessRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fullyQualifiedArmId = default;
            string name = default;
            string type = default;
            NetworkSecurityPerimeterProfileAccessRuleDirection? direction = default;
            IList<string> addressPrefixes = default;
            IList<string> subscriptions = default;
            IList<NetworkSecurityPerimeterInfo> networkSecurityPerimeters = default;
            IList<string> fullyQualifiedDomainNames = default;
            IList<string> emailAddresses = default;
            IList<string> phoneNumbers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fullyQualifiedArmId"u8))
                {
                    fullyQualifiedArmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("direction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            direction = new NetworkSecurityPerimeterProfileAccessRuleDirection(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("addressPrefixes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            addressPrefixes = array;
                            continue;
                        }
                        if (property0.NameEquals("subscriptions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            subscriptions = array;
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityPerimeters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkSecurityPerimeterInfo> array = new List<NetworkSecurityPerimeterInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkSecurityPerimeterInfo.DeserializeNetworkSecurityPerimeterInfo(item, options));
                            }
                            networkSecurityPerimeters = array;
                            continue;
                        }
                        if (property0.NameEquals("fullyQualifiedDomainNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            fullyQualifiedDomainNames = array;
                            continue;
                        }
                        if (property0.NameEquals("emailAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            emailAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("phoneNumbers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            phoneNumbers = array;
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
            return new NetworkSecurityPerimeterProfileAccessRule(
                fullyQualifiedArmId,
                name,
                type,
                direction,
                addressPrefixes ?? new ChangeTrackingList<string>(),
                subscriptions ?? new ChangeTrackingList<string>(),
                networkSecurityPerimeters ?? new ChangeTrackingList<NetworkSecurityPerimeterInfo>(),
                fullyQualifiedDomainNames ?? new ChangeTrackingList<string>(),
                emailAddresses ?? new ChangeTrackingList<string>(),
                phoneNumbers ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkSecurityPerimeterProfileAccessRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterProfileAccessRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterProfileAccessRule)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkSecurityPerimeterProfileAccessRule IPersistableModel<NetworkSecurityPerimeterProfileAccessRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterProfileAccessRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkSecurityPerimeterProfileAccessRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterProfileAccessRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkSecurityPerimeterProfileAccessRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
