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
    public partial class LogicWorkflowRunCorrelation : IUtf8JsonSerializable, IModelJsonSerializable<LogicWorkflowRunCorrelation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LogicWorkflowRunCorrelation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LogicWorkflowRunCorrelation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicWorkflowRunCorrelation>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ClientTrackingId))
            {
                writer.WritePropertyName("clientTrackingId"u8);
                writer.WriteStringValue(ClientTrackingId);
            }
            if (Optional.IsCollectionDefined(ClientKeywords))
            {
                writer.WritePropertyName("clientKeywords"u8);
                writer.WriteStartArray();
                foreach (var item in ClientKeywords)
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

        internal static LogicWorkflowRunCorrelation DeserializeLogicWorkflowRunCorrelation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientTrackingId = default;
            Optional<IList<string>> clientKeywords = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientTrackingId"u8))
                {
                    clientTrackingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientKeywords"u8))
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
                    clientKeywords = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LogicWorkflowRunCorrelation(clientTrackingId.Value, Optional.ToList(clientKeywords), rawData);
        }

        LogicWorkflowRunCorrelation IModelJsonSerializable<LogicWorkflowRunCorrelation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicWorkflowRunCorrelation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowRunCorrelation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LogicWorkflowRunCorrelation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicWorkflowRunCorrelation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LogicWorkflowRunCorrelation IModelSerializable<LogicWorkflowRunCorrelation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogicWorkflowRunCorrelation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLogicWorkflowRunCorrelation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LogicWorkflowRunCorrelation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LogicWorkflowRunCorrelation"/> to convert. </param>
        public static implicit operator RequestContent(LogicWorkflowRunCorrelation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LogicWorkflowRunCorrelation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LogicWorkflowRunCorrelation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLogicWorkflowRunCorrelation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
