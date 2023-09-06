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
    public partial class MachineLearningAssetBase : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningAssetBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningAssetBase>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningAssetBase>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningAssetBase>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsAnonymous))
            {
                writer.WritePropertyName("isAnonymous"u8);
                writer.WriteBooleanValue(IsAnonymous.Value);
            }
            if (Optional.IsDefined(IsArchived))
            {
                writer.WritePropertyName("isArchived"u8);
                writer.WriteBooleanValue(IsArchived.Value);
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
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags"u8);
                    writer.WriteStartObject();
                    foreach (var item in Tags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("tags");
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

        internal static MachineLearningAssetBase DeserializeMachineLearningAssetBase(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isAnonymous = default;
            Optional<bool> isArchived = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, string>> tags = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isAnonymous"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAnonymous = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isArchived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
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
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningAssetBase(description.Value, Optional.ToDictionary(properties), Optional.ToDictionary(tags), Optional.ToNullable(isAnonymous), Optional.ToNullable(isArchived), rawData);
        }

        MachineLearningAssetBase IModelJsonSerializable<MachineLearningAssetBase>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningAssetBase>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAssetBase(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningAssetBase>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningAssetBase>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningAssetBase IModelSerializable<MachineLearningAssetBase>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningAssetBase>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningAssetBase(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningAssetBase"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningAssetBase"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningAssetBase model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningAssetBase"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningAssetBase(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningAssetBase(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
