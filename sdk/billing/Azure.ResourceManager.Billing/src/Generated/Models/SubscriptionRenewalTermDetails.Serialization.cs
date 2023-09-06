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

namespace Azure.ResourceManager.Billing.Models
{
    public partial class SubscriptionRenewalTermDetails : IUtf8JsonSerializable, IModelJsonSerializable<SubscriptionRenewalTermDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SubscriptionRenewalTermDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SubscriptionRenewalTermDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubscriptionRenewalTermDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity"u8);
                writer.WriteNumberValue(Quantity.Value);
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

        internal static SubscriptionRenewalTermDetails DeserializeSubscriptionRenewalTermDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> billingFrequency = default;
            Optional<string> productTypeId = default;
            Optional<long> quantity = default;
            Optional<string> skuId = default;
            Optional<TimeSpan> termDuration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingFrequency"u8))
                {
                    billingFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productTypeId"u8))
                {
                    productTypeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quantity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quantity = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("skuId"u8))
                {
                    skuId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("termDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    termDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SubscriptionRenewalTermDetails(billingFrequency.Value, productTypeId.Value, Optional.ToNullable(quantity), skuId.Value, Optional.ToNullable(termDuration), rawData);
        }

        SubscriptionRenewalTermDetails IModelJsonSerializable<SubscriptionRenewalTermDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubscriptionRenewalTermDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionRenewalTermDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SubscriptionRenewalTermDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubscriptionRenewalTermDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SubscriptionRenewalTermDetails IModelSerializable<SubscriptionRenewalTermDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubscriptionRenewalTermDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSubscriptionRenewalTermDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SubscriptionRenewalTermDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SubscriptionRenewalTermDetails"/> to convert. </param>
        public static implicit operator RequestContent(SubscriptionRenewalTermDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SubscriptionRenewalTermDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SubscriptionRenewalTermDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSubscriptionRenewalTermDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
