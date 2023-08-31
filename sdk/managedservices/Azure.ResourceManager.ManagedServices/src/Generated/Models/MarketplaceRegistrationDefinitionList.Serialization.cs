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
using Azure.ResourceManager.ManagedServices;

namespace Azure.ResourceManager.ManagedServices.Models
{
    internal partial class MarketplaceRegistrationDefinitionList : IUtf8JsonSerializable, IModelJsonSerializable<MarketplaceRegistrationDefinitionList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MarketplaceRegistrationDefinitionList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MarketplaceRegistrationDefinitionList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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

        internal static MarketplaceRegistrationDefinitionList DeserializeMarketplaceRegistrationDefinitionList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ManagedServicesMarketplaceRegistrationData>> value = default;
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
                    List<ManagedServicesMarketplaceRegistrationData> array = new List<ManagedServicesMarketplaceRegistrationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicesMarketplaceRegistrationData.DeserializeManagedServicesMarketplaceRegistrationData(item));
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
            return new MarketplaceRegistrationDefinitionList(Optional.ToList(value), nextLink.Value, rawData);
        }

        MarketplaceRegistrationDefinitionList IModelJsonSerializable<MarketplaceRegistrationDefinitionList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMarketplaceRegistrationDefinitionList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MarketplaceRegistrationDefinitionList>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MarketplaceRegistrationDefinitionList IModelSerializable<MarketplaceRegistrationDefinitionList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMarketplaceRegistrationDefinitionList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MarketplaceRegistrationDefinitionList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MarketplaceRegistrationDefinitionList"/> to convert. </param>
        public static implicit operator RequestContent(MarketplaceRegistrationDefinitionList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MarketplaceRegistrationDefinitionList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MarketplaceRegistrationDefinitionList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMarketplaceRegistrationDefinitionList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
