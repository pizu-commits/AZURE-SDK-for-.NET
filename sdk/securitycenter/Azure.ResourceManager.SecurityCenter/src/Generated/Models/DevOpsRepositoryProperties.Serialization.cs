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
    public partial class DevOpsRepositoryProperties : IUtf8JsonSerializable, IJsonModel<DevOpsRepositoryProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevOpsRepositoryProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevOpsRepositoryProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsRepositoryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsRepositoryProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningStatusMessage))
            {
                writer.WritePropertyName("provisioningStatusMessage"u8);
                writer.WriteStringValue(ProvisioningStatusMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningStatusUpdatedOn))
            {
                writer.WritePropertyName("provisioningStatusUpdateTimeUtc"u8);
                writer.WriteStringValue(ProvisioningStatusUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ParentOrgName))
            {
                writer.WritePropertyName("parentOrgName"u8);
                writer.WriteStringValue(ParentOrgName);
            }
            if (Optional.IsDefined(ParentProjectName))
            {
                writer.WritePropertyName("parentProjectName"u8);
                writer.WriteStringValue(ParentProjectName);
            }
            if (options.Format != "W" && Optional.IsDefined(RepoId))
            {
                writer.WritePropertyName("repoId"u8);
                writer.WriteStringValue(RepoId);
            }
            if (options.Format != "W" && Optional.IsDefined(RepoUri))
            {
                writer.WritePropertyName("repoUrl"u8);
                writer.WriteStringValue(RepoUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(Visibility))
            {
                writer.WritePropertyName("visibility"u8);
                writer.WriteStringValue(Visibility);
            }
            if (Optional.IsDefined(OnboardingState))
            {
                writer.WritePropertyName("onboardingState"u8);
                writer.WriteStringValue(OnboardingState.Value.ToString());
            }
            if (Optional.IsDefined(ActionableRemediation))
            {
                writer.WritePropertyName("actionableRemediation"u8);
                writer.WriteObjectValue(ActionableRemediation, options);
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

        DevOpsRepositoryProperties IJsonModel<DevOpsRepositoryProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsRepositoryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsRepositoryProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevOpsRepositoryProperties(document.RootElement, options);
        }

        internal static DevOpsRepositoryProperties DeserializeDevOpsRepositoryProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string provisioningStatusMessage = default;
            DateTimeOffset? provisioningStatusUpdateTimeUtc = default;
            DevOpsProvisioningState? provisioningState = default;
            string parentOrgName = default;
            string parentProjectName = default;
            string repoId = default;
            Uri repoUrl = default;
            string visibility = default;
            ResourceOnboardingState? onboardingState = default;
            ActionableRemediation actionableRemediation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningStatusMessage"u8))
                {
                    provisioningStatusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatusUpdateTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatusUpdateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DevOpsProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parentOrgName"u8))
                {
                    parentOrgName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parentProjectName"u8))
                {
                    parentProjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repoId"u8))
                {
                    repoId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repoUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    repoUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("visibility"u8))
                {
                    visibility = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("onboardingState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onboardingState = new ResourceOnboardingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("actionableRemediation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionableRemediation = ActionableRemediation.DeserializeActionableRemediation(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevOpsRepositoryProperties(
                provisioningStatusMessage,
                provisioningStatusUpdateTimeUtc,
                provisioningState,
                parentOrgName,
                parentProjectName,
                repoId,
                repoUrl,
                visibility,
                onboardingState,
                actionableRemediation,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevOpsRepositoryProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsRepositoryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevOpsRepositoryProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DevOpsRepositoryProperties IPersistableModel<DevOpsRepositoryProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsRepositoryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevOpsRepositoryProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevOpsRepositoryProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevOpsRepositoryProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
