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

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationPrivateLinkServiceConnectionStateProperty : IUtf8JsonSerializable, IModelJsonSerializable<AutomationPrivateLinkServiceConnectionStateProperty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutomationPrivateLinkServiceConnectionStateProperty>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutomationPrivateLinkServiceConnectionStateProperty>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationPrivateLinkServiceConnectionStateProperty>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        internal static AutomationPrivateLinkServiceConnectionStateProperty DeserializeAutomationPrivateLinkServiceConnectionStateProperty(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> status = default;
            Optional<string> description = default;
            Optional<string> actionsRequired = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"u8))
                {
                    actionsRequired = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutomationPrivateLinkServiceConnectionStateProperty(status.Value, description.Value, actionsRequired.Value, rawData);
        }

        AutomationPrivateLinkServiceConnectionStateProperty IModelJsonSerializable<AutomationPrivateLinkServiceConnectionStateProperty>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationPrivateLinkServiceConnectionStateProperty>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationPrivateLinkServiceConnectionStateProperty(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutomationPrivateLinkServiceConnectionStateProperty>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationPrivateLinkServiceConnectionStateProperty>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutomationPrivateLinkServiceConnectionStateProperty IModelSerializable<AutomationPrivateLinkServiceConnectionStateProperty>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationPrivateLinkServiceConnectionStateProperty>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutomationPrivateLinkServiceConnectionStateProperty(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutomationPrivateLinkServiceConnectionStateProperty"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutomationPrivateLinkServiceConnectionStateProperty"/> to convert. </param>
        public static implicit operator RequestContent(AutomationPrivateLinkServiceConnectionStateProperty model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutomationPrivateLinkServiceConnectionStateProperty"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutomationPrivateLinkServiceConnectionStateProperty(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutomationPrivateLinkServiceConnectionStateProperty(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
