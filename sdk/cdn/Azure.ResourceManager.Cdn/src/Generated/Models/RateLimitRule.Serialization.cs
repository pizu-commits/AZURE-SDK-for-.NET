// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class RateLimitRule : IUtf8JsonSerializable, IJsonModel<RateLimitRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RateLimitRule>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RateLimitRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("rateLimitThreshold"u8);
            writer.WriteNumberValue(RateLimitThreshold);
            writer.WritePropertyName("rateLimitDurationInMinutes"u8);
            writer.WriteNumberValue(RateLimitDurationInMinutes);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            writer.WritePropertyName("priority"u8);
            writer.WriteNumberValue(Priority);
            writer.WritePropertyName("matchConditions"u8);
            writer.WriteStartArray();
            foreach (var item in MatchConditions)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToString());
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RateLimitRule IJsonModel<RateLimitRule>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RateLimitRule)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRateLimitRule(document.RootElement, options);
        }

        internal static RateLimitRule DeserializeRateLimitRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int rateLimitThreshold = default;
            int rateLimitDurationInMinutes = default;
            string name = default;
            Optional<CustomRuleEnabledState> enabledState = default;
            int priority = default;
            IList<CustomRuleMatchCondition> matchConditions = default;
            OverrideActionType action = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rateLimitThreshold"u8))
                {
                    rateLimitThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rateLimitDurationInMinutes"u8))
                {
                    rateLimitDurationInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enabledState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledState = new CustomRuleEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("matchConditions"u8))
                {
                    List<CustomRuleMatchCondition> array = new List<CustomRuleMatchCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomRuleMatchCondition.DeserializeCustomRuleMatchCondition(item));
                    }
                    matchConditions = array;
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = new OverrideActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RateLimitRule(name, Optional.ToNullable(enabledState), priority, matchConditions, action, serializedAdditionalRawData, rateLimitThreshold, rateLimitDurationInMinutes);
        }

        BinaryData IModel<RateLimitRule>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RateLimitRule)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RateLimitRule IModel<RateLimitRule>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RateLimitRule)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRateLimitRule(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RateLimitRule>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
