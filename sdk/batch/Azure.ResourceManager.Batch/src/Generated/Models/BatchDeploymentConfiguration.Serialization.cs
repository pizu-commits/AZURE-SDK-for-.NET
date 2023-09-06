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

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchDeploymentConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<BatchDeploymentConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BatchDeploymentConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BatchDeploymentConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchDeploymentConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CloudServiceConfiguration))
            {
                writer.WritePropertyName("cloudServiceConfiguration"u8);
                if (CloudServiceConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BatchCloudServiceConfiguration>)CloudServiceConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(VmConfiguration))
            {
                writer.WritePropertyName("virtualMachineConfiguration"u8);
                if (VmConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BatchVmConfiguration>)VmConfiguration).Serialize(writer, options);
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

        internal static BatchDeploymentConfiguration DeserializeBatchDeploymentConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BatchCloudServiceConfiguration> cloudServiceConfiguration = default;
            Optional<BatchVmConfiguration> virtualMachineConfiguration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cloudServiceConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudServiceConfiguration = BatchCloudServiceConfiguration.DeserializeBatchCloudServiceConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("virtualMachineConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineConfiguration = BatchVmConfiguration.DeserializeBatchVmConfiguration(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BatchDeploymentConfiguration(cloudServiceConfiguration.Value, virtualMachineConfiguration.Value, rawData);
        }

        BatchDeploymentConfiguration IModelJsonSerializable<BatchDeploymentConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchDeploymentConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchDeploymentConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BatchDeploymentConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchDeploymentConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BatchDeploymentConfiguration IModelSerializable<BatchDeploymentConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchDeploymentConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBatchDeploymentConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BatchDeploymentConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BatchDeploymentConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(BatchDeploymentConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BatchDeploymentConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BatchDeploymentConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBatchDeploymentConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
