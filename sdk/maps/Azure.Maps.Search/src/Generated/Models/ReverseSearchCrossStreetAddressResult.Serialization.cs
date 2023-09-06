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
    public partial class ReverseSearchCrossStreetAddressResult : IUtf8JsonSerializable, IModelJsonSerializable<ReverseSearchCrossStreetAddressResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReverseSearchCrossStreetAddressResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReverseSearchCrossStreetAddressResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReverseSearchCrossStreetAddressResult>(this, options.Format);

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

        internal static ReverseSearchCrossStreetAddressResult DeserializeReverseSearchCrossStreetAddressResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SearchSummary> summary = default;
            Optional<IReadOnlyList<ReverseSearchCrossStreetAddressResultItem>> addresses = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    summary = SearchSummary.DeserializeSearchSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("addresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReverseSearchCrossStreetAddressResultItem> array = new List<ReverseSearchCrossStreetAddressResultItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReverseSearchCrossStreetAddressResultItem.DeserializeReverseSearchCrossStreetAddressResultItem(item));
                    }
                    addresses = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReverseSearchCrossStreetAddressResult(summary.Value, Optional.ToList(addresses), rawData);
        }

        ReverseSearchCrossStreetAddressResult IModelJsonSerializable<ReverseSearchCrossStreetAddressResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReverseSearchCrossStreetAddressResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReverseSearchCrossStreetAddressResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReverseSearchCrossStreetAddressResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReverseSearchCrossStreetAddressResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReverseSearchCrossStreetAddressResult IModelSerializable<ReverseSearchCrossStreetAddressResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReverseSearchCrossStreetAddressResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReverseSearchCrossStreetAddressResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ReverseSearchCrossStreetAddressResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ReverseSearchCrossStreetAddressResult"/> to convert. </param>
        public static implicit operator RequestContent(ReverseSearchCrossStreetAddressResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ReverseSearchCrossStreetAddressResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ReverseSearchCrossStreetAddressResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReverseSearchCrossStreetAddressResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
