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
    internal partial class ListAmlUserFeatureResult : IUtf8JsonSerializable, IModelJsonSerializable<ListAmlUserFeatureResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ListAmlUserFeatureResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ListAmlUserFeatureResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListAmlUserFeatureResult>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ListAmlUserFeatureResult DeserializeListAmlUserFeatureResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MachineLearningUserFeature>> value = default;
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
                    List<MachineLearningUserFeature> array = new List<MachineLearningUserFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningUserFeature.DeserializeMachineLearningUserFeature(item));
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
            return new ListAmlUserFeatureResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        ListAmlUserFeatureResult IModelJsonSerializable<ListAmlUserFeatureResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListAmlUserFeatureResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeListAmlUserFeatureResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ListAmlUserFeatureResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListAmlUserFeatureResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ListAmlUserFeatureResult IModelSerializable<ListAmlUserFeatureResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListAmlUserFeatureResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeListAmlUserFeatureResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ListAmlUserFeatureResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ListAmlUserFeatureResult"/> to convert. </param>
        public static implicit operator RequestContent(ListAmlUserFeatureResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ListAmlUserFeatureResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ListAmlUserFeatureResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeListAmlUserFeatureResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
