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

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciDeploymentCluster : IUtf8JsonSerializable, IJsonModel<HciDeploymentCluster>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HciDeploymentCluster>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HciDeploymentCluster>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciDeploymentCluster>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciDeploymentCluster)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(WitnessType))
            {
                writer.WritePropertyName("witnessType"u8);
                writer.WriteStringValue(WitnessType);
            }
            if (Optional.IsDefined(WitnessPath))
            {
                writer.WritePropertyName("witnessPath"u8);
                writer.WriteStringValue(WitnessPath);
            }
            if (Optional.IsDefined(CloudAccountName))
            {
                writer.WritePropertyName("cloudAccountName"u8);
                writer.WriteStringValue(CloudAccountName);
            }
            if (Optional.IsDefined(AzureServiceEndpoint))
            {
                writer.WritePropertyName("azureServiceEndpoint"u8);
                writer.WriteStringValue(AzureServiceEndpoint);
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

        HciDeploymentCluster IJsonModel<HciDeploymentCluster>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciDeploymentCluster>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciDeploymentCluster)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHciDeploymentCluster(document.RootElement, options);
        }

        internal static HciDeploymentCluster DeserializeHciDeploymentCluster(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string witnessType = default;
            string witnessPath = default;
            string cloudAccountName = default;
            string azureServiceEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("witnessType"u8))
                {
                    witnessType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("witnessPath"u8))
                {
                    witnessPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloudAccountName"u8))
                {
                    cloudAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureServiceEndpoint"u8))
                {
                    azureServiceEndpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HciDeploymentCluster(
                name,
                witnessType,
                witnessPath,
                cloudAccountName,
                azureServiceEndpoint,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WitnessType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  witnessType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WitnessType))
                {
                    builder.Append("  witnessType: ");
                    if (WitnessType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{WitnessType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{WitnessType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WitnessPath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  witnessPath: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WitnessPath))
                {
                    builder.Append("  witnessPath: ");
                    if (WitnessPath.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{WitnessPath}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{WitnessPath}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CloudAccountName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  cloudAccountName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CloudAccountName))
                {
                    builder.Append("  cloudAccountName: ");
                    if (CloudAccountName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CloudAccountName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CloudAccountName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureServiceEndpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  azureServiceEndpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AzureServiceEndpoint))
                {
                    builder.Append("  azureServiceEndpoint: ");
                    if (AzureServiceEndpoint.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AzureServiceEndpoint}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AzureServiceEndpoint}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<HciDeploymentCluster>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciDeploymentCluster>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HciDeploymentCluster)} does not support writing '{options.Format}' format.");
            }
        }

        HciDeploymentCluster IPersistableModel<HciDeploymentCluster>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciDeploymentCluster>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHciDeploymentCluster(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HciDeploymentCluster)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HciDeploymentCluster>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
