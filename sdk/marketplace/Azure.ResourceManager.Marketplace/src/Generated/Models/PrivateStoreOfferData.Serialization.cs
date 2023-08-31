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
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    public partial class PrivateStoreOfferData : IUtf8JsonSerializable, IModelJsonSerializable<PrivateStoreOfferData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PrivateStoreOfferData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PrivateStoreOfferData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SpecificPlanIdsLimitation))
            {
                writer.WritePropertyName("specificPlanIdsLimitation"u8);
                writer.WriteStartArray();
                foreach (var item in SpecificPlanIdsLimitation)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsUpdateSuppressedDueToIdempotence))
            {
                writer.WritePropertyName("updateSuppressedDueIdempotence"u8);
                writer.WriteBooleanValue(IsUpdateSuppressedDueToIdempotence.Value);
            }
            if (Optional.IsCollectionDefined(IconFileUris))
            {
                writer.WritePropertyName("iconFileUris"u8);
                writer.WriteStartObject();
                foreach (var item in IconFileUris)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.Value.AbsoluteUri);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Plans))
            {
                writer.WritePropertyName("plans"u8);
                writer.WriteStartArray();
                foreach (var item in Plans)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<PrivateStorePlan>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        internal static PrivateStoreOfferData DeserializePrivateStoreOfferData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> uniqueOfferId = default;
            Optional<string> offerDisplayName = default;
            Optional<string> publisherDisplayName = default;
            Optional<ETag> eTag = default;
            Optional<Guid> privateStoreId = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> modifiedAt = default;
            Optional<IList<string>> specificPlanIdsLimitation = default;
            Optional<bool> updateSuppressedDueIdempotence = default;
            Optional<IDictionary<string, Uri>> iconFileUris = default;
            Optional<IList<PrivateStorePlan>> plans = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("uniqueOfferId"u8))
                        {
                            uniqueOfferId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("offerDisplayName"u8))
                        {
                            offerDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherDisplayName"u8))
                        {
                            publisherDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eTag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eTag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateStoreId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateStoreId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("createdAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("modifiedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            modifiedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("specificPlanIdsLimitation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            specificPlanIdsLimitation = array;
                            continue;
                        }
                        if (property0.NameEquals("updateSuppressedDueIdempotence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateSuppressedDueIdempotence = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("iconFileUris"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, Uri> dictionary = new Dictionary<string, Uri>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, new Uri(property1.Value.GetString()));
                                }
                            }
                            iconFileUris = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("plans"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PrivateStorePlan> array = new List<PrivateStorePlan>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateStorePlan.DeserializePrivateStorePlan(item));
                            }
                            plans = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PrivateStoreOfferData(id, name, type, systemData.Value, uniqueOfferId.Value, offerDisplayName.Value, publisherDisplayName.Value, Optional.ToNullable(eTag), Optional.ToNullable(privateStoreId), Optional.ToNullable(createdAt), Optional.ToNullable(modifiedAt), Optional.ToList(specificPlanIdsLimitation), Optional.ToNullable(updateSuppressedDueIdempotence), Optional.ToDictionary(iconFileUris), Optional.ToList(plans), rawData);
        }

        PrivateStoreOfferData IModelJsonSerializable<PrivateStoreOfferData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateStoreOfferData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PrivateStoreOfferData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PrivateStoreOfferData IModelSerializable<PrivateStoreOfferData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePrivateStoreOfferData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PrivateStoreOfferData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PrivateStoreOfferData"/> to convert. </param>
        public static implicit operator RequestContent(PrivateStoreOfferData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PrivateStoreOfferData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PrivateStoreOfferData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePrivateStoreOfferData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
