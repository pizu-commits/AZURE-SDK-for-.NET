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
using Azure.ResourceManager.KubernetesConfiguration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    public partial class KubernetesFluxConfigurationData : IUtf8JsonSerializable, IJsonModel<KubernetesFluxConfigurationData>, IPersistableModel<KubernetesFluxConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesFluxConfigurationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesFluxConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesFluxConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesFluxConfigurationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
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
                    writer.WriteObjectValue(GitRepository);
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
                    writer.WriteObjectValue(Bucket);
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
                    writer.WriteObjectValue(AzureBlob);
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
                        writer.WriteObjectValue(item.Value);
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
            if (options.Format != "W" && Optional.IsCollectionDefined(Statuses))
            {
                if (Statuses != null)
                {
                    writer.WritePropertyName("statuses"u8);
                    writer.WriteStartArray();
                    foreach (var item in Statuses)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("statuses");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(RepositoryPublicKey))
            {
                if (RepositoryPublicKey != null)
                {
                    writer.WritePropertyName("repositoryPublicKey"u8);
                    writer.WriteStringValue(RepositoryPublicKey);
                }
                else
                {
                    writer.WriteNull("repositoryPublicKey");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(SourceSyncedCommitId))
            {
                if (SourceSyncedCommitId != null)
                {
                    writer.WritePropertyName("sourceSyncedCommitId"u8);
                    writer.WriteStringValue(SourceSyncedCommitId);
                }
                else
                {
                    writer.WriteNull("sourceSyncedCommitId");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(SourceUpdatedOn))
            {
                if (SourceUpdatedOn != null)
                {
                    writer.WritePropertyName("sourceUpdatedAt"u8);
                    writer.WriteStringValue(SourceUpdatedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("sourceUpdatedAt");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(StatusUpdatedOn))
            {
                if (StatusUpdatedOn != null)
                {
                    writer.WritePropertyName("statusUpdatedAt"u8);
                    writer.WriteStringValue(StatusUpdatedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("statusUpdatedAt");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ComplianceState))
            {
                writer.WritePropertyName("complianceState"u8);
                writer.WriteStringValue(ComplianceState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorMessage))
            {
                if (ErrorMessage != null)
                {
                    writer.WritePropertyName("errorMessage"u8);
                    writer.WriteStringValue(ErrorMessage);
                }
                else
                {
                    writer.WriteNull("errorMessage");
                }
            }
            writer.WriteEndObject();
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

        KubernetesFluxConfigurationData IJsonModel<KubernetesFluxConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesFluxConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesFluxConfigurationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesFluxConfigurationData(document.RootElement, options);
        }

        internal static KubernetesFluxConfigurationData DeserializeKubernetesFluxConfigurationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

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
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesFluxConfigurationData(id, name, type, systemData.Value, Optional.ToNullable(scope), @namespace.Value, Optional.ToNullable(sourceKind), Optional.ToNullable(suspend), gitRepository.Value, bucket.Value, azureBlob.Value, Optional.ToDictionary(kustomizations), Optional.ToDictionary(configurationProtectedSettings), Optional.ToList(statuses), repositoryPublicKey.Value, sourceSyncedCommitId.Value, Optional.ToNullable(sourceUpdatedAt), Optional.ToNullable(statusUpdatedAt), Optional.ToNullable(complianceState), Optional.ToNullable(provisioningState), errorMessage.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Scope))
            {
                builder.Append("  scope:");
                builder.AppendLine($" '{Scope.ToString()}'");
            }

            if (Optional.IsDefined(Namespace))
            {
                builder.Append("  namespace:");
                builder.AppendLine($" '{Namespace}'");
            }

            if (Optional.IsDefined(SourceKind))
            {
                builder.Append("  sourceKind:");
                builder.AppendLine($" '{SourceKind.ToString()}'");
            }

            if (Optional.IsDefined(IsReconciliationSuspended))
            {
                builder.Append("  suspend:");
                var boolValue = IsReconciliationSuspended.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(GitRepository))
            {
                builder.Append("  gitRepository:");
                AppendChildObject(builder, GitRepository, options, 2);
            }

            if (Optional.IsDefined(Bucket))
            {
                builder.Append("  bucket:");
                AppendChildObject(builder, Bucket, options, 2);
            }

            if (Optional.IsDefined(AzureBlob))
            {
                builder.Append("  azureBlob:");
                AppendChildObject(builder, AzureBlob, options, 2);
            }

            if (Optional.IsCollectionDefined(Kustomizations))
            {
                builder.Append("  kustomizations:");
                builder.AppendLine(" {");
                foreach (var item in Kustomizations)
                {
                    builder.Append($"    {item.Key}: ");

                    AppendChildObject(builder, item.Value, options, 4);
                }
                builder.AppendLine("  }");
            }

            if (Optional.IsCollectionDefined(ConfigurationProtectedSettings))
            {
                builder.Append("  configurationProtectedSettings:");
                builder.AppendLine(" {");
                foreach (var item in ConfigurationProtectedSettings)
                {
                    builder.Append($"    {item.Key}: ");
                    if (item.Value == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($" '{item.Value}'");
                }
                builder.AppendLine("  }");
            }

            if (Optional.IsCollectionDefined(Statuses))
            {
                builder.Append("  statuses:");
                builder.AppendLine(" [");
                foreach (var item in Statuses)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(RepositoryPublicKey))
            {
                builder.Append("  repositoryPublicKey:");
                builder.AppendLine($" '{RepositoryPublicKey}'");
            }

            if (Optional.IsDefined(SourceSyncedCommitId))
            {
                builder.Append("  sourceSyncedCommitId:");
                builder.AppendLine($" '{SourceSyncedCommitId}'");
            }

            if (Optional.IsDefined(SourceUpdatedOn))
            {
                builder.Append("  sourceUpdatedAt:");
                builder.AppendLine($" '{SourceUpdatedOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(StatusUpdatedOn))
            {
                builder.Append("  statusUpdatedAt:");
                builder.AppendLine($" '{StatusUpdatedOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(ComplianceState))
            {
                builder.Append("  complianceState:");
                builder.AppendLine($" '{ComplianceState.ToString()}'");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("  provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(ErrorMessage))
            {
                builder.Append("  errorMessage:");
                builder.AppendLine($" '{ErrorMessage}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<KubernetesFluxConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesFluxConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesFluxConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        KubernetesFluxConfigurationData IPersistableModel<KubernetesFluxConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesFluxConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesFluxConfigurationData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(KubernetesFluxConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesFluxConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
