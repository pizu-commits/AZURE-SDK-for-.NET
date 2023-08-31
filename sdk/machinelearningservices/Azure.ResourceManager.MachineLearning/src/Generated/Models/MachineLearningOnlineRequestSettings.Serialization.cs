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
    public partial class MachineLearningOnlineRequestSettings : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningOnlineRequestSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningOnlineRequestSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningOnlineRequestSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxConcurrentRequestsPerInstance))
            {
                writer.WritePropertyName("maxConcurrentRequestsPerInstance"u8);
                writer.WriteNumberValue(MaxConcurrentRequestsPerInstance.Value);
            }
            if (Optional.IsDefined(MaxQueueWait))
            {
                writer.WritePropertyName("maxQueueWait"u8);
                writer.WriteStringValue(MaxQueueWait.Value, "P");
            }
            if (Optional.IsDefined(RequestTimeout))
            {
                writer.WritePropertyName("requestTimeout"u8);
                writer.WriteStringValue(RequestTimeout.Value, "P");
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

        internal static MachineLearningOnlineRequestSettings DeserializeMachineLearningOnlineRequestSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxConcurrentRequestsPerInstance = default;
            Optional<TimeSpan> maxQueueWait = default;
            Optional<TimeSpan> requestTimeout = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxConcurrentRequestsPerInstance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentRequestsPerInstance = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxQueueWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxQueueWait = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("requestTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningOnlineRequestSettings(Optional.ToNullable(maxConcurrentRequestsPerInstance), Optional.ToNullable(maxQueueWait), Optional.ToNullable(requestTimeout), rawData);
        }

        MachineLearningOnlineRequestSettings IModelJsonSerializable<MachineLearningOnlineRequestSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningOnlineRequestSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningOnlineRequestSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningOnlineRequestSettings IModelSerializable<MachineLearningOnlineRequestSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningOnlineRequestSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningOnlineRequestSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningOnlineRequestSettings"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningOnlineRequestSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningOnlineRequestSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningOnlineRequestSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningOnlineRequestSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
