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
using Azure.ResourceManager.MachineLearningCompute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearningCompute
{
    public partial class OperationalizationClusterData : IUtf8JsonSerializable, IModelJsonSerializable<OperationalizationClusterData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OperationalizationClusterData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OperationalizationClusterData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ClusterType))
            {
                writer.WritePropertyName("clusterType"u8);
                writer.WriteStringValue(ClusterType.Value.ToString());
            }
            if (Optional.IsDefined(StorageAccount))
            {
                writer.WritePropertyName("storageAccount"u8);
                if (StorageAccount is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StorageAccountProperties>)StorageAccount).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ContainerRegistry))
            {
                writer.WritePropertyName("containerRegistry"u8);
                if (ContainerRegistry is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerRegistryProperties>)ContainerRegistry).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ContainerService))
            {
                writer.WritePropertyName("containerService"u8);
                if (ContainerService is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AcsClusterProperties>)ContainerService).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AppInsights))
            {
                writer.WritePropertyName("appInsights"u8);
                if (AppInsights is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AppInsightsProperties>)AppInsights).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(GlobalServiceConfiguration))
            {
                writer.WritePropertyName("globalServiceConfiguration"u8);
                if (GlobalServiceConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GlobalServiceConfiguration>)GlobalServiceConfiguration).Serialize(writer, options);
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

        internal static OperationalizationClusterData DeserializeOperationalizationClusterData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<DateTimeOffset> createdOn = default;
            Optional<DateTimeOffset> modifiedOn = default;
            Optional<OperationStatus> provisioningState = default;
            Optional<IReadOnlyList<ErrorResponseWrapper>> provisioningErrors = default;
            Optional<ClusterType> clusterType = default;
            Optional<StorageAccountProperties> storageAccount = default;
            Optional<ContainerRegistryProperties> containerRegistry = default;
            Optional<AcsClusterProperties> containerService = default;
            Optional<AppInsightsProperties> appInsights = default;
            Optional<GlobalServiceConfiguration> globalServiceConfiguration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("modifiedOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            modifiedOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new OperationStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningErrors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ErrorResponseWrapper> array = new List<ErrorResponseWrapper>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ErrorResponseWrapper.DeserializeErrorResponseWrapper(item));
                            }
                            provisioningErrors = array;
                            continue;
                        }
                        if (property0.NameEquals("clusterType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterType = new ClusterType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageAccount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccount = StorageAccountProperties.DeserializeStorageAccountProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("containerRegistry"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            containerRegistry = ContainerRegistryProperties.DeserializeContainerRegistryProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("containerService"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            containerService = AcsClusterProperties.DeserializeAcsClusterProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("appInsights"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appInsights = AppInsightsProperties.DeserializeAppInsightsProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("globalServiceConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            globalServiceConfiguration = GlobalServiceConfiguration.DeserializeGlobalServiceConfiguration(property0.Value);
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
            return new OperationalizationClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, description.Value, Optional.ToNullable(createdOn), Optional.ToNullable(modifiedOn), Optional.ToNullable(provisioningState), Optional.ToList(provisioningErrors), Optional.ToNullable(clusterType), storageAccount.Value, containerRegistry.Value, containerService.Value, appInsights.Value, globalServiceConfiguration.Value, rawData);
        }

        OperationalizationClusterData IModelJsonSerializable<OperationalizationClusterData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalizationClusterData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OperationalizationClusterData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OperationalizationClusterData IModelSerializable<OperationalizationClusterData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOperationalizationClusterData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OperationalizationClusterData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OperationalizationClusterData"/> to convert. </param>
        public static implicit operator RequestContent(OperationalizationClusterData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OperationalizationClusterData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OperationalizationClusterData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOperationalizationClusterData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
