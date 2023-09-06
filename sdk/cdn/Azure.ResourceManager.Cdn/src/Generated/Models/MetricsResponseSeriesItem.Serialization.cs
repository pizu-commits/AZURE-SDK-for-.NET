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
    public partial class MetricsResponseSeriesItem : IUtf8JsonSerializable, IModelJsonSerializable<MetricsResponseSeriesItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MetricsResponseSeriesItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MetricsResponseSeriesItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetricsResponseSeriesItem>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Metric))
            {
                writer.WritePropertyName("metric"u8);
                writer.WriteStringValue(Metric);
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Groups))
            {
                writer.WritePropertyName("groups"u8);
                writer.WriteStartArray();
                foreach (var item in Groups)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MetricsResponseSeriesPropertiesItemsItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>)item).Serialize(writer, options);
                    }
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

        internal static MetricsResponseSeriesItem DeserializeMetricsResponseSeriesItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> metric = default;
            Optional<MetricsResponseSeriesItemUnit> unit = default;
            Optional<IReadOnlyList<MetricsResponseSeriesPropertiesItemsItem>> groups = default;
            Optional<IReadOnlyList<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>> data = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metric"u8))
                {
                    metric = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new MetricsResponseSeriesItemUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricsResponseSeriesPropertiesItemsItem> array = new List<MetricsResponseSeriesPropertiesItemsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricsResponseSeriesPropertiesItemsItem.DeserializeMetricsResponseSeriesPropertiesItemsItem(item));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems> array = new List<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems.DeserializeComponents1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems(item));
                    }
                    data = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MetricsResponseSeriesItem(metric.Value, Optional.ToNullable(unit), Optional.ToList(groups), Optional.ToList(data), rawData);
        }

        MetricsResponseSeriesItem IModelJsonSerializable<MetricsResponseSeriesItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetricsResponseSeriesItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricsResponseSeriesItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MetricsResponseSeriesItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetricsResponseSeriesItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MetricsResponseSeriesItem IModelSerializable<MetricsResponseSeriesItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetricsResponseSeriesItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMetricsResponseSeriesItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MetricsResponseSeriesItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MetricsResponseSeriesItem"/> to convert. </param>
        public static implicit operator RequestContent(MetricsResponseSeriesItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MetricsResponseSeriesItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MetricsResponseSeriesItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMetricsResponseSeriesItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
