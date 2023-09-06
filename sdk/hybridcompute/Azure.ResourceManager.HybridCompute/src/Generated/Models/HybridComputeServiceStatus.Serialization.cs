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

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class HybridComputeServiceStatus : IUtf8JsonSerializable, IModelJsonSerializable<HybridComputeServiceStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HybridComputeServiceStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HybridComputeServiceStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridComputeServiceStatus>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(StartupType))
            {
                writer.WritePropertyName("startupType"u8);
                writer.WriteStringValue(StartupType);
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

        internal static HybridComputeServiceStatus DeserializeHybridComputeServiceStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> status = default;
            Optional<string> startupType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startupType"u8))
                {
                    startupType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HybridComputeServiceStatus(status.Value, startupType.Value, rawData);
        }

        HybridComputeServiceStatus IModelJsonSerializable<HybridComputeServiceStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridComputeServiceStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridComputeServiceStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HybridComputeServiceStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridComputeServiceStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HybridComputeServiceStatus IModelSerializable<HybridComputeServiceStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HybridComputeServiceStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHybridComputeServiceStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HybridComputeServiceStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HybridComputeServiceStatus"/> to convert. </param>
        public static implicit operator RequestContent(HybridComputeServiceStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HybridComputeServiceStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HybridComputeServiceStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHybridComputeServiceStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
