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
    public partial class ConfigServerSettings : IUtf8JsonSerializable, IModelJsonSerializable<ConfigServerSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConfigServerSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConfigServerSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConfigServerSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(GitProperty))
            {
                writer.WritePropertyName("gitProperty"u8);
                if (GitProperty is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AppPlatformConfigServerGitProperty>)GitProperty).Serialize(writer, options);
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

        internal static ConfigServerSettings DeserializeConfigServerSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppPlatformConfigServerGitProperty> gitProperty = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("gitProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gitProperty = AppPlatformConfigServerGitProperty.DeserializeAppPlatformConfigServerGitProperty(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConfigServerSettings(gitProperty.Value, rawData);
        }

        ConfigServerSettings IModelJsonSerializable<ConfigServerSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConfigServerSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigServerSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConfigServerSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConfigServerSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConfigServerSettings IModelSerializable<ConfigServerSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConfigServerSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConfigServerSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConfigServerSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConfigServerSettings"/> to convert. </param>
        public static implicit operator RequestContent(ConfigServerSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConfigServerSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConfigServerSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConfigServerSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
