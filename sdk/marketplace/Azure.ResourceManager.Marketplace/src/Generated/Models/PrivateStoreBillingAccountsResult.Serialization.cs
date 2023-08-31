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
    public partial class PrivateStoreBillingAccountsResult : IUtf8JsonSerializable, IModelJsonSerializable<PrivateStoreBillingAccountsResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PrivateStoreBillingAccountsResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PrivateStoreBillingAccountsResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(BillingAccounts))
            {
                writer.WritePropertyName("billingAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in BillingAccounts)
                {
                    writer.WriteStringValue(item);
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

        internal static PrivateStoreBillingAccountsResult DeserializePrivateStoreBillingAccountsResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> billingAccounts = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingAccounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    billingAccounts = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PrivateStoreBillingAccountsResult(Optional.ToList(billingAccounts), rawData);
        }

        PrivateStoreBillingAccountsResult IModelJsonSerializable<PrivateStoreBillingAccountsResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateStoreBillingAccountsResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PrivateStoreBillingAccountsResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PrivateStoreBillingAccountsResult IModelSerializable<PrivateStoreBillingAccountsResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePrivateStoreBillingAccountsResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PrivateStoreBillingAccountsResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PrivateStoreBillingAccountsResult"/> to convert. </param>
        public static implicit operator RequestContent(PrivateStoreBillingAccountsResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PrivateStoreBillingAccountsResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PrivateStoreBillingAccountsResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePrivateStoreBillingAccountsResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
