// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderCspmAwsOfferingDataSensitivityDiscovery : IUtf8JsonSerializable, IJsonModel<DefenderCspmAwsOfferingDataSensitivityDiscovery>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderCspmAwsOfferingDataSensitivityDiscovery>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DefenderCspmAwsOfferingDataSensitivityDiscovery>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingDataSensitivityDiscovery>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingDataSensitivityDiscovery)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(CloudRoleArn))
            {
                writer.WritePropertyName("cloudRoleArn"u8);
                writer.WriteStringValue(CloudRoleArn);
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

        DefenderCspmAwsOfferingDataSensitivityDiscovery IJsonModel<DefenderCspmAwsOfferingDataSensitivityDiscovery>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingDataSensitivityDiscovery>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingDataSensitivityDiscovery)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderCspmAwsOfferingDataSensitivityDiscovery(document.RootElement, options);
        }

        internal static DefenderCspmAwsOfferingDataSensitivityDiscovery DeserializeDefenderCspmAwsOfferingDataSensitivityDiscovery(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            string cloudRoleArn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloudRoleArn"u8))
                {
                    cloudRoleArn = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DefenderCspmAwsOfferingDataSensitivityDiscovery(enabled, cloudRoleArn, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderCspmAwsOfferingDataSensitivityDiscovery>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingDataSensitivityDiscovery>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingDataSensitivityDiscovery)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderCspmAwsOfferingDataSensitivityDiscovery IPersistableModel<DefenderCspmAwsOfferingDataSensitivityDiscovery>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingDataSensitivityDiscovery>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderCspmAwsOfferingDataSensitivityDiscovery(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingDataSensitivityDiscovery)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderCspmAwsOfferingDataSensitivityDiscovery>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
