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

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class SubscriptionDelegationSettingProperties : IUtf8JsonSerializable, IModelJsonSerializable<SubscriptionDelegationSettingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SubscriptionDelegationSettingProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SubscriptionDelegationSettingProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubscriptionDelegationSettingProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsSubscriptionDelegationEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsSubscriptionDelegationEnabled.Value);
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

        internal static SubscriptionDelegationSettingProperties DeserializeSubscriptionDelegationSettingProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SubscriptionDelegationSettingProperties(Optional.ToNullable(enabled), rawData);
        }

        SubscriptionDelegationSettingProperties IModelJsonSerializable<SubscriptionDelegationSettingProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubscriptionDelegationSettingProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionDelegationSettingProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SubscriptionDelegationSettingProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubscriptionDelegationSettingProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SubscriptionDelegationSettingProperties IModelSerializable<SubscriptionDelegationSettingProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubscriptionDelegationSettingProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSubscriptionDelegationSettingProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SubscriptionDelegationSettingProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SubscriptionDelegationSettingProperties"/> to convert. </param>
        public static implicit operator RequestContent(SubscriptionDelegationSettingProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SubscriptionDelegationSettingProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SubscriptionDelegationSettingProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSubscriptionDelegationSettingProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
