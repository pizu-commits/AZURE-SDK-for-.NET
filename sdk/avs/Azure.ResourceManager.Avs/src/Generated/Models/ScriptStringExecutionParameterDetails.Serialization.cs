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

namespace Azure.ResourceManager.Avs.Models
{
    public partial class ScriptStringExecutionParameterDetails : IUtf8JsonSerializable, IModelJsonSerializable<ScriptStringExecutionParameterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ScriptStringExecutionParameterDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ScriptStringExecutionParameterDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScriptStringExecutionParameterDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ParameterType.ToString());
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

        internal static ScriptStringExecutionParameterDetails DeserializeScriptStringExecutionParameterDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> value = default;
            string name = default;
            ScriptExecutionParameterType type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ScriptExecutionParameterType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ScriptStringExecutionParameterDetails(name, type, value.Value, rawData);
        }

        ScriptStringExecutionParameterDetails IModelJsonSerializable<ScriptStringExecutionParameterDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScriptStringExecutionParameterDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeScriptStringExecutionParameterDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ScriptStringExecutionParameterDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScriptStringExecutionParameterDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ScriptStringExecutionParameterDetails IModelSerializable<ScriptStringExecutionParameterDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScriptStringExecutionParameterDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeScriptStringExecutionParameterDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ScriptStringExecutionParameterDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ScriptStringExecutionParameterDetails"/> to convert. </param>
        public static implicit operator RequestContent(ScriptStringExecutionParameterDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ScriptStringExecutionParameterDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ScriptStringExecutionParameterDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeScriptStringExecutionParameterDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
