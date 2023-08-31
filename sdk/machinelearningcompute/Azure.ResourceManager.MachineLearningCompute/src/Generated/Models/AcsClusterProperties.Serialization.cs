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

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class AcsClusterProperties : IUtf8JsonSerializable, IModelJsonSerializable<AcsClusterProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AcsClusterProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AcsClusterProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("orchestratorType"u8);
            writer.WriteStringValue(OrchestratorType.ToString());
            if (Optional.IsDefined(OrchestratorProperties))
            {
                writer.WritePropertyName("orchestratorProperties"u8);
                if (OrchestratorProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<KubernetesClusterProperties>)OrchestratorProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(SystemServices))
            {
                writer.WritePropertyName("systemServices"u8);
                writer.WriteStartArray();
                foreach (var item in SystemServices)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SystemService>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MasterCount))
            {
                writer.WritePropertyName("masterCount"u8);
                writer.WriteNumberValue(MasterCount.Value);
            }
            if (Optional.IsDefined(AgentCount))
            {
                writer.WritePropertyName("agentCount"u8);
                writer.WriteNumberValue(AgentCount.Value);
            }
            if (Optional.IsDefined(AgentVmSize))
            {
                writer.WritePropertyName("agentVmSize"u8);
                writer.WriteStringValue(AgentVmSize.Value.ToString());
            }
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

        internal static AcsClusterProperties DeserializeAcsClusterProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clusterFqdn = default;
            OrchestratorType orchestratorType = default;
            Optional<KubernetesClusterProperties> orchestratorProperties = default;
            Optional<IList<SystemService>> systemServices = default;
            Optional<int> masterCount = default;
            Optional<int> agentCount = default;
            Optional<AgentVmSizeType> agentVmSize = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterFqdn"u8))
                {
                    clusterFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("orchestratorType"u8))
                {
                    orchestratorType = new OrchestratorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("orchestratorProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    orchestratorProperties = KubernetesClusterProperties.DeserializeKubernetesClusterProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("systemServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SystemService> array = new List<SystemService>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SystemService.DeserializeSystemService(item));
                    }
                    systemServices = array;
                    continue;
                }
                if (property.NameEquals("masterCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    masterCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("agentCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("agentVmSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentVmSize = new AgentVmSizeType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AcsClusterProperties(clusterFqdn.Value, orchestratorType, orchestratorProperties.Value, Optional.ToList(systemServices), Optional.ToNullable(masterCount), Optional.ToNullable(agentCount), Optional.ToNullable(agentVmSize), rawData);
        }

        AcsClusterProperties IModelJsonSerializable<AcsClusterProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsClusterProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AcsClusterProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AcsClusterProperties IModelSerializable<AcsClusterProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAcsClusterProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AcsClusterProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AcsClusterProperties"/> to convert. </param>
        public static implicit operator RequestContent(AcsClusterProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AcsClusterProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AcsClusterProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAcsClusterProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
