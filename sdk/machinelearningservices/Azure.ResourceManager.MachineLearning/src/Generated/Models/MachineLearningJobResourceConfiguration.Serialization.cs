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
    public partial class MachineLearningJobResourceConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningJobResourceConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningJobResourceConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningJobResourceConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningJobResourceConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DockerArgs))
            {
                if (DockerArgs != null)
                {
                    writer.WritePropertyName("dockerArgs"u8);
                    writer.WriteStringValue(DockerArgs);
                }
                else
                {
                    writer.WriteNull("dockerArgs");
                }
            }
            if (Optional.IsDefined(ShmSize))
            {
                writer.WritePropertyName("shmSize"u8);
                writer.WriteStringValue(ShmSize);
            }
            if (Optional.IsDefined(InstanceCount))
            {
                writer.WritePropertyName("instanceCount"u8);
                writer.WriteNumberValue(InstanceCount.Value);
            }
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
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        if (item.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                        JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
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

        internal static MachineLearningJobResourceConfiguration DeserializeMachineLearningJobResourceConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> dockerArgs = default;
            Optional<string> shmSize = default;
            Optional<int> instanceCount = default;
            Optional<string> instanceType = default;
            Optional<IDictionary<string, BinaryData>> properties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dockerArgs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dockerArgs = null;
                        continue;
                    }
                    dockerArgs = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shmSize"u8))
                {
                    shmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceCount = property.Value.GetInt32();
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
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
            return new MachineLearningJobResourceConfiguration(Optional.ToNullable(instanceCount), instanceType.Value, Optional.ToDictionary(properties), dockerArgs.Value, shmSize.Value, rawData);
        }

        MachineLearningJobResourceConfiguration IModelJsonSerializable<MachineLearningJobResourceConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningJobResourceConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningJobResourceConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningJobResourceConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningJobResourceConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningJobResourceConfiguration IModelSerializable<MachineLearningJobResourceConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningJobResourceConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningJobResourceConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningJobResourceConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningJobResourceConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningJobResourceConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningJobResourceConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningJobResourceConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningJobResourceConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
