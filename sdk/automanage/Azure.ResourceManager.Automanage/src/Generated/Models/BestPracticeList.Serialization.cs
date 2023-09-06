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
using Azure.ResourceManager.Automanage;

namespace Azure.ResourceManager.Automanage.Models
{
    internal partial class BestPracticeList : IUtf8JsonSerializable, IModelJsonSerializable<BestPracticeList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BestPracticeList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BestPracticeList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BestPracticeList>(this, options.Format);

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
                        ((IModelJsonSerializable<AutomanageBestPracticeData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static BestPracticeList DeserializeBestPracticeList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AutomanageBestPracticeData>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AutomanageBestPracticeData> array = new List<AutomanageBestPracticeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutomanageBestPracticeData.DeserializeAutomanageBestPracticeData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BestPracticeList(Optional.ToList(value), rawData);
        }

        BestPracticeList IModelJsonSerializable<BestPracticeList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BestPracticeList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBestPracticeList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BestPracticeList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BestPracticeList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BestPracticeList IModelSerializable<BestPracticeList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BestPracticeList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBestPracticeList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BestPracticeList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BestPracticeList"/> to convert. </param>
        public static implicit operator RequestContent(BestPracticeList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BestPracticeList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BestPracticeList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBestPracticeList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
