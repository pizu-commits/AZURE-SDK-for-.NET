// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppIdentityProvidersConfiguration : IUtf8JsonSerializable, IJsonModel<ContainerAppIdentityProvidersConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppIdentityProvidersConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppIdentityProvidersConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppIdentityProvidersConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppIdentityProvidersConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AzureActiveDirectory))
            {
                writer.WritePropertyName("azureActiveDirectory"u8);
                writer.WriteObjectValue(AzureActiveDirectory);
            }
            if (Optional.IsDefined(Facebook))
            {
                writer.WritePropertyName("facebook"u8);
                writer.WriteObjectValue(Facebook);
            }
            if (Optional.IsDefined(GitHub))
            {
                writer.WritePropertyName("gitHub"u8);
                writer.WriteObjectValue(GitHub);
            }
            if (Optional.IsDefined(Google))
            {
                writer.WritePropertyName("google"u8);
                writer.WriteObjectValue(Google);
            }
            if (Optional.IsDefined(Twitter))
            {
                writer.WritePropertyName("twitter"u8);
                writer.WriteObjectValue(Twitter);
            }
            if (Optional.IsDefined(Apple))
            {
                writer.WritePropertyName("apple"u8);
                writer.WriteObjectValue(Apple);
            }
            if (Optional.IsDefined(AzureStaticWebApps))
            {
                writer.WritePropertyName("azureStaticWebApps"u8);
                writer.WriteObjectValue(AzureStaticWebApps);
            }
            if (!(CustomOpenIdConnectProviders is ChangeTrackingDictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("customOpenIdConnectProviders"u8);
                writer.WriteStartObject();
                foreach (var item in CustomOpenIdConnectProviders)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        ContainerAppIdentityProvidersConfiguration IJsonModel<ContainerAppIdentityProvidersConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppIdentityProvidersConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppIdentityProvidersConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppIdentityProvidersConfiguration(document.RootElement, options);
        }

        internal static ContainerAppIdentityProvidersConfiguration DeserializeContainerAppIdentityProvidersConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerAppAzureActiveDirectoryConfiguration> azureActiveDirectory = default;
            Optional<ContainerAppFacebookConfiguration> facebook = default;
            Optional<ContainerAppGitHubConfiguration> gitHub = default;
            Optional<ContainerAppGoogleConfiguration> google = default;
            Optional<ContainerAppTwitterConfiguration> twitter = default;
            Optional<ContainerAppAppleConfiguration> apple = default;
            Optional<ContainerAppAzureStaticWebAppsConfiguration> azureStaticWebApps = default;
            Optional<IDictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration>> customOpenIdConnectProviders = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureActiveDirectory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureActiveDirectory = ContainerAppAzureActiveDirectoryConfiguration.DeserializeContainerAppAzureActiveDirectoryConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("facebook"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    facebook = ContainerAppFacebookConfiguration.DeserializeContainerAppFacebookConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("gitHub"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gitHub = ContainerAppGitHubConfiguration.DeserializeContainerAppGitHubConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("google"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    google = ContainerAppGoogleConfiguration.DeserializeContainerAppGoogleConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("twitter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    twitter = ContainerAppTwitterConfiguration.DeserializeContainerAppTwitterConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("apple"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apple = ContainerAppAppleConfiguration.DeserializeContainerAppAppleConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("azureStaticWebApps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStaticWebApps = ContainerAppAzureStaticWebAppsConfiguration.DeserializeContainerAppAzureStaticWebAppsConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("customOpenIdConnectProviders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration> dictionary = new Dictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ContainerAppCustomOpenIdConnectProviderConfiguration.DeserializeContainerAppCustomOpenIdConnectProviderConfiguration(property0.Value, options));
                    }
                    customOpenIdConnectProviders = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppIdentityProvidersConfiguration(azureActiveDirectory.Value, facebook.Value, gitHub.Value, google.Value, twitter.Value, apple.Value, azureStaticWebApps.Value, Optional.ToDictionary(customOpenIdConnectProviders), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppIdentityProvidersConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppIdentityProvidersConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppIdentityProvidersConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppIdentityProvidersConfiguration IPersistableModel<ContainerAppIdentityProvidersConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppIdentityProvidersConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppIdentityProvidersConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppIdentityProvidersConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppIdentityProvidersConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
