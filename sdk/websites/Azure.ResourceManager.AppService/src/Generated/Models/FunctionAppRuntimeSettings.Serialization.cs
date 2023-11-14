// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class FunctionAppRuntimeSettings : IUtf8JsonSerializable, IJsonModel<FunctionAppRuntimeSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FunctionAppRuntimeSettings>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<FunctionAppRuntimeSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<FunctionAppRuntimeSettings>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<FunctionAppRuntimeSettings>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(RuntimeVersion))
                {
                    writer.WritePropertyName("runtimeVersion"u8);
                    writer.WriteStringValue(RuntimeVersion);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsRemoteDebuggingSupported))
                {
                    writer.WritePropertyName("remoteDebuggingSupported"u8);
                    writer.WriteBooleanValue(IsRemoteDebuggingSupported.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(AppInsightsSettings))
                {
                    writer.WritePropertyName("appInsightsSettings"u8);
                    writer.WriteObjectValue(AppInsightsSettings);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(GitHubActionSettings))
                {
                    writer.WritePropertyName("gitHubActionSettings"u8);
                    writer.WriteObjectValue(GitHubActionSettings);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(AppSettingsDictionary))
                {
                    writer.WritePropertyName("appSettingsDictionary"u8);
                    writer.WriteStartObject();
                    foreach (var item in AppSettingsDictionary)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SiteConfigPropertiesDictionary))
                {
                    writer.WritePropertyName("siteConfigPropertiesDictionary"u8);
                    writer.WriteObjectValue(SiteConfigPropertiesDictionary);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(SupportedFunctionsExtensionVersions))
                {
                    writer.WritePropertyName("supportedFunctionsExtensionVersions"u8);
                    writer.WriteStartArray();
                    foreach (var item in SupportedFunctionsExtensionVersions)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsPreview))
                {
                    writer.WritePropertyName("isPreview"u8);
                    writer.WriteBooleanValue(IsPreview.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsDeprecated))
                {
                    writer.WritePropertyName("isDeprecated"u8);
                    writer.WriteBooleanValue(IsDeprecated.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsHidden))
                {
                    writer.WritePropertyName("isHidden"u8);
                    writer.WriteBooleanValue(IsHidden.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(EndOfLifeOn))
                {
                    writer.WritePropertyName("endOfLifeDate"u8);
                    writer.WriteStringValue(EndOfLifeOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsAutoUpdate))
                {
                    writer.WritePropertyName("isAutoUpdate"u8);
                    writer.WriteBooleanValue(IsAutoUpdate.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsEarlyAccess))
                {
                    writer.WritePropertyName("isEarlyAccess"u8);
                    writer.WriteBooleanValue(IsEarlyAccess.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsDefault))
                {
                    writer.WritePropertyName("isDefault"u8);
                    writer.WriteBooleanValue(IsDefault.Value);
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        FunctionAppRuntimeSettings IJsonModel<FunctionAppRuntimeSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FunctionAppRuntimeSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionAppRuntimeSettings(document.RootElement, options);
        }

        internal static FunctionAppRuntimeSettings DeserializeFunctionAppRuntimeSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> runtimeVersion = default;
            Optional<bool> remoteDebuggingSupported = default;
            Optional<AppInsightsWebAppStackSettings> appInsightsSettings = default;
            Optional<GitHubActionWebAppStackSettings> gitHubActionSettings = default;
            Optional<IReadOnlyDictionary<string, string>> appSettingsDictionary = default;
            Optional<SiteConfigPropertiesDictionary> siteConfigPropertiesDictionary = default;
            Optional<IReadOnlyList<string>> supportedFunctionsExtensionVersions = default;
            Optional<bool> isPreview = default;
            Optional<bool> isDeprecated = default;
            Optional<bool> isHidden = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<bool> isAutoUpdate = default;
            Optional<bool> isEarlyAccess = default;
            Optional<bool> isDefault = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteDebuggingSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remoteDebuggingSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appInsightsSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appInsightsSettings = AppInsightsWebAppStackSettings.DeserializeAppInsightsWebAppStackSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("gitHubActionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gitHubActionSettings = GitHubActionWebAppStackSettings.DeserializeGitHubActionWebAppStackSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("appSettingsDictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    appSettingsDictionary = dictionary;
                    continue;
                }
                if (property.NameEquals("siteConfigPropertiesDictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    siteConfigPropertiesDictionary = SiteConfigPropertiesDictionary.DeserializeSiteConfigPropertiesDictionary(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedFunctionsExtensionVersions"u8))
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
                    supportedFunctionsExtensionVersions = array;
                    continue;
                }
                if (property.NameEquals("isPreview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDeprecated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeprecated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isHidden"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("endOfLifeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endOfLifeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isAutoUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoUpdate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEarlyAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEarlyAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FunctionAppRuntimeSettings(runtimeVersion.Value, Optional.ToNullable(remoteDebuggingSupported), appInsightsSettings.Value, gitHubActionSettings.Value, Optional.ToDictionary(appSettingsDictionary), siteConfigPropertiesDictionary.Value, Optional.ToList(supportedFunctionsExtensionVersions), Optional.ToNullable(isPreview), Optional.ToNullable(isDeprecated), Optional.ToNullable(isHidden), Optional.ToNullable(endOfLifeDate), Optional.ToNullable(isAutoUpdate), Optional.ToNullable(isEarlyAccess), Optional.ToNullable(isDefault), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FunctionAppRuntimeSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FunctionAppRuntimeSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FunctionAppRuntimeSettings IPersistableModel<FunctionAppRuntimeSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FunctionAppRuntimeSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFunctionAppRuntimeSettings(document.RootElement, options);
        }

        string IPersistableModel<FunctionAppRuntimeSettings>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
