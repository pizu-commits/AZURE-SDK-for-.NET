// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxSecret : IUtf8JsonSerializable, IJsonModel<DataBoxSecret>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxSecret>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxSecret>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxSecret>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxSecret)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DeviceSerialNumber))
            {
                writer.WritePropertyName("deviceSerialNumber"u8);
                writer.WriteStringValue(DeviceSerialNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(DevicePassword))
            {
                writer.WritePropertyName("devicePassword"u8);
                writer.WriteStringValue(DevicePassword);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(NetworkConfigurations))
            {
                writer.WritePropertyName("networkConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(EncodedValidationCertPubKey))
            {
                writer.WritePropertyName("encodedValidationCertPubKey"u8);
                writer.WriteStringValue(EncodedValidationCertPubKey);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AccountCredentialDetails))
            {
                writer.WritePropertyName("accountCredentialDetails"u8);
                writer.WriteStartArray();
                foreach (var item in AccountCredentialDetails)
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

        DataBoxSecret IJsonModel<DataBoxSecret>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxSecret>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxSecret)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxSecret(document.RootElement, options);
        }

        internal static DataBoxSecret DeserializeDataBoxSecret(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deviceSerialNumber = default;
            Optional<string> devicePassword = default;
            Optional<IReadOnlyList<ApplianceNetworkConfiguration>> networkConfigurations = default;
            Optional<string> encodedValidationCertPubKey = default;
            Optional<IReadOnlyList<DataBoxAccountCredentialDetails>> accountCredentialDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceSerialNumber"u8))
                {
                    deviceSerialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("devicePassword"u8))
                {
                    devicePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplianceNetworkConfiguration> array = new List<ApplianceNetworkConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplianceNetworkConfiguration.DeserializeApplianceNetworkConfiguration(item, options));
                    }
                    networkConfigurations = array;
                    continue;
                }
                if (property.NameEquals("encodedValidationCertPubKey"u8))
                {
                    encodedValidationCertPubKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountCredentialDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxAccountCredentialDetails> array = new List<DataBoxAccountCredentialDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxAccountCredentialDetails.DeserializeDataBoxAccountCredentialDetails(item, options));
                    }
                    accountCredentialDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxSecret(deviceSerialNumber.Value, devicePassword.Value, Optional.ToList(networkConfigurations), encodedValidationCertPubKey.Value, Optional.ToList(accountCredentialDetails), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxSecret>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxSecret>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxSecret)} does not support '{options.Format}' format.");
            }
        }

        DataBoxSecret IPersistableModel<DataBoxSecret>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxSecret>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxSecret(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxSecret)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxSecret>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
