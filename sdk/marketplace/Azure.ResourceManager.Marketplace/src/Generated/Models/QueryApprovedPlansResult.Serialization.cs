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

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class QueryApprovedPlansResult : IUtf8JsonSerializable, IModelJsonSerializable<QueryApprovedPlansResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<QueryApprovedPlansResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<QueryApprovedPlansResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QueryApprovedPlansResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStartArray();
                foreach (var item in Details)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<QueryApprovedPlansDetails>)item).Serialize(writer, options);
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

        internal static QueryApprovedPlansResult DeserializeQueryApprovedPlansResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<QueryApprovedPlansDetails>> details = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QueryApprovedPlansDetails> array = new List<QueryApprovedPlansDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryApprovedPlansDetails.DeserializeQueryApprovedPlansDetails(item));
                    }
                    details = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new QueryApprovedPlansResult(Optional.ToList(details), rawData);
        }

        QueryApprovedPlansResult IModelJsonSerializable<QueryApprovedPlansResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QueryApprovedPlansResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryApprovedPlansResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<QueryApprovedPlansResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QueryApprovedPlansResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        QueryApprovedPlansResult IModelSerializable<QueryApprovedPlansResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QueryApprovedPlansResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeQueryApprovedPlansResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="QueryApprovedPlansResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="QueryApprovedPlansResult"/> to convert. </param>
        public static implicit operator RequestContent(QueryApprovedPlansResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="QueryApprovedPlansResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator QueryApprovedPlansResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeQueryApprovedPlansResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
