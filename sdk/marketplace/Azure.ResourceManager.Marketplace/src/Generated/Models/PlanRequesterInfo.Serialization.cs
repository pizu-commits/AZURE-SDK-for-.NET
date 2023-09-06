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
    public partial class PlanRequesterInfo : IUtf8JsonSerializable, IModelJsonSerializable<PlanRequesterInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PlanRequesterInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PlanRequesterInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PlanRequesterInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(SubscriptionName))
            {
                writer.WritePropertyName("subscriptionName"u8);
                writer.WriteStringValue(SubscriptionName);
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

        internal static PlanRequesterInfo DeserializePlanRequesterInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> user = default;
            Optional<string> date = default;
            Optional<string> justification = default;
            Optional<string> subscriptionId = default;
            Optional<string> subscriptionName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("user"u8))
                {
                    user = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("date"u8))
                {
                    date = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("justification"u8))
                {
                    justification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionName"u8))
                {
                    subscriptionName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PlanRequesterInfo(user.Value, date.Value, justification.Value, subscriptionId.Value, subscriptionName.Value, rawData);
        }

        PlanRequesterInfo IModelJsonSerializable<PlanRequesterInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PlanRequesterInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePlanRequesterInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PlanRequesterInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PlanRequesterInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PlanRequesterInfo IModelSerializable<PlanRequesterInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PlanRequesterInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePlanRequesterInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PlanRequesterInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PlanRequesterInfo"/> to convert. </param>
        public static implicit operator RequestContent(PlanRequesterInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PlanRequesterInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PlanRequesterInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePlanRequesterInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
