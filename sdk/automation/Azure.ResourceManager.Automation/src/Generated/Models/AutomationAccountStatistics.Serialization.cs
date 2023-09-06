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
    public partial class AutomationAccountStatistics : IUtf8JsonSerializable, IModelJsonSerializable<AutomationAccountStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutomationAccountStatistics>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutomationAccountStatistics>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationAccountStatistics>(this, options.Format);

            writer.WriteStartObject();
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

        internal static AutomationAccountStatistics DeserializeAutomationAccountStatistics(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> counterProperty = default;
            Optional<long> counterValue = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset?> endTime = default;
            Optional<string> id = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("counterProperty"u8))
                {
                    counterProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("counterValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    counterValue = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutomationAccountStatistics(counterProperty.Value, Optional.ToNullable(counterValue), Optional.ToNullable(startTime), Optional.ToNullable(endTime), id.Value, rawData);
        }

        AutomationAccountStatistics IModelJsonSerializable<AutomationAccountStatistics>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationAccountStatistics>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationAccountStatistics(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutomationAccountStatistics>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationAccountStatistics>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutomationAccountStatistics IModelSerializable<AutomationAccountStatistics>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationAccountStatistics>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutomationAccountStatistics(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutomationAccountStatistics"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutomationAccountStatistics"/> to convert. </param>
        public static implicit operator RequestContent(AutomationAccountStatistics model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutomationAccountStatistics"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutomationAccountStatistics(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutomationAccountStatistics(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
