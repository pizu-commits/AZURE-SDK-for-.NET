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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SourceControlDeployment : IUtf8JsonSerializable, IJsonModel<SourceControlDeployment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SourceControlDeployment>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SourceControlDeployment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlDeployment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceControlDeployment)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DeploymentId))
            {
                writer.WritePropertyName("deploymentId"u8);
                writer.WriteStringValue(DeploymentId);
            }
            if (Optional.IsDefined(DeploymentState))
            {
                writer.WritePropertyName("deploymentState"u8);
                writer.WriteStringValue(DeploymentState.Value.ToString());
            }
            if (Optional.IsDefined(DeploymentResult))
            {
                writer.WritePropertyName("deploymentResult"u8);
                writer.WriteStringValue(DeploymentResult.Value.ToString());
            }
            if (Optional.IsDefined(DeploymentOn))
            {
                writer.WritePropertyName("deploymentTime"u8);
                writer.WriteStringValue(DeploymentOn.Value, "O");
            }
            if (Optional.IsDefined(DeploymentLogsUri))
            {
                writer.WritePropertyName("deploymentLogsUrl"u8);
                writer.WriteStringValue(DeploymentLogsUri.AbsoluteUri);
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

        SourceControlDeployment IJsonModel<SourceControlDeployment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlDeployment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceControlDeployment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceControlDeployment(document.RootElement, options);
        }

        internal static SourceControlDeployment DeserializeSourceControlDeployment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string deploymentId = default;
            SourceControlDeploymentState? deploymentState = default;
            SourceControlDeploymentResult? deploymentResult = default;
            DateTimeOffset? deploymentTime = default;
            Uri deploymentLogsUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentId"u8))
                {
                    deploymentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentState = new SourceControlDeploymentState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deploymentResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentResult = new SourceControlDeploymentResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deploymentTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("deploymentLogsUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentLogsUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SourceControlDeployment(
                deploymentId,
                deploymentState,
                deploymentResult,
                deploymentTime,
                deploymentLogsUrl,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeploymentId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  deploymentId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeploymentId))
                {
                    builder.Append("  deploymentId: ");
                    if (DeploymentId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DeploymentId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DeploymentId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeploymentState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  deploymentState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeploymentState))
                {
                    builder.Append("  deploymentState: ");
                    builder.AppendLine($"'{DeploymentState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeploymentResult), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  deploymentResult: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeploymentResult))
                {
                    builder.Append("  deploymentResult: ");
                    builder.AppendLine($"'{DeploymentResult.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeploymentOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  deploymentTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeploymentOn))
                {
                    builder.Append("  deploymentTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(DeploymentOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeploymentLogsUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  deploymentLogsUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeploymentLogsUri))
                {
                    builder.Append("  deploymentLogsUrl: ");
                    builder.AppendLine($"'{DeploymentLogsUri.AbsoluteUri}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SourceControlDeployment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlDeployment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SourceControlDeployment)} does not support writing '{options.Format}' format.");
            }
        }

        SourceControlDeployment IPersistableModel<SourceControlDeployment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlDeployment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSourceControlDeployment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SourceControlDeployment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SourceControlDeployment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
