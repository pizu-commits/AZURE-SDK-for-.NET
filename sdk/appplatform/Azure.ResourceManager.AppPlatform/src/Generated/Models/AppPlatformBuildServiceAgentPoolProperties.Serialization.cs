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

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformBuildServiceAgentPoolProperties : IUtf8JsonSerializable, IModelJsonSerializable<AppPlatformBuildServiceAgentPoolProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppPlatformBuildServiceAgentPoolProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppPlatformBuildServiceAgentPoolProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppPlatformBuildServiceAgentPoolProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PoolSize))
            {
                writer.WritePropertyName("poolSize"u8);
                if (PoolSize is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BuildServiceAgentPoolSizeProperties>)PoolSize).Serialize(writer, options);
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

        internal static AppPlatformBuildServiceAgentPoolProperties DeserializeAppPlatformBuildServiceAgentPoolProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> provisioningState = default;
            Optional<BuildServiceAgentPoolSizeProperties> poolSize = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("poolSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    poolSize = BuildServiceAgentPoolSizeProperties.DeserializeBuildServiceAgentPoolSizeProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppPlatformBuildServiceAgentPoolProperties(provisioningState.Value, poolSize.Value, rawData);
        }

        AppPlatformBuildServiceAgentPoolProperties IModelJsonSerializable<AppPlatformBuildServiceAgentPoolProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppPlatformBuildServiceAgentPoolProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformBuildServiceAgentPoolProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppPlatformBuildServiceAgentPoolProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppPlatformBuildServiceAgentPoolProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppPlatformBuildServiceAgentPoolProperties IModelSerializable<AppPlatformBuildServiceAgentPoolProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppPlatformBuildServiceAgentPoolProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppPlatformBuildServiceAgentPoolProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppPlatformBuildServiceAgentPoolProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppPlatformBuildServiceAgentPoolProperties"/> to convert. </param>
        public static implicit operator RequestContent(AppPlatformBuildServiceAgentPoolProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppPlatformBuildServiceAgentPoolProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppPlatformBuildServiceAgentPoolProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppPlatformBuildServiceAgentPoolProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
