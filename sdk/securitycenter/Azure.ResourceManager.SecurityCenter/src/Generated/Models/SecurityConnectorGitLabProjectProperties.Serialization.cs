// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityConnectorGitLabProjectProperties : IUtf8JsonSerializable, IJsonModel<SecurityConnectorGitLabProjectProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityConnectorGitLabProjectProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityConnectorGitLabProjectProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorGitLabProjectProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityConnectorGitLabProjectProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningStatusMessage))
            {
                writer.WritePropertyName("provisioningStatusMessage"u8);
                writer.WriteStringValue(ProvisioningStatusMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningStatusUpdateTimeUtc))
            {
                writer.WritePropertyName("provisioningStatusUpdateTimeUtc"u8);
                writer.WriteStringValue(ProvisioningStatusUpdateTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(FullyQualifiedName))
            {
                writer.WritePropertyName("fullyQualifiedName"u8);
                writer.WriteStringValue(FullyQualifiedName);
            }
            if (options.Format != "W" && Optional.IsDefined(FullyQualifiedFriendlyName))
            {
                writer.WritePropertyName("fullyQualifiedFriendlyName"u8);
                writer.WriteStringValue(FullyQualifiedFriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(FullyQualifiedParentGroupName))
            {
                writer.WritePropertyName("fullyQualifiedParentGroupName"u8);
                writer.WriteStringValue(FullyQualifiedParentGroupName);
            }
            if (options.Format != "W" && Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(OnboardingState))
            {
                writer.WritePropertyName("onboardingState"u8);
                writer.WriteStringValue(OnboardingState.Value.ToString());
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

        SecurityConnectorGitLabProjectProperties IJsonModel<SecurityConnectorGitLabProjectProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorGitLabProjectProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityConnectorGitLabProjectProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityConnectorGitLabProjectProperties(document.RootElement, options);
        }

        internal static SecurityConnectorGitLabProjectProperties DeserializeSecurityConnectorGitLabProjectProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string provisioningStatusMessage = default;
            DateTimeOffset? provisioningStatusUpdateTimeUtc = default;
            DevOpsProvisioningState? provisioningState = default;
            string fullyQualifiedName = default;
            string fullyQualifiedFriendlyName = default;
            string fullyQualifiedParentGroupName = default;
            Uri url = default;
            ResourceOnboardingState? onboardingState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (property.NameEquals("fullyQualifiedName"u8))
                {
                    fullyQualifiedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fullyQualifiedFriendlyName"u8))
                {
                    fullyQualifiedFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fullyQualifiedParentGroupName"u8))
                {
                    fullyQualifiedParentGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityConnectorGitLabProjectProperties(
                provisioningStatusMessage,
                provisioningStatusUpdateTimeUtc,
                provisioningState,
                fullyQualifiedName,
                fullyQualifiedFriendlyName,
                fullyQualifiedParentGroupName,
                url,
                onboardingState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityConnectorGitLabProjectProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorGitLabProjectProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityConnectorGitLabProjectProperties)} does not support '{options.Format}' format.");
            }
        }

        SecurityConnectorGitLabProjectProperties IPersistableModel<SecurityConnectorGitLabProjectProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorGitLabProjectProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityConnectorGitLabProjectProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityConnectorGitLabProjectProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityConnectorGitLabProjectProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
