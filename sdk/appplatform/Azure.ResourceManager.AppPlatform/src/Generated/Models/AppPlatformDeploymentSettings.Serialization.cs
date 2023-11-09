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

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformDeploymentSettings : IUtf8JsonSerializable, IJsonModel<AppPlatformDeploymentSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformDeploymentSettings>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<AppPlatformDeploymentSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceRequests))
            {
                writer.WritePropertyName("resourceRequests"u8);
                writer.WriteObjectValue(ResourceRequests);
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables"u8);
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(AddonConfigs))
            {
                writer.WritePropertyName("addonConfigs"u8);
                writer.WriteStartObject();
                foreach (var item in AddonConfigs)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartObject();
                    foreach (var item0 in item.Value)
                    {
                        writer.WritePropertyName(item0.Key);
                        if (item0.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item0.Value);
#else
                        using (JsonDocument document = JsonDocument.Parse(item0.Value))
                        {
                            JsonSerializer.Serialize(writer, document.RootElement);
                        }
#endif
                    }
                    writer.WriteEndObject();
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(LivenessProbe))
            {
                writer.WritePropertyName("livenessProbe"u8);
                writer.WriteObjectValue(LivenessProbe);
            }
            if (Optional.IsDefined(ReadinessProbe))
            {
                writer.WritePropertyName("readinessProbe"u8);
                writer.WriteObjectValue(ReadinessProbe);
            }
            if (Optional.IsDefined(StartupProbe))
            {
                writer.WritePropertyName("startupProbe"u8);
                writer.WriteObjectValue(StartupProbe);
            }
            if (Optional.IsDefined(TerminationGracePeriodInSeconds))
            {
                writer.WritePropertyName("terminationGracePeriodSeconds"u8);
                writer.WriteNumberValue(TerminationGracePeriodInSeconds.Value);
            }
            if (Optional.IsDefined(ContainerProbeSettings))
            {
                writer.WritePropertyName("containerProbeSettings"u8);
                writer.WriteObjectValue(ContainerProbeSettings);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        AppPlatformDeploymentSettings IJsonModel<AppPlatformDeploymentSettings>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppPlatformDeploymentSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformDeploymentSettings(document.RootElement, options);
        }

        internal static AppPlatformDeploymentSettings DeserializeAppPlatformDeploymentSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppPlatformDeploymentResourceRequirements> resourceRequests = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            Optional<IDictionary<string, IDictionary<string, BinaryData>>> addonConfigs = default;
            Optional<AppInstanceProbe> livenessProbe = default;
            Optional<AppInstanceProbe> readinessProbe = default;
            Optional<AppInstanceProbe> startupProbe = default;
            Optional<int> terminationGracePeriodSeconds = default;
            Optional<ContainerProbeSettings> containerProbeSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceRequests = AppPlatformDeploymentResourceRequirements.DeserializeAppPlatformDeploymentResourceRequirements(property.Value);
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
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
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("addonConfigs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IDictionary<string, BinaryData>> dictionary = new Dictionary<string, IDictionary<string, BinaryData>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            Dictionary<string, BinaryData> dictionary0 = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary0.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary0.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            dictionary.Add(property0.Name, dictionary0);
                        }
                    }
                    addonConfigs = dictionary;
                    continue;
                }
                if (property.NameEquals("livenessProbe"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    livenessProbe = AppInstanceProbe.DeserializeAppInstanceProbe(property.Value);
                    continue;
                }
                if (property.NameEquals("readinessProbe"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readinessProbe = AppInstanceProbe.DeserializeAppInstanceProbe(property.Value);
                    continue;
                }
                if (property.NameEquals("startupProbe"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startupProbe = AppInstanceProbe.DeserializeAppInstanceProbe(property.Value);
                    continue;
                }
                if (property.NameEquals("terminationGracePeriodSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    terminationGracePeriodSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("containerProbeSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerProbeSettings = ContainerProbeSettings.DeserializeContainerProbeSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformDeploymentSettings(resourceRequests.Value, Optional.ToDictionary(environmentVariables), Optional.ToDictionary(addonConfigs), livenessProbe.Value, readinessProbe.Value, startupProbe.Value, Optional.ToNullable(terminationGracePeriodSeconds), containerProbeSettings.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<AppPlatformDeploymentSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppPlatformDeploymentSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AppPlatformDeploymentSettings IModel<AppPlatformDeploymentSettings>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppPlatformDeploymentSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAppPlatformDeploymentSettings(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AppPlatformDeploymentSettings>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
