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
    public partial class AutomationConnectionTypeCreateOrUpdateContent : IUtf8JsonSerializable, IModelJsonSerializable<AutomationConnectionTypeCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutomationConnectionTypeCreateOrUpdateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutomationConnectionTypeCreateOrUpdateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationConnectionTypeCreateOrUpdateContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IsGlobal))
            {
                writer.WritePropertyName("isGlobal"u8);
                writer.WriteBooleanValue(IsGlobal.Value);
            }
            writer.WritePropertyName("fieldDefinitions"u8);
            writer.WriteStartObject();
            foreach (var item in FieldDefinitions)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AutomationConnectionFieldDefinition>)item.Value).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
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

        internal static AutomationConnectionTypeCreateOrUpdateContent DeserializeAutomationConnectionTypeCreateOrUpdateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<bool> isGlobal = default;
            IDictionary<string, AutomationConnectionFieldDefinition> fieldDefinitions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("isGlobal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isGlobal = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("fieldDefinitions"u8))
                        {
                            Dictionary<string, AutomationConnectionFieldDefinition> dictionary = new Dictionary<string, AutomationConnectionFieldDefinition>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, AutomationConnectionFieldDefinition.DeserializeAutomationConnectionFieldDefinition(property1.Value));
                            }
                            fieldDefinitions = dictionary;
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
            return new AutomationConnectionTypeCreateOrUpdateContent(name, Optional.ToNullable(isGlobal), fieldDefinitions, rawData);
        }

        AutomationConnectionTypeCreateOrUpdateContent IModelJsonSerializable<AutomationConnectionTypeCreateOrUpdateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationConnectionTypeCreateOrUpdateContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationConnectionTypeCreateOrUpdateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutomationConnectionTypeCreateOrUpdateContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationConnectionTypeCreateOrUpdateContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutomationConnectionTypeCreateOrUpdateContent IModelSerializable<AutomationConnectionTypeCreateOrUpdateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationConnectionTypeCreateOrUpdateContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutomationConnectionTypeCreateOrUpdateContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutomationConnectionTypeCreateOrUpdateContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutomationConnectionTypeCreateOrUpdateContent"/> to convert. </param>
        public static implicit operator RequestContent(AutomationConnectionTypeCreateOrUpdateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutomationConnectionTypeCreateOrUpdateContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutomationConnectionTypeCreateOrUpdateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutomationConnectionTypeCreateOrUpdateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
