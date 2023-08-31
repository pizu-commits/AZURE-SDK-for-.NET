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
    public partial class ReverseSearchAddressBatchResult : IUtf8JsonSerializable, IModelJsonSerializable<ReverseSearchAddressBatchResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReverseSearchAddressBatchResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReverseSearchAddressBatchResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReverseSearchAddressBatchResult>(this, options.Format);

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

        internal static ReverseSearchAddressBatchResult DeserializeReverseSearchAddressBatchResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ReverseSearchAddressBatchItem>> batchItems = default;
            Optional<BatchResultSummary> summary = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("batchItems"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReverseSearchAddressBatchItem> array = new List<ReverseSearchAddressBatchItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReverseSearchAddressBatchItem.DeserializeReverseSearchAddressBatchItem(item));
                    }
                    batchItems = array;
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    summary = BatchResultSummary.DeserializeBatchResultSummary(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReverseSearchAddressBatchResult(summary.Value, Optional.ToList(batchItems), rawData);
        }

        ReverseSearchAddressBatchResult IModelJsonSerializable<ReverseSearchAddressBatchResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReverseSearchAddressBatchResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReverseSearchAddressBatchResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReverseSearchAddressBatchResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReverseSearchAddressBatchResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReverseSearchAddressBatchResult IModelSerializable<ReverseSearchAddressBatchResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReverseSearchAddressBatchResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReverseSearchAddressBatchResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ReverseSearchAddressBatchResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ReverseSearchAddressBatchResult"/> to convert. </param>
        public static implicit operator RequestContent(ReverseSearchAddressBatchResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ReverseSearchAddressBatchResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ReverseSearchAddressBatchResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReverseSearchAddressBatchResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
