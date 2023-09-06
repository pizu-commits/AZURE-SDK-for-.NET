// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.KubernetesConfiguration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    public partial class KubernetesFluxConfigurationData : IUtf8JsonSerializable, IModelJsonSerializable<KubernetesFluxConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KubernetesFluxConfigurationData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KubernetesFluxConfigurationData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesFluxConfigurationData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope.Value.ToString());
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(SourceKind))
            {
                writer.WritePropertyName("sourceKind"u8);
                writer.WriteStringValue(SourceKind.Value.ToString());
            }
            if (Optional.IsDefined(IsReconciliationSuspended))
            {
                writer.WritePropertyName("suspend"u8);
                writer.WriteBooleanValue(IsReconciliationSuspended.Value);
            }
            if (Optional.IsDefined(GitRepository))
            {
                if (GitRepository != null)
                {
                    writer.WritePropertyName("gitRepository"u8);
                    if (GitRepository is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<KubernetesGitRepository>)GitRepository).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("gitRepository");
                }
            }
            if (Optional.IsDefined(Bucket))
            {
                if (Bucket != null)
                {
                    writer.WritePropertyName("bucket"u8);
                    if (Bucket is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<KubernetesBucket>)Bucket).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("bucket");
                }
            }
            if (Optional.IsDefined(AzureBlob))
            {
                if (AzureBlob != null)
                {
                    writer.WritePropertyName("azureBlob"u8);
                    if (AzureBlob is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<KubernetesAzureBlob>)AzureBlob).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("azureBlob");
                }
            }
            if (Optional.IsCollectionDefined(Kustomizations))
            {
                if (Kustomizations != null)
                {
                    writer.WritePropertyName("kustomizations"u8);
                    writer.WriteStartObject();
                    foreach (var item in Kustomizations)
                    {
                        writer.WritePropertyName(item.Key);
                        if (item.Value is null)
                        {
                            writer.WriteNullValue();
                        }
                        else
                        {
                            ((IModelJsonSerializable<Kustomization>)item.Value).Serialize(writer, options);
                        }
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("kustomizations");
                }
            }
            if (Optional.IsCollectionDefined(ConfigurationProtectedSettings))
            {
                if (ConfigurationProtectedSettings != null)
                {
                    writer.WritePropertyName("configurationProtectedSettings"u8);
                    writer.WriteStartObject();
                    foreach (var item in ConfigurationProtectedSettings)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("configurationProtectedSettings");
                }
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static KubernetesFluxConfigurationData DeserializeKubernetesFluxConfigurationData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<KubernetesConfigurationScope> scope = default;
            Optional<string> @namespace = default;
            Optional<KubernetesConfigurationSourceKind> sourceKind = default;
            Optional<bool> suspend = default;
            Optional<KubernetesGitRepository> gitRepository = default;
            Optional<KubernetesBucket> bucket = default;
            Optional<KubernetesAzureBlob> azureBlob = default;
            Optional<IDictionary<string, Kustomization>> kustomizations = default;
            Optional<IDictionary<string, string>> configurationProtectedSettings = default;
            Optional<IReadOnlyList<KubernetesObjectStatus>> statuses = default;
            Optional<string> repositoryPublicKey = default;
            Optional<string> sourceSyncedCommitId = default;
            Optional<DateTimeOffset?> sourceUpdatedAt = default;
            Optional<DateTimeOffset?> statusUpdatedAt = default;
            Optional<KubernetesFluxComplianceState> complianceState = default;
            Optional<KubernetesConfigurationProvisioningState> provisioningState = default;
            Optional<string> errorMessage = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("scope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scope = new KubernetesConfigurationScope(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("namespace"u8))
                        {
                            @namespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceKind"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceKind = new KubernetesConfigurationSourceKind(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("suspend"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suspend = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("gitRepository"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                gitRepository = null;
                                continue;
                            }
                            gitRepository = KubernetesGitRepository.DeserializeKubernetesGitRepository(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("bucket"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                bucket = null;
                                continue;
                            }
                            bucket = KubernetesBucket.DeserializeKubernetesBucket(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("azureBlob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                azureBlob = null;
                                continue;
                            }
                            azureBlob = KubernetesAzureBlob.DeserializeKubernetesAzureBlob(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("kustomizations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                kustomizations = null;
                                continue;
                            }
                            Dictionary<string, Kustomization> dictionary = new Dictionary<string, Kustomization>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, Kustomization.DeserializeKustomization(property1.Value));
                            }
                            kustomizations = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("configurationProtectedSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                configurationProtectedSettings = null;
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            configurationProtectedSettings = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("statuses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                statuses = null;
                                continue;
                            }
                            List<KubernetesObjectStatus> array = new List<KubernetesObjectStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KubernetesObjectStatus.DeserializeKubernetesObjectStatus(item));
                            }
                            statuses = array;
                            continue;
                        }
                        if (property0.NameEquals("repositoryPublicKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                repositoryPublicKey = null;
                                continue;
                            }
                            repositoryPublicKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceSyncedCommitId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                sourceSyncedCommitId = null;
                                continue;
                            }
                            sourceSyncedCommitId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceUpdatedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                sourceUpdatedAt = null;
                                continue;
                            }
                            sourceUpdatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("statusUpdatedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                statusUpdatedAt = null;
                                continue;
                            }
                            statusUpdatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("complianceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            complianceState = new KubernetesFluxComplianceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new KubernetesConfigurationProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                errorMessage = null;
                                continue;
                            }
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KubernetesFluxConfigurationData(id, name, type, systemData.Value, Optional.ToNullable(scope), @namespace.Value, Optional.ToNullable(sourceKind), Optional.ToNullable(suspend), gitRepository.Value, bucket.Value, azureBlob.Value, Optional.ToDictionary(kustomizations), Optional.ToDictionary(configurationProtectedSettings), Optional.ToList(statuses), repositoryPublicKey.Value, sourceSyncedCommitId.Value, Optional.ToNullable(sourceUpdatedAt), Optional.ToNullable(statusUpdatedAt), Optional.ToNullable(complianceState), Optional.ToNullable(provisioningState), errorMessage.Value, rawData);
        }

        KubernetesFluxConfigurationData IModelJsonSerializable<KubernetesFluxConfigurationData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesFluxConfigurationData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesFluxConfigurationData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KubernetesFluxConfigurationData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesFluxConfigurationData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KubernetesFluxConfigurationData IModelSerializable<KubernetesFluxConfigurationData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesFluxConfigurationData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKubernetesFluxConfigurationData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KubernetesFluxConfigurationData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KubernetesFluxConfigurationData"/> to convert. </param>
        public static implicit operator RequestContent(KubernetesFluxConfigurationData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KubernetesFluxConfigurationData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KubernetesFluxConfigurationData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKubernetesFluxConfigurationData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
