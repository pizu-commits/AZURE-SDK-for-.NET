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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Advisor.Models
{
    public partial class ConfigData : IUtf8JsonSerializable, IModelJsonSerializable<ConfigData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConfigData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConfigData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConfigData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Exclude))
            {
                writer.WritePropertyName("exclude"u8);
                writer.WriteBooleanValue(Exclude.Value);
            }
            if (Optional.IsDefined(LowCpuThreshold))
            {
                writer.WritePropertyName("lowCpuThreshold"u8);
                writer.WriteStringValue(LowCpuThreshold.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Digests))
            {
                writer.WritePropertyName("digests"u8);
                writer.WriteStartArray();
                foreach (var item in Digests)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DigestConfig>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        internal static ConfigData DeserializeConfigData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<bool> exclude = default;
            Optional<CpuThreshold> lowCpuThreshold = default;
            Optional<IList<DigestConfig>> digests = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("exclude"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exclude = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lowCpuThreshold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lowCpuThreshold = new CpuThreshold(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("digests"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DigestConfig> array = new List<DigestConfig>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DigestConfig.DeserializeDigestConfig(item));
                            }
                            digests = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConfigData(id, name, type, systemData.Value, Optional.ToNullable(exclude), Optional.ToNullable(lowCpuThreshold), Optional.ToList(digests), rawData);
        }

        ConfigData IModelJsonSerializable<ConfigData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConfigData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConfigData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConfigData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConfigData IModelSerializable<ConfigData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConfigData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConfigData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConfigData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConfigData"/> to convert. </param>
        public static implicit operator RequestContent(ConfigData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConfigData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConfigData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConfigData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
