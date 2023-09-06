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
    public partial class AutomationActivityParameterValidationSet : IUtf8JsonSerializable, IModelJsonSerializable<AutomationActivityParameterValidationSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutomationActivityParameterValidationSet>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutomationActivityParameterValidationSet>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationActivityParameterValidationSet>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MemberValue))
            {
                writer.WritePropertyName("memberValue"u8);
                writer.WriteStringValue(MemberValue);
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

        internal static AutomationActivityParameterValidationSet DeserializeAutomationActivityParameterValidationSet(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> memberValue = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("memberValue"u8))
                {
                    memberValue = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutomationActivityParameterValidationSet(memberValue.Value, rawData);
        }

        AutomationActivityParameterValidationSet IModelJsonSerializable<AutomationActivityParameterValidationSet>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationActivityParameterValidationSet>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationActivityParameterValidationSet(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutomationActivityParameterValidationSet>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationActivityParameterValidationSet>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutomationActivityParameterValidationSet IModelSerializable<AutomationActivityParameterValidationSet>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationActivityParameterValidationSet>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutomationActivityParameterValidationSet(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutomationActivityParameterValidationSet"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutomationActivityParameterValidationSet"/> to convert. </param>
        public static implicit operator RequestContent(AutomationActivityParameterValidationSet model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutomationActivityParameterValidationSet"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutomationActivityParameterValidationSet(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutomationActivityParameterValidationSet(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
