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
    internal partial class BatchRequestInternal : IUtf8JsonSerializable, IModelJsonSerializable<BatchRequestInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BatchRequestInternal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BatchRequestInternal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchRequestInternal>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(BatchItems))
            {
                writer.WritePropertyName("batchItems"u8);
                writer.WriteStartArray();
                foreach (var item in BatchItems)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BatchRequestItemInternal>)item).Serialize(writer, options);
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

        internal static BatchRequestInternal DeserializeBatchRequestInternal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<BatchRequestItemInternal>> batchItems = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("batchItems"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchRequestItemInternal> array = new List<BatchRequestItemInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchRequestItemInternal.DeserializeBatchRequestItemInternal(item));
                    }
                    batchItems = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BatchRequestInternal(Optional.ToList(batchItems), rawData);
        }

        BatchRequestInternal IModelJsonSerializable<BatchRequestInternal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchRequestInternal>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchRequestInternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BatchRequestInternal>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchRequestInternal>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BatchRequestInternal IModelSerializable<BatchRequestInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BatchRequestInternal>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBatchRequestInternal(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BatchRequestInternal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BatchRequestInternal"/> to convert. </param>
        public static implicit operator RequestContent(BatchRequestInternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BatchRequestInternal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BatchRequestInternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBatchRequestInternal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
