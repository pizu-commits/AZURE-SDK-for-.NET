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
    public partial class AmlComputeProperties : IUtf8JsonSerializable, IModelJsonSerializable<AmlComputeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AmlComputeProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AmlComputeProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(VmPriority))
            {
                writer.WritePropertyName("vmPriority"u8);
                writer.WriteStringValue(VmPriority.Value.ToString());
            }
            if (Optional.IsDefined(VirtualMachineImage))
            {
                if (VirtualMachineImage != null)
                {
                    writer.WritePropertyName("virtualMachineImage"u8);
                    if (VirtualMachineImage is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<VirtualMachineImage>)VirtualMachineImage).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("virtualMachineImage");
                }
            }
            if (Optional.IsDefined(IsolatedNetwork))
            {
                writer.WritePropertyName("isolatedNetwork"u8);
                writer.WriteBooleanValue(IsolatedNetwork.Value);
            }
            if (Optional.IsDefined(ScaleSettings))
            {
                writer.WritePropertyName("scaleSettings"u8);
                if (ScaleSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AmlComputeScaleSettings>)ScaleSettings).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(UserAccountCredentials))
            {
                if (UserAccountCredentials != null)
                {
                    writer.WritePropertyName("userAccountCredentials"u8);
                    if (UserAccountCredentials is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningUserAccountCredentials>)UserAccountCredentials).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("userAccountCredentials");
                }
            }
            if (Optional.IsDefined(Subnet))
            {
                if (Subnet != null)
                {
                    writer.WritePropertyName("subnet"u8);
                    if (Subnet is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ResourceId>)Subnet).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("subnet");
                }
            }
            if (Optional.IsDefined(RemoteLoginPortPublicAccess))
            {
                writer.WritePropertyName("remoteLoginPortPublicAccess"u8);
                writer.WriteStringValue(RemoteLoginPortPublicAccess.Value.ToString());
            }
            if (Optional.IsDefined(EnableNodePublicIP))
            {
                if (EnableNodePublicIP != null)
                {
                    writer.WritePropertyName("enableNodePublicIp"u8);
                    writer.WriteBooleanValue(EnableNodePublicIP.Value);
                }
                else
                {
                    writer.WriteNull("enableNodePublicIp");
                }
            }
            if (Optional.IsDefined(PropertyBag))
            {
                if (PropertyBag != null)
                {
                    writer.WritePropertyName("propertyBag"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PropertyBag);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(PropertyBag.ToString()).RootElement);
#endif
                }
                else
                {
                    writer.WriteNull("propertyBag");
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

        internal static AmlComputeProperties DeserializeAmlComputeProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningOSType> osType = default;
            Optional<string> vmSize = default;
            Optional<MachineLearningVmPriority> vmPriority = default;
            Optional<VirtualMachineImage> virtualMachineImage = default;
            Optional<bool> isolatedNetwork = default;
            Optional<AmlComputeScaleSettings> scaleSettings = default;
            Optional<MachineLearningUserAccountCredentials> userAccountCredentials = default;
            Optional<ResourceId> subnet = default;
            Optional<MachineLearningRemoteLoginPortPublicAccess> remoteLoginPortPublicAccess = default;
            Optional<MachineLearningAllocationState> allocationState = default;
            Optional<DateTimeOffset> allocationStateTransitionTime = default;
            Optional<IReadOnlyList<MachineLearningError>> errors = default;
            Optional<int?> currentNodeCount = default;
            Optional<int?> targetNodeCount = default;
            Optional<MachineLearningNodeStateCounts> nodeStateCounts = default;
            Optional<bool?> enableNodePublicIP = default;
            Optional<BinaryData> propertyBag = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new MachineLearningOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmPriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmPriority = new MachineLearningVmPriority(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineImage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        virtualMachineImage = null;
                        continue;
                    }
                    virtualMachineImage = VirtualMachineImage.DeserializeVirtualMachineImage(property.Value);
                    continue;
                }
                if (property.NameEquals("isolatedNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isolatedNetwork = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("scaleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleSettings = AmlComputeScaleSettings.DeserializeAmlComputeScaleSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("userAccountCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userAccountCredentials = null;
                        continue;
                    }
                    userAccountCredentials = MachineLearningUserAccountCredentials.DeserializeMachineLearningUserAccountCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("subnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subnet = null;
                        continue;
                    }
                    subnet = ResourceId.DeserializeResourceId(property.Value);
                    continue;
                }
                if (property.NameEquals("remoteLoginPortPublicAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remoteLoginPortPublicAccess = new MachineLearningRemoteLoginPortPublicAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allocationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationState = new MachineLearningAllocationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allocationStateTransitionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationStateTransitionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errors = null;
                        continue;
                    }
                    List<MachineLearningError> array = new List<MachineLearningError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningError.DeserializeMachineLearningError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("currentNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        currentNodeCount = null;
                        continue;
                    }
                    currentNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetNodeCount = null;
                        continue;
                    }
                    targetNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeStateCounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nodeStateCounts = null;
                        continue;
                    }
                    nodeStateCounts = MachineLearningNodeStateCounts.DeserializeMachineLearningNodeStateCounts(property.Value);
                    continue;
                }
                if (property.NameEquals("enableNodePublicIp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableNodePublicIP = null;
                        continue;
                    }
                    enableNodePublicIP = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("propertyBag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        propertyBag = null;
                        continue;
                    }
                    propertyBag = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AmlComputeProperties(Optional.ToNullable(osType), vmSize.Value, Optional.ToNullable(vmPriority), virtualMachineImage.Value, Optional.ToNullable(isolatedNetwork), scaleSettings.Value, userAccountCredentials.Value, subnet.Value, Optional.ToNullable(remoteLoginPortPublicAccess), Optional.ToNullable(allocationState), Optional.ToNullable(allocationStateTransitionTime), Optional.ToList(errors), Optional.ToNullable(currentNodeCount), Optional.ToNullable(targetNodeCount), nodeStateCounts.Value, Optional.ToNullable(enableNodePublicIP), propertyBag.Value, rawData);
        }

        AmlComputeProperties IModelJsonSerializable<AmlComputeProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlComputeProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AmlComputeProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AmlComputeProperties IModelSerializable<AmlComputeProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAmlComputeProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AmlComputeProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AmlComputeProperties"/> to convert. </param>
        public static implicit operator RequestContent(AmlComputeProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AmlComputeProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AmlComputeProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAmlComputeProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
