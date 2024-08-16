// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterPoolAvailableUpgradeNodeOSUpgradeProperties : IUtf8JsonSerializable, IJsonModel<ClusterPoolAvailableUpgradeNodeOSUpgradeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterPoolAvailableUpgradeNodeOSUpgradeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterPoolAvailableUpgradeNodeOSUpgradeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolAvailableUpgradeNodeOSUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPoolAvailableUpgradeNodeOSUpgradeProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LatestVersion))
            {
                writer.WritePropertyName("latestVersion"u8);
                writer.WriteStringValue(LatestVersion);
            }
            writer.WritePropertyName("upgradeType"u8);
            writer.WriteStringValue(UpgradeType.ToString());
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

        ClusterPoolAvailableUpgradeNodeOSUpgradeProperties IJsonModel<ClusterPoolAvailableUpgradeNodeOSUpgradeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolAvailableUpgradeNodeOSUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPoolAvailableUpgradeNodeOSUpgradeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterPoolAvailableUpgradeNodeOSUpgradeProperties(document.RootElement, options);
        }

        internal static ClusterPoolAvailableUpgradeNodeOSUpgradeProperties DeserializeClusterPoolAvailableUpgradeNodeOSUpgradeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string latestVersion = default;
            ClusterPoolAvailableUpgradeType upgradeType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("latestVersion"u8))
                {
                    latestVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeType"u8))
                {
                    upgradeType = new ClusterPoolAvailableUpgradeType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterPoolAvailableUpgradeNodeOSUpgradeProperties(upgradeType, serializedAdditionalRawData, latestVersion);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LatestVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  latestVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LatestVersion))
                {
                    builder.Append("  latestVersion: ");
                    if (LatestVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LatestVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LatestVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpgradeType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  upgradeType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  upgradeType: ");
                builder.AppendLine($"'{UpgradeType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ClusterPoolAvailableUpgradeNodeOSUpgradeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolAvailableUpgradeNodeOSUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ClusterPoolAvailableUpgradeNodeOSUpgradeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterPoolAvailableUpgradeNodeOSUpgradeProperties IPersistableModel<ClusterPoolAvailableUpgradeNodeOSUpgradeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolAvailableUpgradeNodeOSUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterPoolAvailableUpgradeNodeOSUpgradeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterPoolAvailableUpgradeNodeOSUpgradeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterPoolAvailableUpgradeNodeOSUpgradeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
