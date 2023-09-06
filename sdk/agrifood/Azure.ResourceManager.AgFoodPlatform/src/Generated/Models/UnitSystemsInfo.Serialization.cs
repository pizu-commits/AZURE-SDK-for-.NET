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

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    public partial class UnitSystemsInfo : IUtf8JsonSerializable, IModelJsonSerializable<UnitSystemsInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UnitSystemsInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UnitSystemsInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UnitSystemsInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("key"u8);
            writer.WriteStringValue(Key);
            writer.WritePropertyName("values"u8);
            writer.WriteStartArray();
            foreach (var item in Values)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        internal static UnitSystemsInfo DeserializeUnitSystemsInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            IReadOnlyList<string> values = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    values = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnitSystemsInfo(key, values, rawData);
        }

        UnitSystemsInfo IModelJsonSerializable<UnitSystemsInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UnitSystemsInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnitSystemsInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UnitSystemsInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UnitSystemsInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UnitSystemsInfo IModelSerializable<UnitSystemsInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UnitSystemsInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUnitSystemsInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="UnitSystemsInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="UnitSystemsInfo"/> to convert. </param>
        public static implicit operator RequestContent(UnitSystemsInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="UnitSystemsInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator UnitSystemsInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUnitSystemsInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
