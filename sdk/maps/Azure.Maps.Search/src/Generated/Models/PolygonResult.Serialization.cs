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

namespace Azure.Maps.Search.Models
{
    public partial class PolygonResult : IUtf8JsonSerializable, IModelJsonSerializable<PolygonResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PolygonResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PolygonResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolygonResult>(this, options.Format);

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

        internal static PolygonResult DeserializePolygonResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PolygonObject>> additionalData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PolygonObject> array = new List<PolygonObject>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolygonObject.DeserializePolygonObject(item));
                    }
                    additionalData = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PolygonResult(Optional.ToList(additionalData), rawData);
        }

        PolygonResult IModelJsonSerializable<PolygonResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolygonResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePolygonResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PolygonResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolygonResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PolygonResult IModelSerializable<PolygonResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolygonResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePolygonResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PolygonResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PolygonResult"/> to convert. </param>
        public static implicit operator RequestContent(PolygonResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PolygonResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PolygonResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePolygonResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
