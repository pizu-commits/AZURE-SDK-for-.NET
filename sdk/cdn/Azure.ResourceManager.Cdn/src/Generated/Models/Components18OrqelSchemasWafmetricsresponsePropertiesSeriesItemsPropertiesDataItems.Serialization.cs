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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems : IUtf8JsonSerializable, IModelJsonSerializable<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DateOn))
            {
                writer.WritePropertyName("dateTime"u8);
                writer.WriteStringValue(DateOn.Value, "O");
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
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

        internal static Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems DeserializeComponents18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> dateTime = default;
            Optional<float> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(Optional.ToNullable(dateTime), Optional.ToNullable(value), rawData);
        }

        Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems IModelJsonSerializable<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeComponents18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(doc.RootElement, options);
        }

        BinaryData IModelSerializable<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems IModelSerializable<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeComponents18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems"/> to convert. </param>
        public static implicit operator RequestContent(Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeComponents18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
