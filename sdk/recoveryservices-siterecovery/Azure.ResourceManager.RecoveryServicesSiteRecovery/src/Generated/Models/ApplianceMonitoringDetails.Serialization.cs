// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ApplianceMonitoringDetails : IUtf8JsonSerializable, IJsonModel<ApplianceMonitoringDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplianceMonitoringDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplianceMonitoringDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplianceMonitoringDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplianceMonitoringDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CpuDetails))
            {
                writer.WritePropertyName("cpuDetails"u8);
                writer.WriteObjectValue(CpuDetails, options);
            }
            if (options.Format != "W" && Optional.IsDefined(RamDetails))
            {
                writer.WritePropertyName("ramDetails"u8);
                writer.WriteObjectValue(RamDetails, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DatastoreSnapshot))
            {
                writer.WritePropertyName("datastoreSnapshot"u8);
                writer.WriteStartArray();
                foreach (var item in DatastoreSnapshot)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(DisksReplicationDetails))
            {
                writer.WritePropertyName("disksReplicationDetails"u8);
                writer.WriteObjectValue(DisksReplicationDetails, options);
            }
            if (options.Format != "W" && Optional.IsDefined(EsxiNfcBuffer))
            {
                writer.WritePropertyName("esxiNfcBuffer"u8);
                writer.WriteObjectValue(EsxiNfcBuffer, options);
            }
            if (options.Format != "W" && Optional.IsDefined(NetworkBandwidth))
            {
                writer.WritePropertyName("networkBandwidth"u8);
                writer.WriteObjectValue(NetworkBandwidth, options);
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

        ApplianceMonitoringDetails IJsonModel<ApplianceMonitoringDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplianceMonitoringDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplianceMonitoringDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplianceMonitoringDetails(document.RootElement, options);
        }

        internal static ApplianceMonitoringDetails DeserializeApplianceMonitoringDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ApplianceResourceDetails cpuDetails = default;
            ApplianceResourceDetails ramDetails = default;
            IReadOnlyList<DataStoreUtilizationDetails> datastoreSnapshot = default;
            ApplianceResourceDetails disksReplicationDetails = default;
            ApplianceResourceDetails esxiNfcBuffer = default;
            ApplianceResourceDetails networkBandwidth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpuDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuDetails = ApplianceResourceDetails.DeserializeApplianceResourceDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ramDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ramDetails = ApplianceResourceDetails.DeserializeApplianceResourceDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("datastoreSnapshot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataStoreUtilizationDetails> array = new List<DataStoreUtilizationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataStoreUtilizationDetails.DeserializeDataStoreUtilizationDetails(item, options));
                    }
                    datastoreSnapshot = array;
                    continue;
                }
                if (property.NameEquals("disksReplicationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disksReplicationDetails = ApplianceResourceDetails.DeserializeApplianceResourceDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("esxiNfcBuffer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    esxiNfcBuffer = ApplianceResourceDetails.DeserializeApplianceResourceDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("networkBandwidth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkBandwidth = ApplianceResourceDetails.DeserializeApplianceResourceDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplianceMonitoringDetails(
                cpuDetails,
                ramDetails,
                datastoreSnapshot ?? new ChangeTrackingList<DataStoreUtilizationDetails>(),
                disksReplicationDetails,
                esxiNfcBuffer,
                networkBandwidth,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplianceMonitoringDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplianceMonitoringDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplianceMonitoringDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ApplianceMonitoringDetails IPersistableModel<ApplianceMonitoringDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplianceMonitoringDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplianceMonitoringDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplianceMonitoringDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplianceMonitoringDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
