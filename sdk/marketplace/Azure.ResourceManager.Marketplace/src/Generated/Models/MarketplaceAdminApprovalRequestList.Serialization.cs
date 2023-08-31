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
using Azure.ResourceManager.Marketplace;

namespace Azure.ResourceManager.Marketplace.Models
{
    internal partial class MarketplaceAdminApprovalRequestList : IUtf8JsonSerializable, IModelJsonSerializable<MarketplaceAdminApprovalRequestList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MarketplaceAdminApprovalRequestList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MarketplaceAdminApprovalRequestList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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
                        ((IModelJsonSerializable<MarketplaceAdminApprovalRequestData>)item).Serialize(writer, options);
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

        internal static MarketplaceAdminApprovalRequestList DeserializeMarketplaceAdminApprovalRequestList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MarketplaceAdminApprovalRequestData>> value = default;
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
                    List<MarketplaceAdminApprovalRequestData> array = new List<MarketplaceAdminApprovalRequestData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MarketplaceAdminApprovalRequestData.DeserializeMarketplaceAdminApprovalRequestData(item));
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
            return new MarketplaceAdminApprovalRequestList(Optional.ToList(value), nextLink.Value, rawData);
        }

        MarketplaceAdminApprovalRequestList IModelJsonSerializable<MarketplaceAdminApprovalRequestList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMarketplaceAdminApprovalRequestList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MarketplaceAdminApprovalRequestList>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MarketplaceAdminApprovalRequestList IModelSerializable<MarketplaceAdminApprovalRequestList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMarketplaceAdminApprovalRequestList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MarketplaceAdminApprovalRequestList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MarketplaceAdminApprovalRequestList"/> to convert. </param>
        public static implicit operator RequestContent(MarketplaceAdminApprovalRequestList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MarketplaceAdminApprovalRequestList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MarketplaceAdminApprovalRequestList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMarketplaceAdminApprovalRequestList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
