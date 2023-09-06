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
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class BuildpackBindingResourceList : IUtf8JsonSerializable, IModelJsonSerializable<BuildpackBindingResourceList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BuildpackBindingResourceList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BuildpackBindingResourceList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BuildpackBindingResourceList>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AppPlatformBuildpackBindingData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static BuildpackBindingResourceList DeserializeBuildpackBindingResourceList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AppPlatformBuildpackBindingData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformBuildpackBindingData> array = new List<AppPlatformBuildpackBindingData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformBuildpackBindingData.DeserializeAppPlatformBuildpackBindingData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BuildpackBindingResourceList(Optional.ToList(value), nextLink.Value, rawData);
        }

        BuildpackBindingResourceList IModelJsonSerializable<BuildpackBindingResourceList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BuildpackBindingResourceList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBuildpackBindingResourceList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BuildpackBindingResourceList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BuildpackBindingResourceList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BuildpackBindingResourceList IModelSerializable<BuildpackBindingResourceList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BuildpackBindingResourceList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBuildpackBindingResourceList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BuildpackBindingResourceList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BuildpackBindingResourceList"/> to convert. </param>
        public static implicit operator RequestContent(BuildpackBindingResourceList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BuildpackBindingResourceList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BuildpackBindingResourceList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBuildpackBindingResourceList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
