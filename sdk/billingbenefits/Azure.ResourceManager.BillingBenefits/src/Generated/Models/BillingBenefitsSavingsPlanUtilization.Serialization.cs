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

namespace Azure.ResourceManager.BillingBenefits.Models
{
    public partial class BillingBenefitsSavingsPlanUtilization : IUtf8JsonSerializable, IModelJsonSerializable<BillingBenefitsSavingsPlanUtilization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BillingBenefitsSavingsPlanUtilization>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BillingBenefitsSavingsPlanUtilization>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BillingBenefitsSavingsPlanUtilization>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Aggregates))
            {
                writer.WritePropertyName("aggregates"u8);
                writer.WriteStartArray();
                foreach (var item in Aggregates)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BillingBenefitsSavingsPlanUtilizationAggregate>)item).Serialize(writer, options);
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

        internal static BillingBenefitsSavingsPlanUtilization DeserializeBillingBenefitsSavingsPlanUtilization(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> trend = default;
            Optional<IReadOnlyList<BillingBenefitsSavingsPlanUtilizationAggregate>> aggregates = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trend"u8))
                {
                    trend = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BillingBenefitsSavingsPlanUtilizationAggregate> array = new List<BillingBenefitsSavingsPlanUtilizationAggregate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BillingBenefitsSavingsPlanUtilizationAggregate.DeserializeBillingBenefitsSavingsPlanUtilizationAggregate(item));
                    }
                    aggregates = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BillingBenefitsSavingsPlanUtilization(trend.Value, Optional.ToList(aggregates), rawData);
        }

        BillingBenefitsSavingsPlanUtilization IModelJsonSerializable<BillingBenefitsSavingsPlanUtilization>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BillingBenefitsSavingsPlanUtilization>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingBenefitsSavingsPlanUtilization(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BillingBenefitsSavingsPlanUtilization>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BillingBenefitsSavingsPlanUtilization>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BillingBenefitsSavingsPlanUtilization IModelSerializable<BillingBenefitsSavingsPlanUtilization>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BillingBenefitsSavingsPlanUtilization>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBillingBenefitsSavingsPlanUtilization(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BillingBenefitsSavingsPlanUtilization"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BillingBenefitsSavingsPlanUtilization"/> to convert. </param>
        public static implicit operator RequestContent(BillingBenefitsSavingsPlanUtilization model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BillingBenefitsSavingsPlanUtilization"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BillingBenefitsSavingsPlanUtilization(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBillingBenefitsSavingsPlanUtilization(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
