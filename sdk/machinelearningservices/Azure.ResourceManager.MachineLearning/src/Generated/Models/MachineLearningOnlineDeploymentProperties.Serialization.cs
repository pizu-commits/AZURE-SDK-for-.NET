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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningOnlineDeploymentProperties : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningOnlineDeploymentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningOnlineDeploymentProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningOnlineDeploymentProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningOnlineDeploymentProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AppInsightsEnabled))
            {
                writer.WritePropertyName("appInsightsEnabled"u8);
                writer.WriteBooleanValue(AppInsightsEnabled.Value);
            }
            if (Optional.IsDefined(EgressPublicNetworkAccess))
            {
                writer.WritePropertyName("egressPublicNetworkAccess"u8);
                writer.WriteStringValue(EgressPublicNetworkAccess.Value.ToString());
            }
            writer.WritePropertyName("endpointComputeType"u8);
            writer.WriteStringValue(EndpointComputeType.ToString());
            if (Optional.IsDefined(InstanceType))
            {
                if (InstanceType != null)
                {
                    writer.WritePropertyName("instanceType"u8);
                    writer.WriteStringValue(InstanceType);
                }
                else
                {
                    writer.WriteNull("instanceType");
                }
            }
            if (Optional.IsDefined(LivenessProbe))
            {
                if (LivenessProbe != null)
                {
                    writer.WritePropertyName("livenessProbe"u8);
                    if (LivenessProbe is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningProbeSettings>)LivenessProbe).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("livenessProbe");
                }
            }
            if (Optional.IsDefined(Model))
            {
                if (Model != null)
                {
                    writer.WritePropertyName("model"u8);
                    writer.WriteStringValue(Model);
                }
                else
                {
                    writer.WriteNull("model");
                }
            }
            if (Optional.IsDefined(ModelMountPath))
            {
                if (ModelMountPath != null)
                {
                    writer.WritePropertyName("modelMountPath"u8);
                    writer.WriteStringValue(ModelMountPath);
                }
                else
                {
                    writer.WriteNull("modelMountPath");
                }
            }
            if (Optional.IsDefined(ReadinessProbe))
            {
                if (ReadinessProbe != null)
                {
                    writer.WritePropertyName("readinessProbe"u8);
                    if (ReadinessProbe is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningProbeSettings>)ReadinessProbe).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("readinessProbe");
                }
            }
            if (Optional.IsDefined(RequestSettings))
            {
                if (RequestSettings != null)
                {
                    writer.WritePropertyName("requestSettings"u8);
                    if (RequestSettings is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningOnlineRequestSettings>)RequestSettings).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("requestSettings");
                }
            }
            if (Optional.IsDefined(ScaleSettings))
            {
                if (ScaleSettings != null)
                {
                    writer.WritePropertyName("scaleSettings"u8);
                    if (ScaleSettings is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningOnlineScaleSettings>)ScaleSettings).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("scaleSettings");
                }
            }
            if (Optional.IsDefined(CodeConfiguration))
            {
                if (CodeConfiguration != null)
                {
                    writer.WritePropertyName("codeConfiguration"u8);
                    if (CodeConfiguration is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningCodeConfiguration>)CodeConfiguration).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("codeConfiguration");
                }
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                if (EnvironmentId != null)
                {
                    writer.WritePropertyName("environmentId"u8);
                    writer.WriteStringValue(EnvironmentId);
                }
                else
                {
                    writer.WriteNull("environmentId");
                }
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                if (EnvironmentVariables != null)
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
                else
                {
                    writer.WriteNull("environmentVariables");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
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

        internal static MachineLearningOnlineDeploymentProperties DeserializeMachineLearningOnlineDeploymentProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("endpointComputeType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Kubernetes": return MachineLearningKubernetesOnlineDeployment.DeserializeMachineLearningKubernetesOnlineDeployment(element);
                    case "Managed": return MachineLearningManagedOnlineDeployment.DeserializeMachineLearningManagedOnlineDeployment(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<bool> appInsightsEnabled = default;
            Optional<MachineLearningEgressPublicNetworkAccessType> egressPublicNetworkAccess = default;
            MachineLearningEndpointComputeType endpointComputeType = default;
            Optional<string> instanceType = default;
            Optional<MachineLearningProbeSettings> livenessProbe = default;
            Optional<string> model = default;
            Optional<string> modelMountPath = default;
            Optional<MachineLearningDeploymentProvisioningState> provisioningState = default;
            Optional<MachineLearningProbeSettings> readinessProbe = default;
            Optional<MachineLearningOnlineRequestSettings> requestSettings = default;
            Optional<MachineLearningOnlineScaleSettings> scaleSettings = default;
            Optional<MachineLearningCodeConfiguration> codeConfiguration = default;
            Optional<string> description = default;
            Optional<string> environmentId = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            Optional<IDictionary<string, string>> properties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appInsightsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appInsightsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("egressPublicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    egressPublicNetworkAccess = new MachineLearningEgressPublicNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpointComputeType"u8))
                {
                    endpointComputeType = new MachineLearningEndpointComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        instanceType = null;
                        continue;
                    }
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("livenessProbe"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        livenessProbe = null;
                        continue;
                    }
                    livenessProbe = MachineLearningProbeSettings.DeserializeMachineLearningProbeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        model = null;
                        continue;
                    }
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelMountPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelMountPath = null;
                        continue;
                    }
                    modelMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MachineLearningDeploymentProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("readinessProbe"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        readinessProbe = null;
                        continue;
                    }
                    readinessProbe = MachineLearningProbeSettings.DeserializeMachineLearningProbeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("requestSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        requestSettings = null;
                        continue;
                    }
                    requestSettings = MachineLearningOnlineRequestSettings.DeserializeMachineLearningOnlineRequestSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("scaleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scaleSettings = null;
                        continue;
                    }
                    scaleSettings = MachineLearningOnlineScaleSettings.DeserializeMachineLearningOnlineScaleSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("codeConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        codeConfiguration = null;
                        continue;
                    }
                    codeConfiguration = MachineLearningCodeConfiguration.DeserializeMachineLearningCodeConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentId = null;
                        continue;
                    }
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentVariables = null;
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownOnlineDeployment(codeConfiguration.Value, description.Value, environmentId.Value, Optional.ToDictionary(environmentVariables), Optional.ToDictionary(properties), Optional.ToNullable(appInsightsEnabled), Optional.ToNullable(egressPublicNetworkAccess), endpointComputeType, instanceType.Value, livenessProbe.Value, model.Value, modelMountPath.Value, Optional.ToNullable(provisioningState), readinessProbe.Value, requestSettings.Value, scaleSettings.Value, rawData);
        }

        MachineLearningOnlineDeploymentProperties IModelJsonSerializable<MachineLearningOnlineDeploymentProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningOnlineDeploymentProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningOnlineDeploymentProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningOnlineDeploymentProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningOnlineDeploymentProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningOnlineDeploymentProperties IModelSerializable<MachineLearningOnlineDeploymentProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningOnlineDeploymentProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningOnlineDeploymentProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningOnlineDeploymentProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningOnlineDeploymentProperties"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningOnlineDeploymentProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningOnlineDeploymentProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningOnlineDeploymentProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningOnlineDeploymentProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
