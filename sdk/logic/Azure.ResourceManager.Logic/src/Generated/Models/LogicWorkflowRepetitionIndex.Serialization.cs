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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWorkflowRepetitionIndex : IUtf8JsonSerializable, IModelJsonSerializable<LogicWorkflowRepetitionIndex>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LogicWorkflowRepetitionIndex>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LogicWorkflowRepetitionIndex>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicWorkflowRepetitionIndex>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ScopeName))
            {
                writer.WritePropertyName("scopeName"u8);
                writer.WriteStringValue(ScopeName);
            }
            writer.WritePropertyName("itemIndex"u8);
            writer.WriteNumberValue(ItemIndex);
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

        internal static LogicWorkflowRepetitionIndex DeserializeLogicWorkflowRepetitionIndex(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> scopeName = default;
            int itemIndex = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scopeName"u8))
                {
                    scopeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemIndex"u8))
                {
                    itemIndex = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LogicWorkflowRepetitionIndex(scopeName.Value, itemIndex, rawData);
        }

        LogicWorkflowRepetitionIndex IModelJsonSerializable<LogicWorkflowRepetitionIndex>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicWorkflowRepetitionIndex>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowRepetitionIndex(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LogicWorkflowRepetitionIndex>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicWorkflowRepetitionIndex>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LogicWorkflowRepetitionIndex IModelSerializable<LogicWorkflowRepetitionIndex>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicWorkflowRepetitionIndex>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLogicWorkflowRepetitionIndex(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LogicWorkflowRepetitionIndex"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LogicWorkflowRepetitionIndex"/> to convert. </param>
        public static implicit operator RequestContent(LogicWorkflowRepetitionIndex model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LogicWorkflowRepetitionIndex"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LogicWorkflowRepetitionIndex(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLogicWorkflowRepetitionIndex(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
