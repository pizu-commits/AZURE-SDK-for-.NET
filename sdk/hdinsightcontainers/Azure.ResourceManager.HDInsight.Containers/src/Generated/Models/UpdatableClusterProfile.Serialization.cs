// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class UpdatableClusterProfile : IUtf8JsonSerializable, IJsonModel<UpdatableClusterProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdatableClusterProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UpdatableClusterProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdatableClusterProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdatableClusterProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ServiceConfigsProfiles))
            {
                writer.WritePropertyName("serviceConfigsProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceConfigsProfiles)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SshProfile))
            {
                writer.WritePropertyName("sshProfile"u8);
                writer.WriteObjectValue(SshProfile, options);
            }
            if (Optional.IsDefined(AutoscaleProfile))
            {
                writer.WritePropertyName("autoscaleProfile"u8);
                writer.WriteObjectValue(AutoscaleProfile, options);
            }
            if (Optional.IsDefined(AuthorizationProfile))
            {
                writer.WritePropertyName("authorizationProfile"u8);
                writer.WriteObjectValue(AuthorizationProfile, options);
            }
            if (Optional.IsDefined(LogAnalyticsProfile))
            {
                writer.WritePropertyName("logAnalyticsProfile"u8);
                writer.WriteObjectValue(LogAnalyticsProfile, options);
            }
            if (Optional.IsDefined(PrometheusProfile))
            {
                writer.WritePropertyName("prometheusProfile"u8);
                writer.WriteObjectValue(PrometheusProfile, options);
            }
            if (Optional.IsDefined(RangerPluginProfile))
            {
                writer.WritePropertyName("rangerPluginProfile"u8);
                writer.WriteObjectValue(RangerPluginProfile, options);
            }
            if (Optional.IsDefined(RangerProfile))
            {
                writer.WritePropertyName("rangerProfile"u8);
                writer.WriteObjectValue(RangerProfile, options);
            }
            if (Optional.IsCollectionDefined(ScriptActionProfiles))
            {
                writer.WritePropertyName("scriptActionProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ScriptActionProfiles)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SecretsProfile))
            {
                writer.WritePropertyName("secretsProfile"u8);
                writer.WriteObjectValue(SecretsProfile, options);
            }
            if (Optional.IsDefined(TrinoProfile))
            {
                writer.WritePropertyName("trinoProfile"u8);
                writer.WriteObjectValue(TrinoProfile, options);
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

        UpdatableClusterProfile IJsonModel<UpdatableClusterProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdatableClusterProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdatableClusterProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdatableClusterProfile(document.RootElement, options);
        }

        internal static UpdatableClusterProfile DeserializeUpdatableClusterProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ClusterServiceConfigsProfile> serviceConfigsProfiles = default;
            ClusterSshProfile sshProfile = default;
            ClusterAutoscaleProfile autoscaleProfile = default;
            AuthorizationProfile authorizationProfile = default;
            ClusterLogAnalyticsProfile logAnalyticsProfile = default;
            ClusterPrometheusProfile prometheusProfile = default;
            ClusterRangerPluginProfile rangerPluginProfile = default;
            RangerProfile rangerProfile = default;
            IList<ScriptActionProfile> scriptActionProfiles = default;
            ClusterSecretsProfile secretsProfile = default;
            TrinoProfile trinoProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceConfigsProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ClusterServiceConfigsProfile> array = new List<ClusterServiceConfigsProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClusterServiceConfigsProfile.DeserializeClusterServiceConfigsProfile(item, options));
                    }
                    serviceConfigsProfiles = array;
                    continue;
                }
                if (property.NameEquals("sshProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sshProfile = ClusterSshProfile.DeserializeClusterSshProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("autoscaleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoscaleProfile = ClusterAutoscaleProfile.DeserializeClusterAutoscaleProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("authorizationProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authorizationProfile = AuthorizationProfile.DeserializeAuthorizationProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("logAnalyticsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logAnalyticsProfile = ClusterLogAnalyticsProfile.DeserializeClusterLogAnalyticsProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("prometheusProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prometheusProfile = ClusterPrometheusProfile.DeserializeClusterPrometheusProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("rangerPluginProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rangerPluginProfile = ClusterRangerPluginProfile.DeserializeClusterRangerPluginProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("rangerProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rangerProfile = RangerProfile.DeserializeRangerProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scriptActionProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScriptActionProfile> array = new List<ScriptActionProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScriptActionProfile.DeserializeScriptActionProfile(item, options));
                    }
                    scriptActionProfiles = array;
                    continue;
                }
                if (property.NameEquals("secretsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secretsProfile = ClusterSecretsProfile.DeserializeClusterSecretsProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("trinoProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trinoProfile = TrinoProfile.DeserializeTrinoProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UpdatableClusterProfile(
                serviceConfigsProfiles ?? new ChangeTrackingList<ClusterServiceConfigsProfile>(),
                sshProfile,
                autoscaleProfile,
                authorizationProfile,
                logAnalyticsProfile,
                prometheusProfile,
                rangerPluginProfile,
                rangerProfile,
                scriptActionProfiles ?? new ChangeTrackingList<ScriptActionProfile>(),
                secretsProfile,
                trinoProfile,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdatableClusterProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdatableClusterProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdatableClusterProfile)} does not support writing '{options.Format}' format.");
            }
        }

        UpdatableClusterProfile IPersistableModel<UpdatableClusterProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdatableClusterProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpdatableClusterProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdatableClusterProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdatableClusterProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
