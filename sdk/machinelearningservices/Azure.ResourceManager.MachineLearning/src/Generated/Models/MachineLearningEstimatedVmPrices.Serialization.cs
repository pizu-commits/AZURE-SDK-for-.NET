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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningEstimatedVmPrices : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningEstimatedVmPrices>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningEstimatedVmPrices>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningEstimatedVmPrices>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningEstimatedVmPrices>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("billingCurrency"u8);
            writer.WriteStringValue(BillingCurrency.ToString());
            writer.WritePropertyName("unitOfMeasure"u8);
            writer.WriteStringValue(UnitOfMeasure.ToString());
            writer.WritePropertyName("values"u8);
            writer.WriteStartArray();
            foreach (var item in Values)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MachineLearningEstimatedVmPrice>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static MachineLearningEstimatedVmPrices DeserializeMachineLearningEstimatedVmPrices(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningBillingCurrency billingCurrency = default;
            MachineLearningUnitOfMeasure unitOfMeasure = default;
            IReadOnlyList<MachineLearningEstimatedVmPrice> values = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingCurrency"u8))
                {
                    billingCurrency = new MachineLearningBillingCurrency(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("unitOfMeasure"u8))
                {
                    unitOfMeasure = new MachineLearningUnitOfMeasure(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    List<MachineLearningEstimatedVmPrice> array = new List<MachineLearningEstimatedVmPrice>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningEstimatedVmPrice.DeserializeMachineLearningEstimatedVmPrice(item));
                    }
                    values = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningEstimatedVmPrices(billingCurrency, unitOfMeasure, values, rawData);
        }

        MachineLearningEstimatedVmPrices IModelJsonSerializable<MachineLearningEstimatedVmPrices>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningEstimatedVmPrices>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningEstimatedVmPrices(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningEstimatedVmPrices>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningEstimatedVmPrices>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningEstimatedVmPrices IModelSerializable<MachineLearningEstimatedVmPrices>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningEstimatedVmPrices>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningEstimatedVmPrices(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningEstimatedVmPrices"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningEstimatedVmPrices"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningEstimatedVmPrices model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningEstimatedVmPrices"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningEstimatedVmPrices(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningEstimatedVmPrices(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
