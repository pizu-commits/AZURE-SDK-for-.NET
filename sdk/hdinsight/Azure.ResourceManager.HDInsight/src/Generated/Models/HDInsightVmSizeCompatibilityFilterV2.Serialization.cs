// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightVmSizeCompatibilityFilterV2 : IUtf8JsonSerializable, IJsonModel<HDInsightVmSizeCompatibilityFilterV2>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightVmSizeCompatibilityFilterV2>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightVmSizeCompatibilityFilterV2>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightVmSizeCompatibilityFilterV2>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightVmSizeCompatibilityFilterV2)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FilterMode))
            {
                writer.WritePropertyName("filterMode"u8);
                writer.WriteStringValue(FilterMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Regions))
            {
                writer.WritePropertyName("regions"u8);
                writer.WriteStartArray();
                foreach (var item in Regions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ClusterFlavors))
            {
                writer.WritePropertyName("clusterFlavors"u8);
                writer.WriteStartArray();
                foreach (var item in ClusterFlavors)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NodeTypes))
            {
                writer.WritePropertyName("nodeTypes"u8);
                writer.WriteStartArray();
                foreach (var item in NodeTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ClusterVersions))
            {
                writer.WritePropertyName("clusterVersions"u8);
                writer.WriteStartArray();
                foreach (var item in ClusterVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStartArray();
                foreach (var item in OSType)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VmSizes))
            {
                writer.WritePropertyName("vmSizes"u8);
                writer.WriteStartArray();
                foreach (var item in VmSizes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EspApplied))
            {
                writer.WritePropertyName("espApplied"u8);
                writer.WriteStringValue(EspApplied);
            }
            if (Optional.IsDefined(IsComputeIsolationSupported))
            {
                writer.WritePropertyName("computeIsolationSupported"u8);
                writer.WriteStringValue(IsComputeIsolationSupported);
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

        HDInsightVmSizeCompatibilityFilterV2 IJsonModel<HDInsightVmSizeCompatibilityFilterV2>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightVmSizeCompatibilityFilterV2>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightVmSizeCompatibilityFilterV2)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightVmSizeCompatibilityFilterV2(document.RootElement, options);
        }

        internal static HDInsightVmSizeCompatibilityFilterV2 DeserializeHDInsightVmSizeCompatibilityFilterV2(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HDInsightFilterMode? filterMode = default;
            IReadOnlyList<string> regions = default;
            IReadOnlyList<string> clusterFlavors = default;
            IReadOnlyList<string> nodeTypes = default;
            IReadOnlyList<string> clusterVersions = default;
            IReadOnlyList<HDInsightOSType> osType = default;
            IReadOnlyList<string> vmSizes = default;
            string espApplied = default;
            string computeIsolationSupported = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filterMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filterMode = new HDInsightFilterMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("regions"u8))
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
                    regions = array;
                    continue;
                }
                if (property.NameEquals("clusterFlavors"u8))
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
                    clusterFlavors = array;
                    continue;
                }
                if (property.NameEquals("nodeTypes"u8))
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
                    nodeTypes = array;
                    continue;
                }
                if (property.NameEquals("clusterVersions"u8))
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
                    clusterVersions = array;
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightOSType> array = new List<HDInsightOSType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new HDInsightOSType(item.GetString()));
                    }
                    osType = array;
                    continue;
                }
                if (property.NameEquals("vmSizes"u8))
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
                    vmSizes = array;
                    continue;
                }
                if (property.NameEquals("espApplied"u8))
                {
                    espApplied = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("computeIsolationSupported"u8))
                {
                    computeIsolationSupported = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightVmSizeCompatibilityFilterV2(
                filterMode,
                regions ?? new ChangeTrackingList<string>(),
                clusterFlavors ?? new ChangeTrackingList<string>(),
                nodeTypes ?? new ChangeTrackingList<string>(),
                clusterVersions ?? new ChangeTrackingList<string>(),
                osType ?? new ChangeTrackingList<HDInsightOSType>(),
                vmSizes ?? new ChangeTrackingList<string>(),
                espApplied,
                computeIsolationSupported,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightVmSizeCompatibilityFilterV2>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightVmSizeCompatibilityFilterV2>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightVmSizeCompatibilityFilterV2)} does not support '{options.Format}' format.");
            }
        }

        HDInsightVmSizeCompatibilityFilterV2 IPersistableModel<HDInsightVmSizeCompatibilityFilterV2>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightVmSizeCompatibilityFilterV2>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightVmSizeCompatibilityFilterV2(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightVmSizeCompatibilityFilterV2)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightVmSizeCompatibilityFilterV2>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
