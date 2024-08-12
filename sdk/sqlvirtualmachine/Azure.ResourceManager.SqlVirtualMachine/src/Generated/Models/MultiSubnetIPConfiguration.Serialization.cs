// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class MultiSubnetIPConfiguration : IUtf8JsonSerializable, IJsonModel<MultiSubnetIPConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MultiSubnetIPConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MultiSubnetIPConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultiSubnetIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MultiSubnetIPConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("privateIpAddress"u8);
            writer.WriteObjectValue(PrivateIPAddress, options);
            writer.WritePropertyName("sqlVirtualMachineInstance"u8);
            writer.WriteStringValue(SqlVmInstance);
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

        MultiSubnetIPConfiguration IJsonModel<MultiSubnetIPConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultiSubnetIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MultiSubnetIPConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMultiSubnetIPConfiguration(document.RootElement, options);
        }

        internal static MultiSubnetIPConfiguration DeserializeMultiSubnetIPConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AvailabilityGroupListenerPrivateIPAddress privateIPAddress = default;
            string sqlVmInstance = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateIpAddress"u8))
                {
                    privateIPAddress = AvailabilityGroupListenerPrivateIPAddress.DeserializeAvailabilityGroupListenerPrivateIPAddress(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sqlVirtualMachineInstance"u8))
                {
                    sqlVmInstance = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MultiSubnetIPConfiguration(privateIPAddress, sqlVmInstance, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MultiSubnetIPConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultiSubnetIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MultiSubnetIPConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        MultiSubnetIPConfiguration IPersistableModel<MultiSubnetIPConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultiSubnetIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMultiSubnetIPConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MultiSubnetIPConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MultiSubnetIPConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
