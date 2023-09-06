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
    public partial class MachineLearningComputeInstanceDataMount : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningComputeInstanceDataMount>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningComputeInstanceDataMount>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningComputeInstanceDataMount>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeInstanceDataMount>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(SourceType))
            {
                writer.WritePropertyName("sourceType"u8);
                writer.WriteStringValue(SourceType.Value.ToString());
            }
            if (Optional.IsDefined(MountName))
            {
                writer.WritePropertyName("mountName"u8);
                writer.WriteStringValue(MountName);
            }
            if (Optional.IsDefined(MountAction))
            {
                writer.WritePropertyName("mountAction"u8);
                writer.WriteStringValue(MountAction.Value.ToString());
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteStringValue(CreatedBy);
            }
            if (Optional.IsDefined(MountPath))
            {
                writer.WritePropertyName("mountPath"u8);
                writer.WriteStringValue(MountPath);
            }
            if (Optional.IsDefined(MountState))
            {
                writer.WritePropertyName("mountState"u8);
                writer.WriteStringValue(MountState.Value.ToString());
            }
            if (Optional.IsDefined(MountedOn))
            {
                writer.WritePropertyName("mountedOn"u8);
                writer.WriteStringValue(MountedOn.Value, "O");
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteStringValue(Error);
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

        internal static MachineLearningComputeInstanceDataMount DeserializeMachineLearningComputeInstanceDataMount(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> source = default;
            Optional<MachineLearningSourceType> sourceType = default;
            Optional<string> mountName = default;
            Optional<MachineLearningMountAction> mountAction = default;
            Optional<string> createdBy = default;
            Optional<string> mountPath = default;
            Optional<MachineLearningMountState> mountState = default;
            Optional<DateTimeOffset> mountedOn = default;
            Optional<string> error = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceType = new MachineLearningSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mountName"u8))
                {
                    mountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mountAction = new MachineLearningMountAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdBy"u8))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountPath"u8))
                {
                    mountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mountState = new MachineLearningMountState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mountedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mountedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningComputeInstanceDataMount(source.Value, Optional.ToNullable(sourceType), mountName.Value, Optional.ToNullable(mountAction), createdBy.Value, mountPath.Value, Optional.ToNullable(mountState), Optional.ToNullable(mountedOn), error.Value, rawData);
        }

        MachineLearningComputeInstanceDataMount IModelJsonSerializable<MachineLearningComputeInstanceDataMount>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeInstanceDataMount>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningComputeInstanceDataMount(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningComputeInstanceDataMount>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeInstanceDataMount>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningComputeInstanceDataMount IModelSerializable<MachineLearningComputeInstanceDataMount>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeInstanceDataMount>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningComputeInstanceDataMount(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningComputeInstanceDataMount"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningComputeInstanceDataMount"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningComputeInstanceDataMount model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningComputeInstanceDataMount"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningComputeInstanceDataMount(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningComputeInstanceDataMount(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
